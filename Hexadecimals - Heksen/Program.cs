using System.Security.Cryptography;

namespace Hexadecimals___Heksen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast den HEX værdi du ønsker at validere: ");
            string hex = Console.ReadLine().Trim().ToUpper();

            HexValidator validator = new HexValidator();
            validator.validate(hex);
            
        }
    }
}
