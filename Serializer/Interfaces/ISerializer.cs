using System;
using System.Collections.Generic;
using System.Text;

namespace Serializer.Interfaces
{
    /// <summary>
    /// Interface for serializing both javascript and protobuf
    /// </summary>
    public interface ISerializer
    {
        string Serialize<T>(T objectReference);
        string Serialize<T>(IEnumerable<T> objectReferences);
    }
}
