using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProtoBuf;

namespace Serializer
{
    public static class Serializer
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

        #region JSON Serialization
        public static T DeserializeJSON<T>(string data) => 
            JsonConvert.DeserializeObject<T>(data, settings);

        //public IEnumerable<T> DeserializeJSONObjects<T>(string objectStrings) =>
        //    JsonConvert.DeserializeObject<IEnumerable<T>>(objectStrings, settings);

        public static string SerializeJSON<T>(T objectReference) =>
            JsonConvert.SerializeObject(objectReference, settings);

        //public string SerializeJSON<T>(IEnumerable<T> objectReferences) =>
        //    JsonConvert.SerializeObject(objectReferences, settings);
        #endregion

        #region Protobuf Serialization
        // This serialization strategy can be found at https://www.c-sharpcorner.com/article/serialization-and-deserialization-ib-c-sharp-using-protobuf-dll/
        public static T DeserializeProto<T>(byte[] data) where T : class
        {
            if (null == data)
                return null;

            try
            {
                T item;
                using (MemoryStream stream = new MemoryStream(data))
                {
                    item = ProtoBuf.Serializer.Deserialize<T>(stream);
                }
                return item;
            }
            catch
            {
                throw;
            }
        }

        public static IEnumerable<T> DeserializeProtoObjects<T>(byte[] data)
        {
            if (null == data)
                return null;

            try
            {
                List<T> items = new List<T>();
                using (MemoryStream stream = new MemoryStream(data))
                {
                    items = ProtoBuf.Serializer.DeserializeItems<T>(stream, PrefixStyle.Base128, 1).ToList();
                }
                return items;
            }
            catch
            {
                throw;
            }
        }

        public static byte[] SerializeProto<T>(T objectReference)
        {
            if (null == objectReference)
                return null;

            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    ProtoBuf.Serializer.Serialize(stream, objectReference);
                    return stream.ToArray();
                }
            }
            catch
            {
                throw;
            }
        }

        public static byte[] SerializeProto<T>(IEnumerable<T> objectReferences)
        {
            if(null == objectReferences)
                return null;

            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    ProtoBuf.Serializer.Serialize(stream, objectReferences);
                    return stream.ToArray();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #endregion
    }
}
