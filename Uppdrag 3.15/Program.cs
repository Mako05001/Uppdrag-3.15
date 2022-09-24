using System;
namespace uppdrag3._15
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur länge vill du hyra bilen för? (Bara i heltal och inte längre än en dag)");
            string H = Console.ReadLine(); 
            int  Hours = Convert.ToInt32(H);
            int pay = 80* Hours;
            if (pay > 950)
            {
                pay = 950;
            }
            Console.WriteLine("Du ska hyra bilen i " + Hours +" timmar och det kommer att kosta " + pay+ "Kr.");
            
        }
    }
}