namespace _12._11._26_practic_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Для масиву цілих реалізуйте такі запити:
Отримати весь масив цілих;
            Отримати парні цілі;
            Отримати непарні цілі;
            Отримати значення більше заданого;
            Отримати числа в заданому діапазоні;
            Отримати числа кратні семи. Результат відсортувати за зростанням;
            Отримати числа кратні восьми. Результат відсортувати за спаданням.*/ /// TASK1 
            Console.WriteLine("--------------Task1-------------\n");
            List<int> list = new List<int> { 10, 20, 30, 56, 78, 23, 34, 90, 99, 88 };

            var result = list.Select(n => n);
            Console.WriteLine("All numbers:");
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }

            var result2 = list.Where(n => n % 2 == 0);
            Console.WriteLine("Even numbers:");
            foreach (int n in result2)
            {
                Console.WriteLine(n);
            }

            var result3 = list.Where(n => n % 2 != 0);
            Console.WriteLine("Odd numbers:");
            foreach (int n in result3)
            {
                Console.WriteLine(n);
            }

            var result4 = list.Where(n => n > 33);
            Console.WriteLine("Numbers more 33:");
            foreach (int n in result4)
            {
                Console.WriteLine(n);
            }

            var result5 = list.Where(n => n >= 15 && n <= 50);
            Console.WriteLine("Numbers in the range:");
            foreach (int n in result5)
            {
                Console.WriteLine(n);
            }

            var result6 =
                list.Where(n => n % 7 == 0)
                .OrderBy(n => n);
            Console.WriteLine("A multiple of 7 and growth:");
            foreach (int n in result6)
            {
                Console.WriteLine(n);
            }

            var result7 =
                list.Where(n => n % 8 == 0)
                .OrderByDescending(n => n);
            Console.WriteLine("A multiple of 8 and deprecising:");
            foreach (int n in result7)
            {
                Console.WriteLine(n);
            }




            Console.WriteLine("---------TASK2------------\n");
            /*Для масиву рядків, що містять назву міст, реалізуйте такі запити:
            Отримати весь масив міст;
            Отримати міста з довжиною назви, що дорівнює заданій;
            Отримати міста, назви яких починаються з літери A;
            Отримати міста, назви яких закінчуються літерою M;
            Отримати міста, назви яких починаються з літери N і закінчуються літерою K;
            Отримати міста назви яких починаються на Ne.Результат відсортувати за спаданням.*/
            List<string> list2 = new List<string> {"Amsterdam", "New York", "Newcastle",
                "Auckland","Naples", "Newark", "Berlin",
                "Athens", "Nantes", "Stockholm","Kyiv" };

            var res = list2.Select(n => n);
            Console.WriteLine("All cities:");
            foreach (string n in res)
            {
                Console.WriteLine(n);
            }

            int Length = 4;
            var res2 = list2.Where(n => n.Length == Length);
            Console.WriteLine("Cities with name length 4:");
            foreach (string n in res2)
            {
                Console.WriteLine(n);
            }

            var res3 = list2.Where(n => n.StartsWith("A"));
            Console.WriteLine("Cities starting with A:");
            foreach (string n in res3)
            {
                Console.WriteLine(n);
            }

            var res4 = list2.Where(n => n.EndsWith("m"));
            Console.WriteLine("Cities ending with M:");
            foreach (string n in res4)
            {
                Console.WriteLine(n);
            }

            var res5 = list2.Where(n => n.StartsWith("N") && n.EndsWith("k"));
            Console.WriteLine("Cities starting with N and ending with K:");
            foreach (string n in res5)
            {
                Console.WriteLine(n);
            }

            var res6 = list2.Where(n => n.StartsWith("Ne"))
                .OrderByDescending(n => n);
            Console.WriteLine("Cities starting with Ne :");
            foreach (string n in res6)
            {
                Console.WriteLine(n);
            }
        }
    }
}
