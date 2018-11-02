using System;
using System.Collections.Generic;

namespace GameMaker.Data.Core
{
    /// <summary>
    /// Config values
    /// </summary>
    internal class Config
    {
        #region Properties
        /// <summary>
        /// Current language
        /// </summary>
        public String Language { get; set; }
        /// <summary>
        /// Languages
        /// </summary>
        public List<String> Languages { get; set; }
        /// <summary>
        /// Data path
        /// </summary>
        public readonly String Path;
        #endregion

        #region Constructor
        /// <summary>
        /// Basic constructor
        /// </summary>
        public Config()
        {
            Languages = new List<string>() { "" };
            Language = Languages[0];
            Path = null;
        }

        public Config(string path) : this()
        {
            this.Path = path;
        }
        #endregion
    }
}
