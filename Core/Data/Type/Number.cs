using GameMaker.Data.Core;
using System;

namespace GameMaker.Data.Type
{
    /// <summary>
    /// Number type
    /// </summary>
    public class Number : AbstractInfo
    {
        #region Properties
        /// <summary>
        /// Min possible value
        /// </summary>
        public readonly Double? MinValue;
        /// <summary>
        /// Max possible value
        /// </summary>
        public readonly Double? MaxValue;
        /// <summary>
        /// Info type
        /// </summary>
        public override EInfoType InfoType => EInfoType.number;
        /// <summary>
        /// Internal value variable
        /// </summary>
        protected Double _Value;
        /// <summary>
        /// The value it retrieves. The number. Takes in car min and max value to avoid overflows
        /// </summary>
        public override object Value
        {
            get
            {
                if (MinValue.HasValue && _Value < MinValue.Value)
                    return MinValue.Value;
                else if (MaxValue.HasValue && _Value > MaxValue.Value)
                    return MaxValue.Value;
                return _Value;
            }
            set
            {
                _Value = (Double) value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Basic constructor
        /// </summary>
        public Number() : base() { }

        /// <summary>
        /// Valued constructor
        /// </summary>
        /// <param name="management">Management type</param>
        /// <param name="value">The value itself</param>
        /// <param name="minValue">Min number it can have</param>
        /// <param name="maxValue">Max number it can have</param>
        public Number(EManagement management, Double value, Double? minValue = null, Double? maxValue = null) : base(management, value)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }
        #endregion

        #region Public
        /// <summary>
        /// clone method
        /// </summary>
        /// <returns>The cloned Number</returns>
        public override object Clone()
        {
            return new Number(Management, (Double)this.InitialValue, this.MinValue, this.MaxValue) { Value = this.Value };
        }
        #endregion
    }
}
