using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_collections_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Shiquan", "Gussell"};
            string[] names2 = new string[] { "Jermaine", "Jerome", "Lamarques", "Lucius", "Leslie", "Khalil", "Cleophus", "Quincy", "Kenyal", "Kendrell", "Clifton", "Aemen", "Ameen", "Adre", "Andre", "Alfred", "Alonzo", "Arohn", "Maury", "Marvin", "Itzcoatl", "Beronne", "Howell", "Shelly", "Vaughn", "Ynobe", "Wesley", "Raul", "Raymont", "Posteal", "Perez", "Deangelo"};
            names.Add("Dellmus");
            names[0] = "Greg";
            Console.WriteLine(names[1]);
            Console.WriteLine(names[names.Count - 1]);
            Console.WriteLine();
            Console.WriteLine();
            //names.Remove("");
            //names.RemoveAt(#);
            //Adds things from a collection to the end of a list.
            //Finds out if a certain thing is in the list.
            //List.Sort();
            //List.IndexOf();
            //List.RemoveAll();
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine();
            names[0] = "SHIQUAN";
            names[1] = "GUSSELL";
            names[2] = "DELLMUS";
            names.Sort();
            for (int j = 0; j < names.Count; j++)
            {
                Console.WriteLine(names[j]);
            }
            Console.WriteLine();
            Console.WriteLine();
            names.AddRange(names2);
            names[0] = "Shiquan";
            names[1] = "Gussell";
            names[2] = "Dellmus";
            for (int k = 0; k < names.Count; k++)
            {
                Console.Write(names[k] + "-");
            }
            Console.WriteLine();
            Console.WriteLine();
            names.Sort();
            for (int l = 0; l < names.Count; l++)
            {
                Console.Write(names[l] + "-");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int m = 0; m < names.Count; m++)
            {
                Console.Write(names[m].Length);
            }
        }
    }
}
