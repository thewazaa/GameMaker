/*
using System;
using System.Text.RegularExpressions;

namespace GameMaker.Data.Type
{
    public class Bool : Variable
    {
        protected bool _Value;
        public override object Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = (bool) value;
            }
        }

        public override void SetType()
        {
            this.VariableType = EVariableType.boolean;
        }

        public override object Clone()
        {
            return new Bool((bool)this.InitialValue) { Value = this.Value };
        }

        public Bool() : base() { }

        public Bool(bool value) : base(value) { }
    }
}
*/