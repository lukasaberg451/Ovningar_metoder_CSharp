namespace Övningar_metoder_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1
            //int a1 = 1;
            //int b1 = 2;
            //int result = Add(a1, b1);

            //Console.WriteLine(result);

            ////2
            //int a2 = 7;
            //int b2 = 8;

            //int result2 = Max(a2, b2);
            //Console.WriteLine(result2);

            ////3
            //int number = 10;
            //bool result3 = IsEven(number);

            //Console.WriteLine(result3);

            //4
            List<string> tasks = CollectTasks();
            Console.WriteLine("Dina uppgifter:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static int Max(int a, int b)
        {
            int result = Math.Max(a, b);
            return result;
        }

        public static bool IsEven(int number)
        {
            if (number %2 == 1)
            {
                bool result = false;
                return result;
            }
            else
            {
                bool result = true;
                return result;
            }
        }

        static List<string> CollectTasks()
        {
            List<string> tasks = new List<string>();
            string input;

            do
            {
                Console.WriteLine("Skriv in en uppgift (eller \"klar\" för att avsluta): ");
                input = Console.ReadLine();

                if (input != "klar")
                {
                    tasks.Add(input);
                }
            } while (input != "klar");

            return tasks;
        }
    }
}
