using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;
            //perebor sborok na kotorie ssilaetsya prilogenie
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                //zagruzka sborki dlya chtenia dannih
                var a = Assembly.Load(new AssemblyName(r.FullName));
                //obyavlenie peremennoi dlya podscheta metodov
                int methodCount = 0;
                //perebor vseh tipov v sborke
                foreach (var t in a.DefinedTypes)
                {
                    //dobavlenie kolichestva metodov
                    methodCount += t.GetMethods().Count();
                }
                //vivod kolichestva tipov i ih metodov
                Console.WriteLine($"{a.DefinedTypes.Count():N0} types " + 
                $"with {methodCount:N0} methods in {r.Name} assembly.");

            }
        }
    }
}
