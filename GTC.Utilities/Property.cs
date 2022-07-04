using System;

namespace GTC.Utilities
{
    /// <summary>
    /// Provides a class for holding a C# property that can be obfuscated as needed, 
    /// to prevent storing sensitive data, such as passwords.
    /// </summary>
    public class Property : ICloneable
    {
        #region -- Properties -----
        /// <summary>
        /// The name of the property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The value stored in the property.
        /// </summary>
        /// <remarks>
        /// This item is stored in its native form, but if the <see cref="IsObfuscated"/> value
        /// is set to "True", then retrieving this property will only return a string
        /// of asterisks: "********". To retrieve the actual value, you must call the
        /// <see cref="GetPwdValue"/> method.
        /// </remarks>
        public object Value
        {
            get
            {
                if (this.IsObfuscated)
                {
                    return _password.pwdValue;
                }
                else
                {
                    return this._value;
                }
            }
            set
            {
                if (this.IsObfuscated)
                    this._password = new Password(value.ToString());
                else
                    this._value = value;
            }
        }
        private object _value;
        private Password _password;
        /// <summary>
        /// The Type of the stored property value.
        /// </summary>
        public Type Type { get; set; }
        
        /// <summary>
        /// A boolean indicating whether the value should be treated as sensitive, or
        /// can be treated as a normal property value.
        /// </summary>
        /// <remarks>
        /// If this is "True", then any call directly to the <see cref="Value"/> will
        /// result in a string of asterisks being returned. Further, there is
        /// a method called <see cref="ShouldSerializeValue"/> that is a
        /// NewtonSoft JSON event hook that tells the serilizer whether the
        /// value should be serialized for transmission or saving.
        /// </remarks>
        public bool IsObfuscated { get; set; }
        #endregion

        #region -- Constructors -----

        /// <summary>
        /// Creates a new instance of this class
        /// </summary>
        public Property()
        {
            Name = string.Empty;
            Value = string.Empty;
            _password = new Password();
            Type = typeof(object);
            IsObfuscated = false;
        }

        /// <summary>
        /// Creates a new instance of this class
        /// </summary>
        /// <param name="name">the value to place into the <see cref="Name"/> property</param>
        /// <param name="value">the value to place into the <see cref="Value"/> property</param>
        public Property(string name, string value)
        {
            this.Name = name;
            this.Value = value;
            _password = new Password();
            this.Type = typeof(System.String);
            IsObfuscated = false;
        }

        /// <summary>
        /// Creates a new instance of this class
        /// </summary>
        /// <param name="name">the value to place into the <see cref="Name"/> property</param>
        /// <param name="value">the value to place into the <see cref="Value"/> property</param>
        public Property(string name, object value)
        {
            this.Name = name;
            this.Value = value.ToString();
            this.Type = value.GetType();
            _password = new Password();
            IsObfuscated = false;
        }

        /// <summary>
        /// Creates a new instance of this class
        /// </summary>
        /// <param name="name">the value to place into the <see cref="Name"/> property</param>
        /// <param name="value">the value to place into the <see cref="Value"/> property</param>
        /// <param name="type">the value to place into the <see cref="Type"/> property</param>
        public Property(string name, string value, Type type)
        {
            this.Name = name;
            this.Value = value;
            this.Type = type;
            _password = new Password();
            IsObfuscated = false;
        }

        /// <summary>
        /// Creates a new instance of this class
        /// </summary>
        /// <param name="name">the value to place into the <see cref="Name"/> property</param>
        /// <param name="value">the value to place into the <see cref="Value"/> property</param>
        /// <param name="isObfuscated">the value to place into the <see cref="IsObfuscated"/> property</param>
        public Property(string name, string value, bool isObfuscated)
        {
            this.IsObfuscated = isObfuscated;
            this.Name = name;
            if (isObfuscated)
            {
                this.Value = "********";
                this._password = new Password(value);
                this.Type = typeof(Password);
            }
            else
            {
                this.Value = value;
                this.Type = typeof(String);
            }
        }

        /// <summary>
        /// Creates a new instance of this class
        /// </summary>
        /// <param name="name">the value to place into the <see cref="Name"/> property</param>
        /// <param name="value">the value to place into the <see cref="Value"/> property</param>
        /// <param name="type">the value to place into the <see cref="Type"/> property</param>
        /// <param name="isObfuscated">the value to place into the <see cref="IsObfuscated"/> property</param>
        public Property(string name, string value, Type type, bool isObfuscated)
        {
            this.IsObfuscated = isObfuscated;
            this.Name = name;
            if(isObfuscated)
            {
                this.Value = "********";
                this._password = new Password(value);
            }
            else
            {
                this.Value = value;
                this._password = new Password();
            }
            this.Type = type;
        }
        #endregion

        #region -- ICloneable  methods -----
        private Property(Property copy)
        {
            this.Name = copy.Name;
            this.Value = copy.Value;
            this._password = copy._password;
            this.Type = copy.Type;
            this.IsObfuscated = copy.IsObfuscated;
        }

        /// <summary>
        /// Creates a new instance of the class, containing all of the same values.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Property(this);
        }
        #endregion

        /// <summary>
        /// This method retrieves the actual value of an obfuscated string stored
        /// in the <see cref="Value"/> property. If the property is not obfuscated,
        /// this method returns an empty string.
        /// </summary>
        public string GetPwdValue()
        {
            if (this.IsObfuscated)
                return _password.GetPwd();
            else
                return string.Empty;
        }

        /// <summary>
        /// Implements the Newtonsoft JSON conditional serializer setting to 
        /// ensure that any value that shpould be obfuscated will not be
        /// serialized by NewtonSoft. See <see href="https://www.newtonsoft.com/json/help/html/ConditionalProperties.htm">
        /// this article</see> for more information.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeValue()
        {
            // Serialize the value property if it is NOT a password.
            return !this.IsObfuscated;
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

        public override string ToString()
        {
            return pwdValue;
        }
    }
}
