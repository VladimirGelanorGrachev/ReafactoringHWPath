using System.Numerics; 

namespace Programs
{
    class Program
    {
        static BigInteger Factorial(uint number)
        {        
            uint result = 1;
            for(uint i = 1; i <= number; i++)            
                if(i == 0)
                    result = 1;
                else
                    result *= i;                
                return result;
        }
        static uint Summ(uint number)
        {
            uint sum = 0;
            for (uint i = 0; i <= number; i++)
            {
                sum += i;
            }
            return sum;
        }
        static uint Chet(uint number)
        {
            uint chet = 0;
            for (uint i = 0; i <= number; i++)
            {
                if(i%2==0)
                {
                    chet= i;
                }
            }

                return chet;
        }


        static void Main(string[] args)
        {            
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа");
            Console.Write("пожалуйста, введите число: ");

            string usernumber = Console.ReadLine();

            if(usernumber=="q")
            {
                return;
            }
            uint number = UInt32.Parse(usernumber);                       
                  
            Console.WriteLine($"Факториал числа {number} равен " + Factorial(number));
            Console.WriteLine($"Сума от 1 до {number} равна " + Summ(number));
            Console.WriteLine($"максимальное четное число меньше {number} равно " + Chet(number));
        }
    }
}
