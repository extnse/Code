using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // хранение double в виде объекта
            object name = "Constantine"; // хранение string в виде объекта
            //int length1 = name.Length; // ошибка компиляции
            int length2 = ((string)name).Length; // приведение для доступа к членам
            dynamic anotherName = "Nicholas"; // хранение строки как dynamic
            int length1 = anotherName.Length;

            var population = 66_000_000; // millions in GB
            var weight = 1.88; // kilogramms
            var price = 4.99M; // british pounds
            var fruit = "Apples"; // string in double-quotes
            var letter = 'Z'; // character in single-quotes
            var happy = true; // boolean value
            Console.WriteLine($"NAME length is {length2} symbol(s).");
            Console.WriteLine($"ANOTHERNAME length is {length1} symbol(s).");
            Console.WriteLine($"using vars {population.GetType()}, {weight.GetType()}, {price.GetType()}, " +
                $"{fruit.GetType()}, {letter.GetType()}, {happy.GetType()}.");
        }
    }
}
