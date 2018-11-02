using GameMaker.Data.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaker.Data
{
    /// <summary>
    /// Data manager
    /// </summary>
    public class DataManager
    {
        #region Properties
        internal Config Config;
        #endregion

        #region Constructor
        protected DataManager() { }
        #endregion

        #region Static methods
        public static DataManager New(string path)
        {
            return new DataManager()
            {
                Config = new Config(path)
            };
        }

        public static bool Save(DataManager dataManager)
        {
            try
            {
                dataManager.CreatePath();

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region protected
        protected void CreatePath()
        {
            if (!Directory.Exists(Config.Path))
                Directory.CreateDirectory(Config.Path);
        }
        #endregion
    }
}
