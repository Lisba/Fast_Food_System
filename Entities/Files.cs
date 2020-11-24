using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entities
{
    public class Files<T> where T : class
    {
        /// <summary>
        /// Serializa un objeto recibido por parámetro (Utiliza Generic para lograr su funcionalidad).
        /// </summary>
        /// <param name="objectToSerialize"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public void SerializeObject(T objectToSerialize, string name)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + name + ".xml";

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(filePath, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, objectToSerialize);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        ///DesSerializa un objeto recibido por parámetro (Utiliza Generic para lograr su funcionalidad).
        /// </summary>
        /// <param name="objectToDeserialize"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public T DeserializeObject(string name)
        {
            T deserializedObject;

            string filePath = AppDomain.CurrentDomain.BaseDirectory + name + ".xml";

            try
            {
                using (XmlTextReader reader = new XmlTextReader(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return deserializedObject = (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
