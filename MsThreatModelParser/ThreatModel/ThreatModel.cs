using System;
using System.Collections.Generic;
using System.Text;

namespace MsThreatModelParser
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model", IsNullable = false)]
    public partial class ThreatModel
    {

        private ThreatModelDrawingSurfaceList drawingSurfaceListField;

        private ThreatModelMetaInformation metaInformationField;

        private object notesField;

        private KeyValueOfstringThreatpc_P0_PhOB[] threatInstancesField;

        private bool threatGenerationEnabledField;

        private object validationsField;

        private decimal versionField;

        private ThreatModelKnowledgeBase knowledgeBaseField;

        private ThreatModelProfile profileField;

        /// <remarks/>
        public ThreatModelDrawingSurfaceList DrawingSurfaceList
        {
            get
            {
                return this.drawingSurfaceListField;
            }
            set
            {
                this.drawingSurfaceListField = value;
            }
        }

        /// <remarks/>
        public ThreatModelMetaInformation MetaInformation
        {
            get
            {
                return this.metaInformationField;
            }
            set
            {
                this.metaInformationField = value;
            }
        }

        /// <remarks/>
        public object Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfstringThreatpc_P0_PhOB", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public KeyValueOfstringThreatpc_P0_PhOB[] ThreatInstances
        {
            get
            {
                return this.threatInstancesField;
            }
            set
            {
                this.threatInstancesField = value;
            }
        }

        /// <remarks/>
        public bool ThreatGenerationEnabled
        {
            get
            {
                return this.threatGenerationEnabledField;
            }
            set
            {
                this.threatGenerationEnabledField = value;
            }
        }

        /// <remarks/>
        public object Validations
        {
            get
            {
                return this.validationsField;
            }
            set
            {
                this.validationsField = value;
            }
        }

        /// <remarks/>
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public ThreatModelKnowledgeBase KnowledgeBase
        {
            get
            {
                return this.knowledgeBaseField;
            }
            set
            {
                this.knowledgeBaseField = value;
            }
        }

        /// <remarks/>
        public ThreatModelProfile Profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
    public partial class ThreatModelDrawingSurfaceList
    {

        private ThreatModelDrawingSurfaceListDrawingSurfaceModel drawingSurfaceModelField;

        /// <remarks/>
        public ThreatModelDrawingSurfaceListDrawingSurfaceModel DrawingSurfaceModel
        {
            get
            {
                return this.drawingSurfaceModelField;
            }
            set
            {
                this.drawingSurfaceModelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
    public partial class ThreatModelDrawingSurfaceListDrawingSurfaceModel
    {

        private string genericTypeIdField;

        private string guidField;

        private anyType[] propertiesField;

        private string typeIdField;

        private KeyValueOfguidanyType[] bordersField;

        private string headerField;

        private KeyValueOfguidanyType[] linesField;

        private byte zoomField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public string GenericTypeId
        {
            get
            {
                return this.genericTypeIdField;
            }
            set
            {
                this.genericTypeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public string Guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        [System.Xml.Serialization.XmlArrayItemAttribute("anyType", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public anyType[] Properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public string TypeId
        {
            get
            {
                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfguidanyType", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public KeyValueOfguidanyType[] Borders
        {
            get
            {
                return this.bordersField;
            }
            set
            {
                this.bordersField = value;
            }
        }

        /// <remarks/>
        public string Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfguidanyType", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public KeyValueOfguidanyType[] Lines
        {
            get
            {
                return this.linesField;
            }
            set
            {
                this.linesField = value;
            }
        }

        /// <remarks/>
        public byte Zoom
        {
            get
            {
                return this.zoomField;
            }
            set
            {
                this.zoomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
    public partial class anyType
    {

        private string displayNameField;

        private string nameField;

        private Value valueField;

        private byte selectedIndexField;

        private bool selectedIndexFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = true)]
        public Value Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public byte SelectedIndex
        {
            get
            {
                return this.selectedIndexField;
            }
            set
            {
                this.selectedIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SelectedIndexSpecified
        {
            get
            {
                return this.selectedIndexFieldSpecified;
            }
            set
            {
                this.selectedIndexFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = true)]
    public partial class Value
    {

        private string[] stringField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("string", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] @string
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
    public partial class KeyValueOfguidanyType
    {

        private string keyField;

        private KeyValueOfguidanyTypeValue valueField;

        /// <remarks/>
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        public KeyValueOfguidanyTypeValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    public partial class KeyValueOfguidanyTypeValue
    {

        private string genericTypeIdField;

        private string guidField;

        private anyType[] propertiesField;

        private string typeIdField;

        private ushort handleXField;

        private bool handleXFieldSpecified;

        private byte handleYField;

        private bool handleYFieldSpecified;

        private string portSourceField;

        private string portTargetField;

        private string sourceGuidField;

        private ushort sourceXField;

        private bool sourceXFieldSpecified;

        private byte sourceYField;

        private bool sourceYFieldSpecified;

        private string targetGuidField;

        private ushort targetXField;

        private bool targetXFieldSpecified;

        private byte targetYField;

        private bool targetYFieldSpecified;

        private byte heightField;

        private bool heightFieldSpecified;

        private ushort leftField;

        private bool leftFieldSpecified;

        private object strokeDashArrayField;

        private byte strokeThicknessField;

        private bool strokeThicknessFieldSpecified;

        private ushort topField;

        private bool topFieldSpecified;

        private byte widthField;

        private bool widthFieldSpecified;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public string GenericTypeId
        {
            get
            {
                return this.genericTypeIdField;
            }
            set
            {
                this.genericTypeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public string Guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        [System.Xml.Serialization.XmlArrayItemAttribute("anyType", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public anyType[] Properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public string TypeId
        {
            get
            {
                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public ushort HandleX
        {
            get
            {
                return this.handleXField;
            }
            set
            {
                this.handleXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HandleXSpecified
        {
            get
            {
                return this.handleXFieldSpecified;
            }
            set
            {
                this.handleXFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public byte HandleY
        {
            get
            {
                return this.handleYField;
            }
            set
            {
                this.handleYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HandleYSpecified
        {
            get
            {
                return this.handleYFieldSpecified;
            }
            set
            {
                this.handleYFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public string PortSource
        {
            get
            {
                return this.portSourceField;
            }
            set
            {
                this.portSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public string PortTarget
        {
            get
            {
                return this.portTargetField;
            }
            set
            {
                this.portTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public string SourceGuid
        {
            get
            {
                return this.sourceGuidField;
            }
            set
            {
                this.sourceGuidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public ushort SourceX
        {
            get
            {
                return this.sourceXField;
            }
            set
            {
                this.sourceXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SourceXSpecified
        {
            get
            {
                return this.sourceXFieldSpecified;
            }
            set
            {
                this.sourceXFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public byte SourceY
        {
            get
            {
                return this.sourceYField;
            }
            set
            {
                this.sourceYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SourceYSpecified
        {
            get
            {
                return this.sourceYFieldSpecified;
            }
            set
            {
                this.sourceYFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public string TargetGuid
        {
            get
            {
                return this.targetGuidField;
            }
            set
            {
                this.targetGuidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public ushort TargetX
        {
            get
            {
                return this.targetXField;
            }
            set
            {
                this.targetXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TargetXSpecified
        {
            get
            {
                return this.targetXFieldSpecified;
            }
            set
            {
                this.targetXFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public byte TargetY
        {
            get
            {
                return this.targetYField;
            }
            set
            {
                this.targetYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TargetYSpecified
        {
            get
            {
                return this.targetYFieldSpecified;
            }
            set
            {
                this.targetYFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public byte Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public ushort Left
        {
            get
            {
                return this.leftField;
            }
            set
            {
                this.leftField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeftSpecified
        {
            get
            {
                return this.leftFieldSpecified;
            }
            set
            {
                this.leftFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts", IsNullable = true)]
        public object StrokeDashArray
        {
            get
            {
                return this.strokeDashArrayField;
            }
            set
            {
                this.strokeDashArrayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public byte StrokeThickness
        {
            get
            {
                return this.strokeThicknessField;
            }
            set
            {
                this.strokeThicknessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StrokeThicknessSpecified
        {
            get
            {
                return this.strokeThicknessFieldSpecified;
            }
            set
            {
                this.strokeThicknessFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public ushort Top
        {
            get
            {
                return this.topField;
            }
            set
            {
                this.topField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TopSpecified
        {
            get
            {
                return this.topFieldSpecified;
            }
            set
            {
                this.topFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
        public byte Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WidthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
    public partial class KeyValueOfstringThreatpc_P0_PhOB
    {

        private string keyField;

        private KeyValueOfstringThreatpc_P0_PhOBValue valueField;

        /// <remarks/>
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        public KeyValueOfstringThreatpc_P0_PhOBValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    public partial class KeyValueOfstringThreatpc_P0_PhOBValue
    {

        private object changedByField;

        private string drawingSurfaceGuidField;

        private string flowGuidField;

        private byte idField;

        private string interactionKeyField;

        private object interactionStringField;

        private System.DateTime modifiedAtField;

        private string priorityField;

        private KeyValueOfstringstring[] propertiesField;

        private string sourceGuidField;

        private string stateField;

        private object stateInformationField;

        private string targetGuidField;

        private object titleField;

        private string typeIdField;

        private bool upgradedField;

        private object userThreatCategoryField;

        private object userThreatDescriptionField;

        private object userThreatShortDescriptionField;

        private bool wideField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = true)]
        public object ChangedBy
        {
            get
            {
                return this.changedByField;
            }
            set
            {
                this.changedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public string DrawingSurfaceGuid
        {
            get
            {
                return this.drawingSurfaceGuidField;
            }
            set
            {
                this.drawingSurfaceGuidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public string FlowGuid
        {
            get
            {
                return this.flowGuidField;
            }
            set
            {
                this.flowGuidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public byte Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public string InteractionKey
        {
            get
            {
                return this.interactionKeyField;
            }
            set
            {
                this.interactionKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = true)]
        public object InteractionString
        {
            get
            {
                return this.interactionStringField;
            }
            set
            {
                this.interactionStringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public System.DateTime ModifiedAt
        {
            get
            {
                return this.modifiedAtField;
            }
            set
            {
                this.modifiedAtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public string Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfstringstring", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public KeyValueOfstringstring[] Properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public string SourceGuid
        {
            get
            {
                return this.sourceGuidField;
            }
            set
            {
                this.sourceGuidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = true)]
        public object StateInformation
        {
            get
            {
                return this.stateInformationField;
            }
            set
            {
                this.stateInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public string TargetGuid
        {
            get
            {
                return this.targetGuidField;
            }
            set
            {
                this.targetGuidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = true)]
        public object Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public string TypeId
        {
            get
            {
                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public bool Upgraded
        {
            get
            {
                return this.upgradedField;
            }
            set
            {
                this.upgradedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = true)]
        public object UserThreatCategory
        {
            get
            {
                return this.userThreatCategoryField;
            }
            set
            {
                this.userThreatCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = true)]
        public object UserThreatDescription
        {
            get
            {
                return this.userThreatDescriptionField;
            }
            set
            {
                this.userThreatDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = true)]
        public object UserThreatShortDescription
        {
            get
            {
                return this.userThreatShortDescriptionField;
            }
            set
            {
                this.userThreatShortDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public bool Wide
        {
            get
            {
                return this.wideField;
            }
            set
            {
                this.wideField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
    public partial class KeyValueOfstringstring
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model", IsNullable = false)]
    public partial class ThreatMetaDatum
    {

        private string nameField;

        private string labelField;

        private bool hideFromUIField;

        private ThreatMetaDatumValues valuesField;

        private string idField;

        private byte attributeTypeField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        /// <remarks/>
        public bool HideFromUI
        {
            get
            {
                return this.hideFromUIField;
            }
            set
            {
                this.hideFromUIField = value;
            }
        }

        /// <remarks/>
        public ThreatMetaDatumValues Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public byte AttributeType
        {
            get
            {
                return this.attributeTypeField;
            }
            set
            {
                this.attributeTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
    public partial class ThreatMetaDatumValues
    {

        private string stringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string @string
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
    public partial class ThreatModelMetaInformation
    {

        private object assumptionsField;

        private object contributorsField;

        private object externalDependenciesField;

        private object highLevelSystemDescriptionField;

        private object ownerField;

        private object reviewerField;

        private object threatModelNameField;

        /// <remarks/>
        public object Assumptions
        {
            get
            {
                return this.assumptionsField;
            }
            set
            {
                this.assumptionsField = value;
            }
        }

        /// <remarks/>
        public object Contributors
        {
            get
            {
                return this.contributorsField;
            }
            set
            {
                this.contributorsField = value;
            }
        }

        /// <remarks/>
        public object ExternalDependencies
        {
            get
            {
                return this.externalDependenciesField;
            }
            set
            {
                this.externalDependenciesField = value;
            }
        }

        /// <remarks/>
        public object HighLevelSystemDescription
        {
            get
            {
                return this.highLevelSystemDescriptionField;
            }
            set
            {
                this.highLevelSystemDescriptionField = value;
            }
        }

        /// <remarks/>
        public object Owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public object Reviewer
        {
            get
            {
                return this.reviewerField;
            }
            set
            {
                this.reviewerField = value;
            }
        }

        /// <remarks/>
        public object ThreatModelName
        {
            get
            {
                return this.threatModelNameField;
            }
            set
            {
                this.threatModelNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
    public partial class ThreatModelKnowledgeBase
    {

        private GenericElementsElementType[] genericElementsField;

        private Manifest manifestField;

        private StandardElementsElementType[] standardElementsField;

        private ThreatCategoriesThreatCategory[] threatCategoriesField;

        private ThreatMetaData threatMetaDataField;

        private ThreatTypesThreatType[] threatTypesField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        [System.Xml.Serialization.XmlArrayItemAttribute("ElementType", IsNullable = false)]
        public GenericElementsElementType[] GenericElements
        {
            get
            {
                return this.genericElementsField;
            }
            set
            {
                this.genericElementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public Manifest Manifest
        {
            get
            {
                return this.manifestField;
            }
            set
            {
                this.manifestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        [System.Xml.Serialization.XmlArrayItemAttribute("ElementType", IsNullable = false)]
        public StandardElementsElementType[] StandardElements
        {
            get
            {
                return this.standardElementsField;
            }
            set
            {
                this.standardElementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        [System.Xml.Serialization.XmlArrayItemAttribute("ThreatCategory", IsNullable = false)]
        public ThreatCategoriesThreatCategory[] ThreatCategories
        {
            get
            {
                return this.threatCategoriesField;
            }
            set
            {
                this.threatCategoriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        public ThreatMetaData ThreatMetaData
        {
            get
            {
                return this.threatMetaDataField;
            }
            set
            {
                this.threatMetaDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
        [System.Xml.Serialization.XmlArrayItemAttribute("ThreatType", IsNullable = false)]
        public ThreatTypesThreatType[] ThreatTypes
        {
            get
            {
                return this.threatTypesField;
            }
            set
            {
                this.threatTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class GenericElementsElementType
    {

        private bool isExtensionField;

        private GenericElementsElementTypeAttributes attributesField;

        private object availableToBaseModelsField;

        private object behaviorField;

        private string descriptionField;

        private bool hiddenField;

        private string idField;

        private string imageLocationField;

        private string imageSourceField;

        private object imageStreamField;

        private string nameField;

        private string parentIdField;

        private string representationField;

        private object shapeField;

        private GenericElementsElementTypeStencilConstraints stencilConstraintsField;

        /// <remarks/>
        public bool IsExtension
        {
            get
            {
                return this.isExtensionField;
            }
            set
            {
                this.isExtensionField = value;
            }
        }

        /// <remarks/>
        public GenericElementsElementTypeAttributes Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        public object AvailableToBaseModels
        {
            get
            {
                return this.availableToBaseModelsField;
            }
            set
            {
                this.availableToBaseModelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Behavior
        {
            get
            {
                return this.behaviorField;
            }
            set
            {
                this.behaviorField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public bool Hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string ImageLocation
        {
            get
            {
                return this.imageLocationField;
            }
            set
            {
                this.imageLocationField = value;
            }
        }

        /// <remarks/>
        public string ImageSource
        {
            get
            {
                return this.imageSourceField;
            }
            set
            {
                this.imageSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object ImageStream
        {
            get
            {
                return this.imageStreamField;
            }
            set
            {
                this.imageStreamField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string ParentId
        {
            get
            {
                return this.parentIdField;
            }
            set
            {
                this.parentIdField = value;
            }
        }

        /// <remarks/>
        public string Representation
        {
            get
            {
                return this.representationField;
            }
            set
            {
                this.representationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        /// <remarks/>
        public GenericElementsElementTypeStencilConstraints StencilConstraints
        {
            get
            {
                return this.stencilConstraintsField;
            }
            set
            {
                this.stencilConstraintsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class GenericElementsElementTypeAttributes
    {

        private GenericElementsElementTypeAttributesAttribute attributeField;

        /// <remarks/>
        public GenericElementsElementTypeAttributesAttribute Attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class GenericElementsElementTypeAttributesAttribute
    {

        private bool isExtensionField;

        private string[] attributeValuesField;

        private string displayNameField;

        private string inheritanceField;

        private string modeField;

        private string nameField;

        private string typeField;

        /// <remarks/>
        public bool IsExtension
        {
            get
            {
                return this.isExtensionField;
            }
            set
            {
                this.isExtensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Value", Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Interfaces", IsNullable = false)]
        public string[] AttributeValues
        {
            get
            {
                return this.attributeValuesField;
            }
            set
            {
                this.attributeValuesField = value;
            }
        }

        /// <remarks/>
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        public string Inheritance
        {
            get
            {
                return this.inheritanceField;
            }
            set
            {
                this.inheritanceField = value;
            }
        }

        /// <remarks/>
        public string Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class GenericElementsElementTypeStencilConstraints
    {

        private GenericElementsElementTypeStencilConstraintsStencilConstraint stencilConstraintField;

        /// <remarks/>
        public GenericElementsElementTypeStencilConstraintsStencilConstraint StencilConstraint
        {
            get
            {
                return this.stencilConstraintField;
            }
            set
            {
                this.stencilConstraintField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class GenericElementsElementTypeStencilConstraintsStencilConstraint
    {

        private bool isExtensionField;

        private string selectedStencilConnectionField;

        private string selectedStencilTypeField;

        /// <remarks/>
        public bool IsExtension
        {
            get
            {
                return this.isExtensionField;
            }
            set
            {
                this.isExtensionField = value;
            }
        }

        /// <remarks/>
        public string SelectedStencilConnection
        {
            get
            {
                return this.selectedStencilConnectionField;
            }
            set
            {
                this.selectedStencilConnectionField = value;
            }
        }

        /// <remarks/>
        public string SelectedStencilType
        {
            get
            {
                return this.selectedStencilTypeField;
            }
            set
            {
                this.selectedStencilTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = false)]
    public partial class Manifest
    {

        private string authorField;

        private string idField;

        private string nameField;

        private string versionField;

        /// <remarks/>
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class StandardElementsElementType
    {

        private bool isExtensionField;

        private StandardElementsElementTypeAttribute[] attributesField;

        private object availableToBaseModelsField;

        private object behaviorField;

        private string descriptionField;

        private bool hiddenField;

        private string idField;

        private string imageLocationField;

        private string imageSourceField;

        private object imageStreamField;

        private string nameField;

        private string parentIdField;

        private string representationField;

        private object shapeField;

        private StandardElementsElementTypeStencilConstraints stencilConstraintsField;

        /// <remarks/>
        public bool IsExtension
        {
            get
            {
                return this.isExtensionField;
            }
            set
            {
                this.isExtensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public StandardElementsElementTypeAttribute[] Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        public object AvailableToBaseModels
        {
            get
            {
                return this.availableToBaseModelsField;
            }
            set
            {
                this.availableToBaseModelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Behavior
        {
            get
            {
                return this.behaviorField;
            }
            set
            {
                this.behaviorField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public bool Hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string ImageLocation
        {
            get
            {
                return this.imageLocationField;
            }
            set
            {
                this.imageLocationField = value;
            }
        }

        /// <remarks/>
        public string ImageSource
        {
            get
            {
                return this.imageSourceField;
            }
            set
            {
                this.imageSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object ImageStream
        {
            get
            {
                return this.imageStreamField;
            }
            set
            {
                this.imageStreamField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string ParentId
        {
            get
            {
                return this.parentIdField;
            }
            set
            {
                this.parentIdField = value;
            }
        }

        /// <remarks/>
        public string Representation
        {
            get
            {
                return this.representationField;
            }
            set
            {
                this.representationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        /// <remarks/>
        public StandardElementsElementTypeStencilConstraints StencilConstraints
        {
            get
            {
                return this.stencilConstraintsField;
            }
            set
            {
                this.stencilConstraintsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class StandardElementsElementTypeAttribute
    {

        private bool isExtensionField;

        private string[] attributeValuesField;

        private string displayNameField;

        private string inheritanceField;

        private string modeField;

        private string nameField;

        private string typeField;

        /// <remarks/>
        public bool IsExtension
        {
            get
            {
                return this.isExtensionField;
            }
            set
            {
                this.isExtensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Value", Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Interfaces", IsNullable = false)]
        public string[] AttributeValues
        {
            get
            {
                return this.attributeValuesField;
            }
            set
            {
                this.attributeValuesField = value;
            }
        }

        /// <remarks/>
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        public string Inheritance
        {
            get
            {
                return this.inheritanceField;
            }
            set
            {
                this.inheritanceField = value;
            }
        }

        /// <remarks/>
        public string Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class StandardElementsElementTypeStencilConstraints
    {

        private StandardElementsElementTypeStencilConstraintsStencilConstraint stencilConstraintField;

        /// <remarks/>
        public StandardElementsElementTypeStencilConstraintsStencilConstraint StencilConstraint
        {
            get
            {
                return this.stencilConstraintField;
            }
            set
            {
                this.stencilConstraintField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class StandardElementsElementTypeStencilConstraintsStencilConstraint
    {

        private bool isExtensionField;

        private string selectedStencilConnectionField;

        private string selectedStencilTypeField;

        /// <remarks/>
        public bool IsExtension
        {
            get
            {
                return this.isExtensionField;
            }
            set
            {
                this.isExtensionField = value;
            }
        }

        /// <remarks/>
        public string SelectedStencilConnection
        {
            get
            {
                return this.selectedStencilConnectionField;
            }
            set
            {
                this.selectedStencilConnectionField = value;
            }
        }

        /// <remarks/>
        public string SelectedStencilType
        {
            get
            {
                return this.selectedStencilTypeField;
            }
            set
            {
                this.selectedStencilTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class ThreatCategoriesThreatCategory
    {

        private bool isExtensionField;

        private string idField;

        private object longDescriptionField;

        private string nameField;

        private string shortDescriptionField;

        /// <remarks/>
        public bool IsExtension
        {
            get
            {
                return this.isExtensionField;
            }
            set
            {
                this.isExtensionField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public object LongDescription
        {
            get
            {
                return this.longDescriptionField;
            }
            set
            {
                this.longDescriptionField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string ShortDescription
        {
            get
            {
                return this.shortDescriptionField;
            }
            set
            {
                this.shortDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = false)]
    public partial class ThreatMetaData
    {

        private bool isPriorityUsedField;

        private bool isStatusUsedField;

        private PropertiesMetaDataThreatMetaDatum[] propertiesMetaDataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
        public bool IsPriorityUsed
        {
            get
            {
                return this.isPriorityUsedField;
            }
            set
            {
                this.isPriorityUsedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
        public bool IsStatusUsed
        {
            get
            {
                return this.isStatusUsedField;
            }
            set
            {
                this.isStatusUsedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
        [System.Xml.Serialization.XmlArrayItemAttribute("ThreatMetaDatum", IsNullable = false)]
        public PropertiesMetaDataThreatMetaDatum[] PropertiesMetaData
        {
            get
            {
                return this.propertiesMetaDataField;
            }
            set
            {
                this.propertiesMetaDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
    public partial class PropertiesMetaDataThreatMetaDatum
    {

        private string nameField;

        private string labelField;

        private bool hideFromUIField;

        private string[] valuesField;

        private string idField;

        private byte attributeTypeField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        /// <remarks/>
        public bool HideFromUI
        {
            get
            {
                return this.hideFromUIField;
            }
            set
            {
                this.hideFromUIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public string[] Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public byte AttributeType
        {
            get
            {
                return this.attributeTypeField;
            }
            set
            {
                this.attributeTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class ThreatTypesThreatType
    {

        private bool isExtensionField;

        private string categoryField;

        private string descriptionField;

        private ThreatTypesThreatTypeGenerationFilters generationFiltersField;

        private string idField;

        private ThreatMetaDatum[] propertiesMetaDataField;

        private object relatedCategoryField;

        private string shortTitleField;

        /// <remarks/>
        public bool IsExtension
        {
            get
            {
                return this.isExtensionField;
            }
            set
            {
                this.isExtensionField = value;
            }
        }

        /// <remarks/>
        public string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public ThreatTypesThreatTypeGenerationFilters GenerationFilters
        {
            get
            {
                return this.generationFiltersField;
            }
            set
            {
                this.generationFiltersField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ThreatMetaDatum", Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model", IsNullable = false)]
        public ThreatMetaDatum[] PropertiesMetaData
        {
            get
            {
                return this.propertiesMetaDataField;
            }
            set
            {
                this.propertiesMetaDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object RelatedCategory
        {
            get
            {
                return this.relatedCategoryField;
            }
            set
            {
                this.relatedCategoryField = value;
            }
        }

        /// <remarks/>
        public string ShortTitle
        {
            get
            {
                return this.shortTitleField;
            }
            set
            {
                this.shortTitleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    public partial class ThreatTypesThreatTypeGenerationFilters
    {

        private string excludeField;

        private string includeField;

        /// <remarks/>
        public string Exclude
        {
            get
            {
                return this.excludeField;
            }
            set
            {
                this.excludeField = value;
            }
        }

        /// <remarks/>
        public string Include
        {
            get
            {
                return this.includeField;
            }
            set
            {
                this.includeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
    public partial class ThreatModelProfile
    {

        private object promptedKbField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public object PromptedKb
        {
            get
            {
                return this.promptedKbField;
            }
            set
            {
                this.promptedKbField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model", IsNullable = false)]
    public partial class PropertiesMetaData
    {

        private PropertiesMetaDataThreatMetaDatum[] threatMetaDatumField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ThreatMetaDatum")]
        public PropertiesMetaDataThreatMetaDatum[] ThreatMetaDatum
        {
            get
            {
                return this.threatMetaDatumField;
            }
            set
            {
                this.threatMetaDatumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.Model.Abstracts", IsNullable = false)]
    public partial class Properties
    {

        private anyType[] anyTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("anyType", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public anyType[] anyType
        {
            get
            {
                return this.anyTypeField;
            }
            set
            {
                this.anyTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    [System.Xml.Serialization.XmlRootAttribute("Properties", Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = false)]
    public partial class Properties1
    {

        private KeyValueOfstringstring[] keyValueOfstringstringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KeyValueOfstringstring", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public KeyValueOfstringstring[] KeyValueOfstringstring
        {
            get
            {
                return this.keyValueOfstringstringField;
            }
            set
            {
                this.keyValueOfstringstringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = false)]
    public partial class GenericElements
    {

        private GenericElementsElementType[] elementTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElementType")]
        public GenericElementsElementType[] ElementType
        {
            get
            {
                return this.elementTypeField;
            }
            set
            {
                this.elementTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = false)]
    public partial class StandardElements
    {

        private StandardElementsElementType[] elementTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElementType")]
        public StandardElementsElementType[] ElementType
        {
            get
            {
                return this.elementTypeField;
            }
            set
            {
                this.elementTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = false)]
    public partial class ThreatCategories
    {

        private ThreatCategoriesThreatCategory[] threatCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ThreatCategory")]
        public ThreatCategoriesThreatCategory[] ThreatCategory
        {
            get
            {
                return this.threatCategoryField;
            }
            set
            {
                this.threatCategoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ThreatModeling.KnowledgeBase", IsNullable = false)]
    public partial class ThreatTypes
    {

        private ThreatTypesThreatType[] threatTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ThreatType")]
        public ThreatTypesThreatType[] ThreatType
        {
            get
            {
                return this.threatTypeField;
            }
            set
            {
                this.threatTypeField = value;
            }
        }
    }


}
