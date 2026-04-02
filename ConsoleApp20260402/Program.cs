using System.Text;

namespace ConsoleApp20260402
{





    internal class Program
    {


        //delegate int op(int x, int y);
        //static op addFunc = (x, y) =>
        //{
        //    Console.WriteLine("Hello");
        //    return x + y;
        //};


        // Func 有返回值 但返回值只能是BOOL
        static Predicate<Person> isOld = (person) =>
        {
            return person.Age > 60;
        };

        // Action 无返回值
        static Action<string> printMessage = (message) =>
        {
            Console.WriteLine(message);
        };

        // Func 有返回值
        static Func<int, int, int> addFunc = (x, y) =>
        {
            Console.WriteLine("Hello");
            return x + y;
        };

        static Func<string, int> getLength = (s) =>
        {
            Console.WriteLine("Getting length of string: " + s);
            return s.Length;
        };

        static Func<string, int, string> repeat = (info, count) =>
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(info);
            }
            return stringBuilder.ToString();
        };

        //struct string repeat(string info, int count)
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    for (int i = 0; i < count; i++)
        //    {
        //        stringBuilder.Append(info);
        //    }
        //    return stringBuilder.ToString();
        //}

        static int add(int x, int y)
        {
            return x + y;
        }

        //static int add2(int x, int y)
        //{
        //    return x + y + 1;
        //}


        



        static void Main(string[] args)
        {
            //var person = new Person();
            //person.Name = "Alice";
            //person.Age = 332;
            //Console.WriteLine(person);

            //var age = 10;
            //var name = "lisi";
            //Console.WriteLine(age);
            //Console.WriteLine(name);

            //op addFunc = add2;
            //addFunc = add;


            Console.WriteLine(addFunc(23, 6));
            Console.WriteLine(getLength("Hello"));
            Console.WriteLine(repeat("-", 30));
            Console.WriteLine(isOld(new Person { Age = 32 }));
        }
    }
}
