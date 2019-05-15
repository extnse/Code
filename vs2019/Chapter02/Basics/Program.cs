using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main()
        {
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;
            //перебор сборок на которые ссылается приложение
            foreach (var r in Assembly.GetEntryAssembly() 
                .GetReferencedAssemblies())
            {
                //загрузка сборки для чтения данных
                var a = Assembly.Load(new AssemblyName(r.FullName));
                //объявление переменной для подсчета методов
                int methodCount = 0;
                //перебор всех типов в сборке
                foreach (var t in a.DefinedTypes)
                {
                    //добавление количества методов
                    methodCount += t.GetMethods().Count();
                }
                //вывод количества методов и их типов
                Console.WriteLine($"{a.DefinedTypes.Count():N0} types " +
                    $"with {methodCount:N0} methods in {r.Name} assembly.");
            }
        }
    }
}
