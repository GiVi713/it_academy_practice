using System;

namespace letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var words = Console.ReadLine();
            for (int i = 0; i < words.Length; i++)
            {   
                if (words[i] == 'a')
                {
                    count++;
                }               
            }Console.WriteLine("Numver of a " + count);
        }
    }
}
