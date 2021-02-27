using System;
using System.IO;
using MsgPack;
using MsgPack.Serialization;

namespace MsgPack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var serializer = MessagePackSerializer.Get<string>();
            MemoryStream byteStream = new MemoryStream(); 
            serializer.Pack(byteStream, "Prova String");
            byteStream.Position = 0;
            var value = serializer.Unpack(byteStream);

            Byte[] bytearray = byteStream.ToArray();
            foreach (Byte x in bytearray) 
            {
                Console.Write($"{x}");
            }

            string bubu = Deserialize<string>(bytearray);
            Console.WriteLine(bubu);
            //Console.WriteLine($"{byteStream.ToArray()}");
        }

        public static byte[] Serialize<T>(T thisObj)
        {
            var serializer = MessagePackSerializer.Get<T>();

            using (var byteStream = new MemoryStream())
            {
                serializer.Pack(byteStream, thisObj);
                return byteStream.ToArray();
            }
        }


        //T = qualsiasi tipo di dato
        public static T Deserialize<T>(byte[] bytes)
        {
            var serializer = MessagePackSerializer.Get<T>();
            using (var byteStream = new MemoryStream(bytes))
            {
                return serializer.Unpack(byteStream);
            }
        }


    }
}
