using System;
using static System.Console; // Removing Console from code (WriteLine)

namespace Variables
{
    class Program
    {
        public static void Main()
        {
            //object height = 1.88; хранение double в виде объекта
            object name = "Constantine"; // хранение string в виде объекта
            //int length1 = name.Length; ошибка компиляции
            int length2 = ((string)name).Length; // приведение для доступа к членам
            dynamic anotherName = "Nicholas"; // хранение строки как dynamic
            int length1 = anotherName.Length;
            WriteLine($"NAME length is {length2} symbol(s)." +
                $"ANOTHERNAME length is {length1} symbol(s).");

            // Var usage and formatting
            var population = 66_000_000; // population in GB
            var weight = 1.88; // kilogramms
            var price = 4.99M; // british pounds
            var fruit = "Apples"; // string in double-quotes
            var letter = 'Z'; // character in single-quotes
            var happy = true; // boolean value
            WriteLine($"{population.GetType()}, {weight.GetType()}, {price.GetType()}, " +
                $"{fruit.GetType()}, {letter.GetType()}, {happy.GetType()}.");
            WriteLine($"The UK population is {population} or {population:N0} and " +
                $"{weight}kg of {fruit} costs {price:C}.");

            // Null values
            WriteLine($"{default(int)}, {default(bool)}, {default(DateTime)}");
            // 0, False, 1/01/0001 12:00:00 AM
            int cannotBeNull = 4;
            int? canBeNull = null;
            if (canBeNull == null)
            { WriteLine($"{cannotBeNull}, {canBeNull}(null where spacer)"); }
            else
            { WriteLine("no null value"); }
            string authorName = null;
            int? howManyLetters = authorName?.Length; //If authorName = null, return null instead of exception
            var result = howManyLetters ?? 3; // result equal to 3, if hML = null
            WriteLine(result);

            // Arrays storing
            var names = new string[4]; // Declare array size
            names[0] = "Ann";
            names[1] = "Jack";
            names[2] = "Susan";
            names[3] = "Lee";
            for(int i=0; i<names.Length; i++)
            { WriteLine(names[i]); } // Read element with current index (i) position
        }
    }
}
