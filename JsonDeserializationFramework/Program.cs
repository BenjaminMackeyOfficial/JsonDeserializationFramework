using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace JsonDeserializationFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data newDat = new Data();
            newDat.Number1 = 3;
            newDat._number2 = 4;

            string j = JsonSerializer.Serialize(newDat);

            string path = "Data.json";
            File.WriteAllText(path, j);
        }
    }
}
