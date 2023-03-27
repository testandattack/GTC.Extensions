using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace MsThreatModelParser
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class KnowledgeBase
    {

        private KnowledgeBaseManifest manifestField;

        private KnowledgeBaseThreatMetaData threatMetaDataField;

        private KnowledgeBaseElementType[] genericElementsField;

        private KnowledgeBaseElementType2[] standardElementsField;

        private KnowledgeBaseThreatCategory[] threatCategoriesField;

        private KnowledgeBaseThreatType[] threatTypesField;

        /// <remarks/>
        public KnowledgeBaseManifest Manifest
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
        public KnowledgeBaseThreatMetaData ThreatMetaData
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
        [System.Xml.Serialization.XmlArrayItemAttribute("ElementType", IsNullable = false)]
        public KnowledgeBaseElementType[] GenericElements
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
        [System.Xml.Serialization.XmlArrayItemAttribute("ElementType", IsNullable = false)]
        public KnowledgeBaseElementType2[] StandardElements
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
        [System.Xml.Serialization.XmlArrayItemAttribute("ThreatCategory", IsNullable = false)]
        public KnowledgeBaseThreatCategory[] ThreatCategories
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
        [System.Xml.Serialization.XmlArrayItemAttribute("ThreatType", IsNullable = false)]
        public KnowledgeBaseThreatType[] ThreatTypes
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
    }
}
