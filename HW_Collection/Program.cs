using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Collection
{
    public class Program
    {
        //Решить следующие задачи с использованием класса Stack:
        /*1. Дан файл, в котором записан набор чисел. Переписать в другой файл все числа в обратном порядке.*/
        public class Task1
        {
            public void Solution()
            {
                Console.WriteLine(" ===================================================================================================");
                Console.WriteLine("   1. Дан файл, в котором записан набор чисел. Переписать в другой файл все числа в обратном порядке.");
                Console.WriteLine(" ===================================================================================================");
                Console.ReadKey();
                Stack<int> MyIntStack = new Stack<int>();
                Stack<int> MyIntStackReverse = new Stack<int>();

                for (int i = 10; i > 0; i--)
                    MyIntStack.Push(i);  // заполняю оригинальный стэк

                foreach (int item in MyIntStack)
                    MyIntStackReverse.Push(item); // переписываю все из MyIntStack в MyIntStackReverse

                Stack<string> printSolution = new Stack<string>();
                Console.WriteLine("\n\tMyIntStack   |   MyIntStack Reverse");
                for (int i = 0; i < 10; i++)
                {
                    if (i != 9)
                        Console.WriteLine("\t\t " + MyIntStack.ElementAt(i) + "   |   " + MyIntStackReverse.ElementAt(i));
                    else Console.WriteLine("\t\t" + MyIntStack.ElementAt(i) + "   |   " + MyIntStackReverse.ElementAt(i) + "\n\n\n");
                }

                Console.ReadKey();


            }

        }

        /*2. Создать текстовый файл. Распечатать гласные буквы этого файла в обратном порядке.*/
        public class Task2
        {
            public void Solution()
            {
                Console.WriteLine(" ===================================================================================================");
                Console.WriteLine("   2. Создать текстовый файл. Распечатать гласные буквы этого файла в обратном порядке.");
                Console.WriteLine(" ===================================================================================================");
                Console.ReadKey();
                string str = "\n\t\t\tМ а м а   м ы л а   р а м у\n";
                Console.WriteLine(str);
                Stack<char> myStack = new Stack<char>();

                Console.Write("\t");
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 'о' || str[i] == 'а' || str[i] == 'е' || str[i] == 'у' || str[i] == 'ы' || str[i] == 'я')
                    {
                        myStack.Push((char)((int)str[i] - 32));
                        Console.Write("   " + (char)((int)str[i] - 32));
                    }
                }
                Console.Write("   <>");
                foreach (char item in myStack)
                    Console.Write("   " + item);
                Console.WriteLine("\n");

            }
        }

        /*3. Даны 2 строки s1 и s2. Из каждой можно читать по одному символу. Выяснить, является ли строка s2 обратной s1.*/
        public class Task3
        {
            public void Solution()
            {
                Console.WriteLine(" ===================================================================================================");
                Console.WriteLine("   3. Даны 2 строки s1 и s2. Из каждой можно читать по одному символу. Выяснить, является ли строка s2 обратной s1.");
                Console.WriteLine(" ===================================================================================================");
                Console.Write("\n\n\t\tВведите строку s1 : ");
                string s1 = Console.ReadLine();
                Console.Write("\t\tВведите строку s2 : ");
                string s2 = Console.ReadLine();

                //string s1 = "МаДаМ";
                //string s2 = "МаДаМ";

                #region Reshenie_so_Stackom
                List<char> myList = new List<char>();
                Stack<char> myStack = new Stack<char>();
                for (int i = 0; i < s1.Length; i++)
                    myList.Add(s1[i]);
                for (int i = 0; i < s2.Length; i++)
                    myStack.Push(s2[i]);

                if (CompareString(myList, myStack)) Console.WriteLine("\n\tДа! Строка s2 является обратной s1!\n\n\n");
                else Console.WriteLine("\n\tНет! Строка s2 НЕ является обратной s1!\n\n\n");
            }

            private bool CompareString(List<char> myList, Stack<char> myStack)
            {
                for (int i = 0; i < myList.Count; i++)
                    if (myList[i] != myStack.Pop()) return false;
                return true;
                #endregion Reshenie_so_Stackom

                #region reshenie_bez_stacka
                //string s3 = "";

                //Console.WriteLine(s1);
                //foreach (var item in s2.Reverse())
                //{
                //    s3 += item;
                //}
                //Console.WriteLine(s1);
                //Console.WriteLine(s3);

                //if (s1 == s3) Console.WriteLine("\n\tДа! Строка s2 является обратной s1!\n\n\n");
                //else Console.WriteLine("\n\tНет! Строка s2 НЕ является обратной s1!\n\n\n");

                //Console.WriteLine();
                #endregion reshenie_bez_stacka

            }
        }

        /*4. Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке: 
            сначала все символы, отличные от цифр, а затем все цифры, сохраняя исходный порядок в каждой группе символов.*/
        public class Task4
        {
            public void Solution()
            {
                Console.WriteLine(" ===================================================================================================");
                Console.WriteLine("\t\t\t\t4. Дан текстовый файл.\n   " +
                    "За один просмотр файла напечатать элементы файла в следующем порядке:\n " +
            "   - сначала все символы, отличные от цифр,\n    - а затем все цифры, сохраняя исходный порядок в каждой группе символов.");
                Console.WriteLine(" ===================================================================================================");
                Console.ReadKey();

                string textFile1 = "1Зна2е3те 4нав5ерно?";
                string textFile2 = "1Жа2дно3сть - 4это сквер5но!";

                Console.Write("\n\n\t\t=================================================");
                Console.Write("\n\t\t  " + textFile1 + textFile2);
                Console.Write("\n\t\t=================================================");

                Queue<char> str1 = new Queue<char>();
                Queue<char> str2 = new Queue<char>();
                Queue<char> str3 = new Queue<char>();
                Queue<char> str4 = new Queue<char>();

                for (int i = 0; i < textFile1.Length; i++)
                    if ((int)textFile1[i] >= 48 && (int)textFile1[i] < 58)
                        str1.Enqueue(textFile1[i]);
                    else str2.Enqueue(textFile1[i]);

                for (int i = 0; i < textFile2.Length; i++)
                    if ((int)textFile2[i] >= 48 && (int)textFile2[i] < 58)
                        str3.Enqueue(textFile2[i]);
                    else str4.Enqueue(textFile2[i]);

                Console.Write("\n\n\n\t\t\t");
                foreach (char item in str1)
                    Console.Write(item + " ");
                Console.Write("   ");
                foreach (char item in str2)
                    Console.Write(item);
                Console.Write("\n   ");

                Console.Write("\n\t\t\t");
                foreach (char item in str3)
                    Console.Write(item + " ");
                Console.Write("   ");
                foreach (char item in str4)
                    Console.Write(item);
                Console.Write("\n\n\n\n");

                Console.ReadKey();
            }
        }

        /*5. Дан файл, содержащий числа. За один просмотр файла напечатать элементы файла в следующем порядке: 
         сначала все числа, из интервала [a,b], потом все числа, меньшие a, потом все числа, большие b, 
         сохраняя исходный порядок в каждой группе чисел.*/
        public class Task5
        {
            public void Solution()
            {
                Console.WriteLine(" ===================================================================================================");
                Console.WriteLine("\t\t\t  5. Дан файл, содержащий числа. \n" +
              "   За один просмотр файла напечатать элементы файла в следующем порядке:\n" +
              "    - сначала все числа, из интервала [a,b], \n    - потом все числа, меньшие a,\n    - потом все числа, большие b,\n " +
              " сохраняя исходный порядок в каждой группе чисел.\n");
                Console.WriteLine(" ===================================================================================================");
                Console.ReadKey();
                List<int> randomList = new List<int>();
                Random rand = new Random();
                int a = 0;
                int b = 0;


                for (int i = 0; i < rand.Next(10, 30); i++)
                    randomList.Add(rand.Next(1, 100));

                Console.Write("\n\n\t\tДан массив чисел : \n\t\t|");
                foreach (int item in randomList)
                    Console.Write(item + " | ");

                Console.Write("\n\n\n\t\t Определите интервал от А до Б");

                bool correct = false;
                while (!correct)
                {
                    Console.Write("\n\t\t введите А = ");
                    bool isInt = Int32.TryParse(Console.ReadLine(), out a);

                    for (int i = 0; i < randomList.Count; i++)
                        if (a == randomList[i]) { correct = true; break; }

                    if (!correct) Console.WriteLine("\n\t\tТакой цифры нет! ");
                }

                correct = false;
                while (!correct)
                {
                    Console.Write("\n\t\t введите Б = ");
                    bool isInt = Int32.TryParse(Console.ReadLine(), out b);

                    for (int i = 0; i < randomList.Count; i++)
                        if (b == randomList[i]) { correct = true; break; }

                    if (!correct) Console.WriteLine("\n\t\tТакой цифры нет! ");
                }

                Queue<int> otAdoB = new Queue<int>();
                correct = false;
                foreach (int item in randomList)
                {
                    if (item == a) correct = true;
                    if (correct) otAdoB.Enqueue(item);
                    if (item == b) correct = false;
                 }

                Console.Write("\n\t\tИнтервал от А до Б: ");
                foreach (int item in otAdoB)
                    Console.Write(item + " ");
                Console.Write("\n\n\t\tИнтервал все меньше А : {0} \n\t\t", a);

                foreach (int item in randomList)
                    if(item < a)
                        Console.Write(item + " ");
                Console.Write("\n\n\t\tИнтервал все больше Б : {0} \n\t\t", b);

                foreach (int item in randomList)
                    if (item > b)
                        Console.Write(item + " ");

                Console.ReadKey();
            }
        }

        /*6. Дан файл, содержащий числа. За один просмотр файла напечатать элементы файла в следующем порядке: 
                сначала все числа, из интервала [a,b], потом все числа, меньшие a, потом все числа, большие b, 
                сохраняя исходный порядок в каждой группе чисел.*/
        public class Task6
        {
            public void Solution()
            {
                Console.WriteLine(" ===================================================================================================");
                Console.WriteLine("\t  Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке:\n" +
           " сначала все слова, начинающиеся на гласную букву, потом все слова, начинающиеся на согласную букву,\n" +
           " сохраняя исходный порядок в каждой группе слов.");
                Console.WriteLine(" ===================================================================================================");
                Console.ReadKey();

                string text = "if you want to be ok, drink beer every day";
                Console.WriteLine("\t\t" + text);
                List<string> splitText = new List<string>();
                splitText = text.Split().ToList();
                string bookva = "aoieu";

                Queue<string> glassn = new Queue<string>();
                  foreach (string item in splitText)
                    if (bookva.Contains(item[0]))
                        glassn.Enqueue(item);
               
                foreach (string item in splitText)
                    if (!bookva.Contains(item[0]))
                        glassn.Enqueue(item);

                Console.Write("\t\t");
                foreach (string item in glassn)
                    Console.Write(item + " ");

                Console.ReadLine();
            }
        }

                static void Main(string[] args)
        {
            Console.Title = "Домашнее Задание - Латыпов Альфар";

            //Решить следующие задачи с использованием класса Stack:
            #region STACK
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("\n\t\t   Решить следующие задачи с использованием класса Stack:");
            //Console.WriteLine("\t\t ===========================================================");
            //Console.ForegroundColor = ConsoleColor.White;

            ///*1. Дан файл, в котором записан набор чисел. Переписать в другой файл все числа в обратном порядке.*/
            //Task1 task1 = new Task1();
            //task1.Solution();

            ///*2. Создать текстовый файл. Распечатать гласные буквы этого файла в обратном порядке.*/
            //Task2 task2 = new Task2();
            //task2.Solution();

            ///*3. Даны 2 строки s1 и s2. Из каждой можно читать по одному символу. Выяснить, является ли строка s2 обратной s1.*/
            //Task3 task3 = new Task3();
            //task3.Solution();
            //Console.ReadKey(); Console.Clear();
            #endregion STACK

            #region Queue
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t   Решить следующие задачи с использованием класса Queue:");
            Console.WriteLine("\t\t ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

           // /*4. Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке: 
           // сначала все символы, отличные от цифр, а затем все цифры, сохраняя исходный порядок в каждой группе символов.*/
           // Task4 task4 = new Task4();
           // task4.Solution();

           // /*5.Дан файл, содержащий числа. За один просмотр файла напечатать элементы файла в следующем порядке: 
           //сначала все числа, из интервала [a,b], потом все числа, меньшие a, потом все числа, большие b,
           //сохраняя исходный порядок в каждой группе чисел.*/
           // Task5 task5 = new Task5();
           // task5.Solution();

            /*6.Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке: 
           сначала все слова, начинающиеся на гласную букву, потом все слова, начинающиеся на согласную букву, 
           сохраняя исходный порядок в каждой группе слов.*/
            Task6 task6 = new Task6();
            task6.Solution();



            #endregion Queue

        }





    }
}
