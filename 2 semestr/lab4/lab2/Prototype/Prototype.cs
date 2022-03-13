using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab2.Prototype
{
    [Serializable]
    public abstract class Prototype<T>
    {
        public virtual T DeepCopy()
        {
            using (var stream = new MemoryStream())
            {
                var context = new StreamingContext(StreamingContextStates.Clone);
                var formatter = new BinaryFormatter { Context = context };
                formatter.Serialize(stream, this);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
    }

    public interface IPrototype<T>
    {
        T Clone();
    }
}
