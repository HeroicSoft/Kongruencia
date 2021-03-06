﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LinqKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Kongruencia.Server {
    [Route("api/[controller]")]
    [ApiController]
    public class CoveragesController : ControllerBase
    {
        private readonly ILogger<CoveragesController> _logger;
        private readonly IMapper _mapper;
        private readonly ICoverageService _coverageService;

        public CoveragesController(ILogger<CoveragesController> logger, IMapper mapper, ICoverageService coverageService)
            => (_logger, _mapper, _coverageService) = (logger, mapper, coverageService);

        [HttpGet("{id}")]
        public async Task<ActionResult<CoverageResource>> Get(int id)
        {
            var result = await _coverageService.GetAsync(id);

            if (!result.isSuccess)
                return NotFound();

            return Ok(result.result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoverageResource>>> Get(
            [FromQuery] string productName = null,
            [FromQuery] string branchName = null,
            [FromQuery] int buildNumber = -1,
            [FromQuery] DateTime? startDate = null,
            [FromQuery] DateTime? endDate = null
        )
        {
            if (!(startDate is null) && !(endDate is null) && startDate > endDate)
                return BadRequest("End date must be greater than start date");

            var predicate = PredicateBuilder.New<Coverage>(true);
            if (!(productName is null))
                predicate = predicate.And(c => c.ProductName.Equals(productName));
            if (!(branchName is null))
                predicate = predicate.And(c => c.BranchName.Equals(branchName));
            if (!(buildNumber is -1))
                predicate = predicate.And(c => c.BuildNumber == buildNumber);
            if (!(startDate is null))
                predicate = predicate.And(c => c.Timestamp > startDate);
            if (!(endDate is null))
                predicate = predicate.And(c => c.Timestamp < endDate);

            var result = await _coverageService.ListAsync(predicate);
            if (!result.isSuccess)
                return NotFound();

            return Ok(result.result);
        }

        [HttpPost]
        [Consumes("application/xml")]
        [ProducesResponseType( StatusCodes.Status201Created )]
        [ProducesResponseType( StatusCodes.Status400BadRequest )]
        public async Task<IActionResult> Post([FromBody] AddCoverageResource addCoverageResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var coverage = _mapper.Map<Coverage>(addCoverageResource);
            var addResult = await _coverageService.AddAsync(coverage);
            if (!addResult.isSuccess)
                return BadRequest(addResult.error.message);

            return CreatedAtAction( nameof( Get ), new { id = addResult.result.Id } );
        }
    }
}