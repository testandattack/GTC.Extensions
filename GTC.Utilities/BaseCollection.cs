using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GTC.Utilities
{
    /// <summary>
    /// Provides an abstract class that extends the <c>Collection{T}</c> built in class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseCollection<T> : Collection<T>
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        protected BaseCollection() { }

        /// <summary>
        /// Adds a collection of items to this collection
        /// </summary>
        /// <param name="items">the collection of items to add to this item.</param>
        public void AddRange(IEnumerable<T> items)
        {
            if(items == null)
            {
                throw new ArgumentNullException("items");
            }
            foreach(T local in items)
            {
                base.Add(local);
            }
        }
    }
}
