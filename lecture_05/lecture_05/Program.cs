using System;

namespace lecture_05
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            string convert = String.Format("{0:00}:{1:00}:{2:00}",
            time.Hours, time.Minutes, time.Seconds);
            if (time.Hours < 12 && time.Hours > 9)
            {
                Console.WriteLine(convert + " Good morning, guys");
            }
            if (time.Hours > 12 && time.Hours < 15)
            {
                Console.WriteLine(convert + " Good day, guys");
            }
            if (time.Hours > 15 && time.Hours < 22)
            {
                Console.WriteLine(convert + " Good evening, guys");
            }
            else
            {
                Console.WriteLine(convert + " Good night, lion pride");
            }//Мне нужно было только понять что можно было TimeSpan представить DateTime и использовать его уже в цикле.
             //
        }
    }
}
