using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Core.Utilities
{
    public class JsonHelper
    {
        public static Encoding Encoding = Encoding.UTF8;

        /// <summary>
        /// Serialize an object to JSON stream.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string Serializer<T>(T t)
        {
            using (var ms = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                ser.WriteObject(ms, t);
                string result = Encoding.GetString(ms.ToArray());
                ser = null;
                return result;
            }
        }

        /// <summary>
        /// // Deserialize JSON stream to an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T Deserializer<T>(string json)
        {
            using (var ms = new MemoryStream(Encoding.GetBytes(json)))
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                T t = (T)ser.ReadObject(ms);
                ser = null;
                return t;
            }
        }
    }
}
