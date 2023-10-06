using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Ref_out_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FIRST TASK

          

            string a = "";
            string b = "";
            Console.WriteLine("deyerleri daxil edin :");


            Task1InputMethod(ref a, ref b);
            Console.WriteLine(Task1IsInteger(ref a, ref b));

            if (Task1IsInteger(ref a, ref b))
            {
                int aa = int.Parse(a);
                int bb = int.Parse(b);
                int sum = Task1Sum(ref aa, ref bb);
                Console.WriteLine("Daxil olunan ededlerin cemi: " + sum);
            }
            else
            {
                Console.WriteLine("error");
            }
           
            
        }

        static string Task1InputMethod(ref string value, ref string value1)
        {
            value = Console.ReadLine();
            value1 = Console.ReadLine();
            return value;
        }

        static bool Task1IsInteger(ref string input, ref string input1)
        {
            int result, result1;
            if (int.TryParse(input, out result) && int.TryParse(input1, out result1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static int Task1Sum(ref int num1, ref int num2)
        {
            return num1 + num2;
        }
    }
}


         //SECOND TASK



//                int[] a = new int[8] { 1, 2, 4, 3, 5, 767, 8, 9 };

//                Task2(ref a, 14);


//                for (int i = 0; i < a.Length; i++)
//                {
//                    Console.Write(a[i] + " ");
//                }
//                
    

//            static void Task2(ref int[] numbers, int value)
//                {
//                    int[] newArray = new int[numbers.Length + 1];

//                    for (int i = 0; i < numbers.Length; i++)
//                    {
//                        newArray[i] = numbers[i];
//                    }
//                    newArray[^1] = value;

//                    numbers = newArray;
//                }
//            
