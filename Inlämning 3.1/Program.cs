using System;
namespace Inlämning_3.__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du");
            int gammal = int.Parse(Console.ReadLine());
            if(gammal >=16 && gammal<=19)
            {
                Console.WriteLine("Du får delta i tävlingen");
            }
            else if (gammal < 16)
            {
                Console.WriteLine("Du är för ung för att delta");
            }
            else if (gammal >19)
            {
                Console.WriteLine("Du är för gammal för att delta");
            }
        }   
    }
}