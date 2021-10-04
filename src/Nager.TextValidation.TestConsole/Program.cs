using Nager.TextValidation.DrawKeyboard;
using Nager.TextValidation.KeyboardLayouts;
using System;

namespace Nager.TextValidation.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            new DrawEngine().DrawKeyboard(new QwertzKeyboardLayout());
            new DrawEngine().DrawKeyboard(new QwertyKeyboardLayout());
            new DrawEngine().DrawKeyboard(new AzertyKeyboardLayout());


            //KeyboardKeyDistance.Check(“hallo”);             4.1441311123146738
            //KeyboardKeyDistance.Check(“asdf”);              1.125
            //KeyboardKeyDistance.Check(“fred”);              0.93401699437494745
            //KeyboardKeyDistance.Check(“Datenqualität”);     6.2739057206509461

            var validator = new TextValidator(new QwertzKeyboardLayout());

            var goodWords = new string[] { "Thomas", "Simone", "Fred", "Michael", "Apfelbaum", "Schwierig", "Vielleicht", "Manchmal", "Brot", "Kaffee", "Deutschland", "Feuerwehr" };
            var badWords = new string[] { "asdf", "qwertz", "asddfghjk", "qwead", "gfdsa", "ycxcyxc" };

            Console.WriteLine("Good words");
            Console.WriteLine("------------------------------");
            foreach (var word in goodWords)
            {
                var analyze1 = validator.Check(word);
                var analyze2 = validator.Check(word.ToLower());
                var analyze3 = analyze1 > 2;
                Console.WriteLine($"{word} {analyze1:0.00} {analyze2:0.00} {analyze3}");
            }

            Console.WriteLine("Bad words");
            Console.WriteLine("------------------------------");
            foreach (var word in badWords)
            {
                var analyze1 = validator.Check(word);
                var analyze2 = validator.Check(word.ToLower());
                var analyze3 = analyze1 > 2;
                Console.WriteLine($"{word} {analyze1:0.00} {analyze2:0.00} {analyze3}");
            }


            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}
