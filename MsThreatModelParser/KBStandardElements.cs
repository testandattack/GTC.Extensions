using System;
using System.Collections.Generic;
using System.Text;

namespace MsThreatModelParser
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KnowledgeBaseElementType2
    {

        private string nameField;

        private string idField;

        private string descriptionField;

        private string parentElementField;

        private string imageField;

        private bool hiddenField;

        private string behaviorField;

        private string shapeField;

        private string representationField;

        private byte strokeThicknessField;

        private string imageLocationField;

        private KnowledgeBaseElementTypeAttribute2[] attributesField;

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
        public string ID
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
        public string ParentElement
        {
            get
            {
                return this.parentElementField;
            }
            set
            {
                this.parentElementField = value;
            }
        }

        /// <remarks/>
        public string Image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
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
        public string Behavior
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
        public string Shape
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public KnowledgeBaseElementTypeAttribute2[] Attributes
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KnowledgeBaseElementTypeAttribute2
    {

        private string idField;

        private bool isInheritedField;

        private bool isOverridedField;

        private string nameField;

        private string displayNameField;

        private string modeField;

        private string typeField;

        private string inheritanceField;

        private string[] attributeValuesField;

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
        public bool IsInherited
        {
            get
            {
                return this.isInheritedField;
            }
            set
            {
                this.isInheritedField = value;
            }
        }

        /// <remarks/>
        public bool IsOverrided
        {
            get
            {
                return this.isOverridedField;
            }
            set
            {
                this.isOverridedField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Value", IsNullable = false)]
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
    }
}
