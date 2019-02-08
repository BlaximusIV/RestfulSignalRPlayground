using System.Collections.Generic;
using Serializer.Interfaces;

namespace Serializer.Implementations
{
    public class Serializer : ISerializer
    {
        public string Serialize<T>(T objectReference)
        {
            throw new System.NotImplementedException();
        }

        public string Serialize<T>(IEnumerable<T> objectReferences)
        {
            throw new System.NotImplementedException();
        }
    }
}
