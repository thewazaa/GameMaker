using Newtonsoft.Json;
using System;

namespace GameMaker.Data.Core
{
    /// <summary>
    /// Info container. It can be a type, a condition or an operation.
    /// </summary>
    public abstract class AbstractInfo : ICloneable
    {
        #region Enumerator
        /// <summary>
        /// Info type enumerator
        /// </summary>
        public enum EInfoType
        {
            number = 1,
            text = 2,
            enumerator = 3,
            boolean = 4,
            image = 5
        };
        /// <summary>
        /// Info management enumerator
        /// </summary>
        public enum EManagement
        {
            data = 1,
            save = 2
        }
        #endregion

        #region Properties
        /// <summary>
        /// Info type. It defines the kind of info we manage
        /// </summary>
        public abstract EInfoType InfoType { get; }
        /// <summary>
        /// Info management. To distinguish between static info and savefile ones
        /// </summary>
        public EManagement Management { get; set; }
        /// <summary>
        /// Initial value. Helps to avoid to lose the initial value
        /// </summary>
        public readonly object InitialValue;
        /// <summary>
        /// Value. It needs to be managed in each kind of info
        /// </summary>
        public abstract object Value { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Basic constructor
        /// </summary>
        public AbstractInfo() { }
        /// <summary>
        /// Basic constructor. It sets value and initial value
        /// </summary>
        /// <param name="value">The value itself</param>
        public AbstractInfo(EManagement management, object value) : this()
        {
            Management = management;
            InitialValue = value;
            Value = InitialValue;
        }
        #endregion

        #region Public
        /// <summary>
        /// Reset value to it initial value. In some cases it need to be overrided
        /// </summary>
        public virtual void Reset()
        {
            Value = InitialValue;
        }

        /// <summary>
        /// Retrieves a JSON visualization of the object
        /// </summary>
        /// <returns></returns>
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
        #endregion

        #region Abstract
        /// <summary>
        /// Clone the object
        /// </summary>
        /// <returns>The cloned Info</returns>
        public abstract object Clone();
        #endregion
    }
}
