/*
using GameMaker.Data.Core;
using System;
using System.Text.RegularExpressions;

namespace GameMaker.Data.Type
{
    /// <summary>
    /// Text type
    /// </summary>
    public class Text : AbstractInfo
    {
        protected String _Value;
        public override object Value
        {
            get
            {
                string tmp = _Value;
                Match matches = Regex.Match(_Value, "(?<={).*?(?=})");
                if (matches.Success)
                {
                    string objectName = DataContainer.GetObject(this).ObjectName;
                    do
                    {
                        string key = matches.Value;
                        if (key.StartsWith("."))
                            key = objectName + key;
                        if (DataContainer.AllVariables.ContainsKey(key))
                            tmp = tmp.Replace("{" + matches.Value + "}", DataContainer.AllVariables[key].Value.ToString());
                    } while ((matches = matches.NextMatch()).Success);
                }
                return tmp;
            }
            set
            {
                _Value = (String) value;
            }
        }

        public override void SetType()
        {
            this.VariableType = EVariableType.text;
        }

        public override object Clone()
        {
            return new Text((String)this.InitialValue) { Value = this.Value };
        }

        public Text() : base() { }

        public Text(String value) : base(value) { }
    }
}
*/