using System;
using System.Collections.Generic;
using System.Linq;

namespace GameMaker.Data.Core
{
    /// <summary>
    /// Container of infos. It can be understood as an object
    /// </summary>
    internal class DataContainer
    {
        #region Static
        /// <summary>
        /// All the info
        /// </summary>
        internal static SortedDictionary<string, AbstractInfo> AllVariables = new SortedDictionary<string, AbstractInfo>() { };
        #endregion

        #region Properties
        /// <summary>
        /// Object name
        /// </summary>
        public readonly string ObjectName;
        /// <summary>
        /// Info related to this object level, only
        /// </summary>
        protected SortedDictionary<string, AbstractInfo> Info
        {
            get
            {
                string objectName = ObjectName;
                if (objectName.Length > 0)
                    objectName += ".";
                return new SortedDictionary<string, AbstractInfo>(AllVariables.Where(k => k.Key.StartsWith(objectName)).ToDictionary(x => x.Key, x => x.Value));
            }
        }
        /// <summary>
        /// Info related to this object, in operator mode
        /// </summary>
        /// <param name="name">Info I want to get the value of</param>
        /// <returns>The info itself</returns>
        public AbstractInfo this[string name]
        {
            get { return AllVariables.ContainsKey(name) ? AllVariables[name] : null; }
            set { AllVariables[name] = value; }
        }
        /// <summary>
        /// Related object list of keys
        /// </summary>
        public List<string> Keys { get { return (Info.Select(x => x.Key).ToList()); } }
        #endregion

        #region Constructors
        /// <summary>
        /// Basic constructor
        /// </summary>
        public DataContainer()
        {
            ObjectName = "";
        }
        /// <summary>
        /// Valued constrctor
        /// </summary>
        /// <param name="name">Data container name</param>
        public DataContainer(string name) : base()
        {
            ObjectName = name;
        }
        #endregion

        #region Static methods
        /// <summary>
        /// Removes an info
        /// </summary>
        /// <param name="name">Info name</param>
        public static void Delete(string name)
        {
            AllVariables.Remove(name);
        }
        /// <summary>
        /// Clones an info 
        /// </summary>
        /// <param name="from">Copy from</param>
        /// <param name="to">Copy to</param>
        /// <returns>A new info</returns>
        public static AbstractInfo Clone(string from, string to)
        {
            AbstractInfo vFrom = AllVariables[from];
            if (vFrom == null)
                return null;
            AllVariables[to] = (AbstractInfo)vFrom.Clone();
            return AllVariables[to];
        }
        /// <summary>
        /// Gets and object based on name
        /// </summary>
        /// <param name="name">Object name</param>
        /// <returns>A datacontainer of the current object</returns>
        public static DataContainer GetObject(string name)
        {
            return new DataContainer(name);
        }
        /// <summary>
        /// Get an object who contains that variable
        /// </summary>
        /// <param name="variable">The variable</param>
        /// <returns>The datacontainer of the current object</returns>
        public static DataContainer GetObject(AbstractInfo variable)
        {
            string key = DataContainer.AllVariables.FirstOrDefault(k => k.Value == variable).Key;
            key = key.Substring(0, key.LastIndexOf("."));
            return new DataContainer(key);
        }
        /// <summary>
        /// Clones an object (in means to clone all inside infos)
        /// </summary>
        /// <param name="from">Copy from</param>
        /// <param name="to">Copy to</param>
        /// <returns>The new container</returns>
        public static DataContainer CloneObject(string from, string to)
        {
            DataContainer vFrom = new DataContainer(from);
            DataContainer vTo = new DataContainer(to);

            foreach (string key in vFrom.Keys)
            {
                string newKey = ("..." + key).Replace("..." + from, to);
                Clone(key, newKey);
            }

            return vTo;
        }
        /// <summary>
        /// Empties an object
        /// </summary>
        /// <param name="name">The object to empty</param>
        public static void EmptyObject(string name)
        {
            DataContainer dataContainer = GetObject(name);
            foreach (String key in dataContainer.Keys)
                Delete(key);
        }
        #endregion
    }
}
