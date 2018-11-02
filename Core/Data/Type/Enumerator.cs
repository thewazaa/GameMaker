/*
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GameMaker.Data.Type
{
    public class Enumerator : Variable
    {
        protected String _Value;
        public override object Value
        {
            get
            {
                if (Enum.Contains(_Value))
                    return null;
                return _Value;
            }
            set
            {
                _Value = (String)value;
            }
        }

        public List<String> Enum { get; protected set; }

        public override void SetType()
        {
            this.VariableType = EVariableType.enumerator;
        }

        public override object Clone()
        {
            return new Enumerator((String)this.InitialValue, this.Enum) { Value = this.Value };
        }

        public Enumerator() : base() { }

        public Enumerator(String value, List<string> Enum) : base(value)
        {
            this.Enum = Enum;
        }
    }
}
*/