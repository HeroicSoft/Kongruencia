﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class coverage {
    
    private project projectField;
    
    private testproject testprojectField;
    
    private string cloverField;
    
    private string generatedField;
    
    /// <remarks/>
    public project project {
        get {
            return this.projectField;
        }
        set {
            this.projectField = value;
        }
    }
    
    /// <remarks/>
    public testproject testproject {
        get {
            return this.testprojectField;
        }
        set {
            this.testprojectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
    public string clover {
        get {
            return this.cloverField;
        }
        set {
            this.cloverField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string generated {
        get {
            return this.generatedField;
        }
        set {
            this.generatedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class project {
    
    private projectMetrics metricsField;
    
    private package[] packageField;
    
    private string nameField;
    
    private string timestampField;
    
    /// <remarks/>
    public projectMetrics metrics {
        get {
            return this.metricsField;
        }
        set {
            this.metricsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("package")]
    public package[] package {
        get {
            return this.packageField;
        }
        set {
            this.packageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class projectMetrics : packageMetrics {
    
    private string packagesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string packages {
        get {
            return this.packagesField;
        }
        set {
            this.packagesField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(projectMetrics))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class packageMetrics : fileMetrics {
    
    private string filesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string files {
        get {
            return this.filesField;
        }
        set {
            this.filesField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(packageMetrics))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(projectMetrics))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class fileMetrics : classMetrics {
    
    private string classesField;
    
    private string locField;
    
    private string nclocField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string classes {
        get {
            return this.classesField;
        }
        set {
            this.classesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string loc {
        get {
            return this.locField;
        }
        set {
            this.locField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string ncloc {
        get {
            return this.nclocField;
        }
        set {
            this.nclocField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(fileMetrics))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(packageMetrics))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(projectMetrics))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class classMetrics {
    
    private string complexityField;
    
    private string elementsField;
    
    private string coveredelementsField;
    
    private string conditionalsField;
    
    private string coveredconditionalsField;
    
    private string statementsField;
    
    private string coveredstatementsField;
    
    private string coveredmethodsField;
    
    private string methodsField;
    
    private decimal testdurationField;
    
    private bool testdurationFieldSpecified;
    
    private string testfailuresField;
    
    private string testpassesField;
    
    private string testrunsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string complexity {
        get {
            return this.complexityField;
        }
        set {
            this.complexityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string elements {
        get {
            return this.elementsField;
        }
        set {
            this.elementsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string coveredelements {
        get {
            return this.coveredelementsField;
        }
        set {
            this.coveredelementsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string conditionals {
        get {
            return this.conditionalsField;
        }
        set {
            this.conditionalsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string coveredconditionals {
        get {
            return this.coveredconditionalsField;
        }
        set {
            this.coveredconditionalsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string statements {
        get {
            return this.statementsField;
        }
        set {
            this.statementsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string coveredstatements {
        get {
            return this.coveredstatementsField;
        }
        set {
            this.coveredstatementsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string coveredmethods {
        get {
            return this.coveredmethodsField;
        }
        set {
            this.coveredmethodsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string methods {
        get {
            return this.methodsField;
        }
        set {
            this.methodsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal testduration {
        get {
            return this.testdurationField;
        }
        set {
            this.testdurationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool testdurationSpecified {
        get {
            return this.testdurationFieldSpecified;
        }
        set {
            this.testdurationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string testfailures {
        get {
            return this.testfailuresField;
        }
        set {
            this.testfailuresField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string testpasses {
        get {
            return this.testpassesField;
        }
        set {
            this.testpassesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string testruns {
        get {
            return this.testrunsField;
        }
        set {
            this.testrunsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class package {
    
    private packageMetrics metricsField;
    
    private file[] fileField;
    
    private string nameField;
    
    /// <remarks/>
    public packageMetrics metrics {
        get {
            return this.metricsField;
        }
        set {
            this.metricsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("file")]
    public file[] file {
        get {
            return this.fileField;
        }
        set {
            this.fileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class file {
    
    private fileMetrics metricsField;
    
    private @class[] classField;
    
    private line[] lineField;
    
    private string nameField;
    
    private string pathField;
    
    /// <remarks/>
    public fileMetrics metrics {
        get {
            return this.metricsField;
        }
        set {
            this.metricsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("class")]
    public @class[] @class {
        get {
            return this.classField;
        }
        set {
            this.classField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("line")]
    public line[] line {
        get {
            return this.lineField;
        }
        set {
            this.lineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string path {
        get {
            return this.pathField;
        }
        set {
            this.pathField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class @class {
    
    private classMetrics metricsField;
    
    private string nameField;
    
    /// <remarks/>
    public classMetrics metrics {
        get {
            return this.metricsField;
        }
        set {
            this.metricsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class line {
    
    private string numField;
    
    private construct typeField;
    
    private string complexityField;
    
    private string countField;
    
    private string falsecountField;
    
    private string truecountField;
    
    private string signatureField;
    
    private decimal testdurationField;
    
    private bool testdurationFieldSpecified;
    
    private bool testsuccessField;
    
    private bool testsuccessFieldSpecified;
    
    private visibility visibilityField;
    
    private bool visibilityFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string num {
        get {
            return this.numField;
        }
        set {
            this.numField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public construct type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string complexity {
        get {
            return this.complexityField;
        }
        set {
            this.complexityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string count {
        get {
            return this.countField;
        }
        set {
            this.countField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string falsecount {
        get {
            return this.falsecountField;
        }
        set {
            this.falsecountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string truecount {
        get {
            return this.truecountField;
        }
        set {
            this.truecountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string signature {
        get {
            return this.signatureField;
        }
        set {
            this.signatureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal testduration {
        get {
            return this.testdurationField;
        }
        set {
            this.testdurationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool testdurationSpecified {
        get {
            return this.testdurationFieldSpecified;
        }
        set {
            this.testdurationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool testsuccess {
        get {
            return this.testsuccessField;
        }
        set {
            this.testsuccessField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool testsuccessSpecified {
        get {
            return this.testsuccessFieldSpecified;
        }
        set {
            this.testsuccessFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public visibility visibility {
        get {
            return this.visibilityField;
        }
        set {
            this.visibilityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool visibilitySpecified {
        get {
            return this.visibilityFieldSpecified;
        }
        set {
            this.visibilityFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum construct {
    
    /// <remarks/>
    method,
    
    /// <remarks/>
    stmt,
    
    /// <remarks/>
    cond,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum visibility {
    
    /// <remarks/>
    @private,
    
    /// <remarks/>
    @protected,
    
    /// <remarks/>
    package,
    
    /// <remarks/>
    @public,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class testproject {
    
    private projectMetrics metricsField;
    
    private package[] packageField;
    
    private string nameField;
    
    private string timestampField;
    
    /// <remarks/>
    public projectMetrics metrics {
        get {
            return this.metricsField;
        }
        set {
            this.metricsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("package")]
    public package[] package {
        get {
            return this.packageField;
        }
        set {
            this.packageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
}