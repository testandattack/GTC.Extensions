using System;
using System.Collections.Generic;
using System.Text;

namespace MsThreatModelParser
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KnowledgeBaseThreatType
    {

        private KnowledgeBaseThreatTypeGenerationFilters generationFiltersField;

        private string idField;

        private string shortTitleField;

        private string categoryField;

        private object relatedCategoryField;

        private string descriptionField;

        private KnowledgeBaseThreatTypeThreatMetaDatum[] propertiesMetaDataField;

        /// <remarks/>
        public KnowledgeBaseThreatTypeGenerationFilters GenerationFilters
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
        [System.Xml.Serialization.XmlArrayItemAttribute("ThreatMetaDatum", IsNullable = false)]
        public KnowledgeBaseThreatTypeThreatMetaDatum[] PropertiesMetaData
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
    public partial class KnowledgeBaseThreatTypeGenerationFilters
    {

        private string includeField;

        private string excludeField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KnowledgeBaseThreatTypeThreatMetaDatum
    {

        private string nameField;

        private string labelField;

        private bool hideFromUIField;

        private KnowledgeBaseThreatTypeThreatMetaDatumValues valuesField;

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
        public KnowledgeBaseThreatTypeThreatMetaDatumValues Values
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KnowledgeBaseThreatTypeThreatMetaDatumValues
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
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
}
