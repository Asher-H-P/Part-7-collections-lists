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
            List<string> names = new List<string>() { "", "Gussell"};
            string[] names2 = new string[] { "Jermaine", "Jerome", "Lamarques", "Lucius",
                "Leslie", "Khalil", "Cleophus", "Quincy", "Kenyal", "Kendrell", "Clifton",
                "Aemen", "Ameen", "Adre", "Andre", "Alfred", "Alonzo", "Arohn", "Maury",
                "Marvin", "Itzcoatl", "Beronne", "Howell", "Shelly", "Vaughn", "Ynobe",
                "Wesley", "Raul", "Raymont", "Posteal", "Perez", "Deangelo"};
            names.Add("Dellmus");
            names[0] = "Shiquan";
            int remove;
            bool done = false;
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
                if (k <= 33)
                {
                    Console.Write(names[k] + "-");
                }
                else if (k == 34)
                {
                    Console.Write(names[k]);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            names.Sort();
            for (int l = 0; l < names.Count; l++)
            {
                if (l <= 33)
                {
                    Console.Write(names[l] + "-");
                }
                else if (l == 34)
                {
                    Console.Write(names[l]);
                    Console.Write($"     {names.Count}");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            while (!done)
            {
                for (int m = 0; m < names.Count; m++)
                {
                    Console.Write(names[m].Length + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please pick a number between 1 and 35 to remove a name.");
                remove = Convert.ToInt32(Console.ReadLine());
                if (remove >= 1 && remove <= 35)
                {
                    names.RemoveAt(remove - 1);
                    Console.WriteLine("Removal successful.");
                    for (int n = 0; n < names.Count; n++)
                    {
                        if (n <= 32)
                        {
                            Console.Write(names[n] + "-");
                        }
                        else if (n == 33)
                        {
                            Console.Write(names[n]);
                            Console.Write($"     {names.Count}");
                        }
                    }
                    done = true;
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (remove <= 0 || remove >= 36)
                {
                    Console.WriteLine("Incompatable! Try again");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("ERROR!");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            names.Clear();
            for (int o = 0; o < names.Count; o++)
            {
                if (o <= 32)
                {
                    Console.Write(names[o] + "-");
                }
                else if (o == 33)
                {
                    Console.Write(names[o]);
                    Console.Write($"     {names.Count}");
                }
            }
        }
    }
}
