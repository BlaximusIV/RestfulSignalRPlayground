using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProtoBuf;

namespace Serialization
{
    /// <summary>
    /// A simple abstraction for using the protobuf-net serializer.
    /// </summary>
    public static class ProtoSerializer
    {
        // This serialization strategy can be found at https://www.c-sharpcorner.com/article/serialization-and-deserialization-ib-c-sharp-using-protobuf-dll/
        public static T Deserialize<T>(byte[] data) where T : class
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

        public static IEnumerable<T> DeserializeCollection<T>(byte[] data)
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

        public static byte[] Serialize<T>(T objectReference)
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

        public static byte[] Serialize<T>(IEnumerable<T> objectReferences)
        {
            if (null == objectReferences)
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
    }
}
