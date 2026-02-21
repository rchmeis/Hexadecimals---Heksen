namespace Hexadecimals___Heksen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This program will verify if a string is a valid hexadecimal and color.
            //For each requirement a method is created to verify that the requirement is met.
            
            Console.WriteLine("Input value to verify if it is a valid hexidecimal and color: ");
            string input = Console.ReadLine().ToLower();

            bool indexZero = Check.Index0(input);            
            bool length = Check.Length(input);
            bool HexValue = Check.ValidHex(input);
            
            if(indexZero && length && HexValue)
            { Console.WriteLine("This is a valid hexcolor."); }
                


        }
    }
}
