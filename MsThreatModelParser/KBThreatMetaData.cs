using System;
using System.Collections.Generic;
using System.Text;

namespace MsThreatModelParser
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KnowledgeBaseThreatMetaData
    {

        private bool isPriorityUsedField;

        private bool isStatusUsedField;

        private KnowledgeBaseThreatMetaDataThreatMetaDatum[] propertiesMetaDataField;

        /// <remarks/>
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
        [System.Xml.Serialization.XmlArrayItemAttribute("ThreatMetaDatum", IsNullable = false)]
        public KnowledgeBaseThreatMetaDataThreatMetaDatum[] PropertiesMetaData
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KnowledgeBaseThreatMetaDataThreatMetaDatum
    {

        private string nameField;

        private string labelField;

        private bool hideFromUIField;

        private string[] valuesField;

        private string descriptionField;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("Value", IsNullable = false)]
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
}
