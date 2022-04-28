using System;

namespace GTC.Utilities
{

    public class Property : ICloneable
    {
        #region -- Properties -----
        /// <summary>
        /// The name of the property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The property's value
        /// </summary>
        public object Value
        {
            get
            {
                if (this.IsPassword)
                    return (_value as Password).pwdValue;
                else
                    return this._value;
            }
            set
            {
                if (this.IsPassword)
                    this._value = new Password(value.ToString());
                else
                    this._value = value;
            }
        }
        private object _value;

        /// <summary>
        /// The <see cref="Type"/> of the property
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// A boolean indicating whether the property's value contains 
        /// a password that should not be serialized or displayed.
        /// </summary>
        public bool IsPassword { get; set; }
        #endregion

        #region -- Constructors -----
        public Property()
        {
            Name = string.Empty;
            Value = string.Empty;
            Type = typeof(object);
            IsPassword = false;
        }

        public Property(string name, object value)
        {
            this.Name = name;
            this.Value = value;
            this.Type = value.GetType();
            IsPassword = false;
        }

        public Property(string name, string value, bool isPassword)
        {
            this.Name = name;
            if(isPassword == true)
            {
                this.Value = new Password(value);
                this.Type = typeof(Password);
            }
            else
            {
                this.Value = value;
                this.Type = typeof(System.String);
            }
            IsPassword = isPassword;
        }
        #endregion

        #region -- ICloneable  methods -----
        private Property(Property copy)
        {
            this.Name = copy.Name;
            this.Type = copy.Type;
            this.IsPassword = copy.IsPassword;
            if (copy.IsPassword)
                this.Value = copy.GetPwdValue();
            else
                this.Value = copy.Value;
        }

        public object Clone()
        {
            return new Property(this);
        }
        #endregion

        public override string ToString()
        {
            if (this.IsPassword)
                return (_value as Password).pwdValue;
            else if (this.Type == typeof(System.String))
                return (string)this._value;
            else
                return this._value.ToString();
        }

        public string GetPwdValue()
        {
            if (this.IsPassword)
                return (_value as Password).GetPwd();
            else
                return _value.ToString();
        }

        /// <summary>
        /// This method tells Newtonsoft whether to serialize the
        /// value. If it is a password, it will NOT be serialized.
        /// </summary>
        /// <remarks>
        /// see https://www.newtonsoft.com/json/help/html/ConditionalProperties.htm 
        /// for more information on how this works.</remarks>
        /// <returns>true if the value should be serialized, false if not.</returns>
        public bool ShouldSerializeValue()
        {
            // Serialize the value property if it is NOT a password.
            return !IsPassword;
        }
    }

    internal class Password
    {
        internal string pwdValue
        {
            get
            {
                return "********";
            }
            set
            {
                _pwdValue = value;
            }
        }
        private string _pwdValue;

        #region -- Constructors -----
        internal Password() { }

        internal Password(string value)
        {
            _pwdValue = value;
        }
        #endregion

        internal string GetPwd()
        {
            return _pwdValue;
        }


    }
}
