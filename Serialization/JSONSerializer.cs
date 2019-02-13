using Newtonsoft.Json;

namespace Serializer
{
    /// <summary>
    /// A simple abstraction for using the Newtonsoft.JSON serializer
    /// </summary>
    public static class JSONSerializer
    {
        #region Fields
        private static readonly JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All,
            DateParseHandling = DateParseHandling.DateTime,
            Formatting = Formatting.Indented
        };
        #endregion

        #region Public Methods

        public static T Deserialize<T>(string data) => 
            JsonConvert.DeserializeObject<T>(data, settings);

        //public IEnumerable<T> DeserializeCollection<T>(string objectStrings) =>
        //    JsonConvert.DeserializeObject<IEnumerable<T>>(objectStrings, settings);

        public static string Serialize<T>(T objectReference) =>
            JsonConvert.SerializeObject(objectReference, settings);

        //public string Serialize<T>(IEnumerable<T> objectReferences) =>
        //    JsonConvert.SerializeObject(objectReferences, settings);

        #endregion
    }
}
