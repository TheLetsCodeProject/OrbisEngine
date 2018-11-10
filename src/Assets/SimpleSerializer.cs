using System;
using UnityEngine;
using System.IO;

namespace OrbisEngine.Serialization {

    public class SimpleSaver
    {

        string m_BasePath;
        public DataType m_Encoding;
        public string BasePath { get { return m_BasePath; } }

        public SimpleSaver(string basePath, DataType encoding)
        {
            m_BasePath = basePath;
            m_Encoding = encoding;
        }

        public SimpleSaver(string basePath) : this(basePath, DataType.Ascii) { }

        public void SaveString(string key, string value)
        {
            string PATH = Path.Combine(m_BasePath, key + "STR");

            if(m_Encoding == DataType.Binary) {

                using (BinaryWriter writer = new BinaryWriter(File.Open(PATH, FileMode.Create))) {
                    writer.Write(value);
                }
            }
            else {

                using (StreamWriter writer = new StreamWriter(File.Open(PATH, FileMode.Create))) {
                    writer.Write(value);
                }
            }
        }

        public void SaveStringBinary(string PATH, string value)
        {

        }
    }

    public enum DataType { Ascii, Binary }
}
