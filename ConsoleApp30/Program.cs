using System;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ne qeder list olsun?");
            int asd= int.Parse( Console.ReadLine());
            Group[] grup = new Group[asd];
            for (int i = 0; i < asd; i++)
            {
                string inputStrStr;
                do
                {
                    Console.WriteLine("grup No");
                    inputStrStr = Console.ReadLine();


                } while (string.IsNullOrWhiteSpace(inputStrStr) || inputStrStr.Length != 5 || !Hasnumber(inputStrStr) || !HasUpper(inputStrStr));
                string intput;
                do
                {
                    Console.WriteLine("groupdaki telebelerin max sayi");
                    intput = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(intput) || !HasDigit1(intput));
             


            }

            
           
            
            
            
           
        }
        static bool HasUpper(string str)
        {
            int count = 0;
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                        count++;
                }
                if (count == 2)
                {
                    return true;

                }
            }

            return false;
        }
        static bool Hasnumber(string str)
        {
            int count = 0;
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                        count++;
                }
                if (count == 3)
                {
                    return true;

                }

            }

            return false;
        }
        static bool HasDigit1(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                        return true;
                }
            }


            return false;
        }
        




    }
}
