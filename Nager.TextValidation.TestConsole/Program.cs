using Nager.TextValidation.KeyboardLayout;

namespace Nager.TextValidation.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //KeyboardKeyDistance.Check(“hallo”);             4.1441311123146738
            //KeyboardKeyDistance.Check(“asdf”);              1.125
            //KeyboardKeyDistance.Check(“fred”);              0.93401699437494745
            //KeyboardKeyDistance.Check(“Datenqualität”);     6.2739057206509461

            var validator = new Validator(new QwertyKeyboard());
            var analyze1 = validator.Check("asdf asdf");
            var analyze2 = validator.Check("Hallo wie gehts?");
        }
    }
}
