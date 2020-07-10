using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laba_1_7
{
    [Serializable]
     class ExecutorP2 : ExecutorP1
    {
        public static  void getTypeInfo(string filename)
        {
            Type type = typeof(ExecutorP2);
            StreamWriter streamWriter = new StreamWriter(filename);
            foreach (MemberInfo mi in type.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
                streamWriter.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }
            streamWriter.Close();
        }

        public void writeBinaryObjectCopy(string filename) {
            Stream fileStreamer = new FileStream(filename, FileMode.Create);
            BinaryFormatter bFormetter = new BinaryFormatter();
            bFormetter.Serialize(fileStreamer, this);
            fileStreamer.Close();
        }

        public ExecutorP2 readBinaryObjectCopy(string filename)
        {
            Stream fileStreamer = new FileStream(filename, FileMode.Open);
            BinaryFormatter bFormetter = new BinaryFormatter();
            return (ExecutorP2)bFormetter.Deserialize(fileStreamer);
        }

        public void serializeObject(string filename)
        {
            Stream fileStreamer = new FileStream(filename, FileMode.Create);
            BinaryFormatter bFormetter = new BinaryFormatter();
            bFormetter.Serialize(fileStreamer, this);
            fileStreamer.Close();
        }

        public ExecutorP2 deserializeObject(string filename)
        {
            Stream fileStreamer = new FileStream(filename, FileMode.Open);
            BinaryFormatter bFormetter = new BinaryFormatter();
            return (ExecutorP2)bFormetter.Deserialize(fileStreamer);
        }
    }
}
