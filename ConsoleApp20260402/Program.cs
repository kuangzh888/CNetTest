using System.Diagnostics.Tracing;
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


            //Console.WriteLine(addFunc(23, 6));
            //Console.WriteLine(getLength("Hello"));
            //Console.WriteLine(repeat("-", 30));
            //Console.WriteLine(isOld(new Person { Age = 32 }));



            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            //// LingQ 接受的参数都是Lamada表达式
            //var evenNumbers = list.Where(x => x % 2 == 0).Select(x => x * 10);
            //foreach (var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}




            //List<int> lst = [1, 2, 3, 4, 5, 5, 5, 5];
            //HashSet<int> set = lst.ToHashSet();
            //Console.WriteLine(set);



            //List<Person> list = new List<Person>();
            //list.Add(new Person { Name = "Alice", Age = 30 });
            //list.Add(new Person { Name = "Bob", Age = 65 });
            //list.Add(new Person { Name = "Charlie", Age = 21 
            //List<string> userList = list.Where(x => x.Age < 35).OrderByDescending(p => p.Name).Select(p => p.Name).ToList();
            //Console.WriteLine(string.Join(' ', userList));



            //IEnumerable<int> enumerable = Enumerable.Range(1, 10);
            //foreach (int x in enumerable)
            //{
            //    Console.WriteLine(x);
            //}


            //List<Person> people = Enumerable.Range(1, 10).Select(x =>
            //{
            //    var person = new Person { Name = "zhangsan" + x, Age = x };
            //    return person;
            //}).ToList();
            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person);
            //}


            //IEnumerable<int> enumerable = Enumerable.Range(1, 10);
            //int count = enumerable.Count();
            //Console.WriteLine(count);

            //Random random = new Random();
            //List<Person> personList = Enumerable.Range(1, 10).Select(x =>
            //{
            //    var person = new Person { Name = "zhangsan" + x, Age = x, Deptno = random.Next(3) + 1 };
            //    return person;
            //}).ToList();

            //IEnumerable<IGrouping<int, Person>> enumerable = personList.GroupBy(p => p.Deptno);
            //foreach (IGrouping<int, Person> group in enumerable)
            //{
            //    Console.WriteLine("Deptno: " + group.Key);
            //    foreach (Person person in group)
            //    {
            //        Console.WriteLine(person);
            //    }
            //}


            // 转字典
            //Random random = new Random();
            //List<Person> personList = Enumerable.Range(1, 10).Select(x =>
            //{
            //    var person = new Person { Name = "zhangsan" + x, Age = x, Deptno = random.Next(3) + 1 };
            //    return person;
            //}).ToList();

            //Dictionary<string, int> dictionary = personList.ToDictionary(p => p.Name, p => p.Age);
            //foreach (var kv in dictionary)
            //{
            //    Console.WriteLine(kv.Key + ": " + kv.Value);
            //}



            //// 分组转字典
            //Random random = new Random();
            //List<Person> personList = Enumerable.Range(1, 10).Select(x =>
            //{
            //    var person = new Person { Name = "zhangsan" + x, Age = x, Deptno = random.Next(3) + 1 };
            //    return person;
            //}).ToList();
            //Dictionary<int, List<Person>> dictionary = personList.GroupBy(p => p.Deptno).ToDictionary(g => g.Key, g => g.ToList());
            //foreach (var kv in dictionary)
            //{
            //    Console.WriteLine("Deptno: " + kv.Key);
            //    foreach (Person person in kv.Value)
            //    {
            //        Console.WriteLine(person);
            //    }
            //}

            string info = "this is a book that is a is";
            string[] arr = info.Split(' ');
            Dictionary<string, string[]> dictionary = arr.GroupBy(word => word).ToDictionary(g => g.Key, static g => g.ToArray());
            foreach (var kv in dictionary)
            {
                Console.WriteLine($"Key: {kv.Key}, Words: {string.Join(", ", kv.Value)}");
            }

            int count = info.WordCount();
            Console.WriteLine("Word count: " + count);


            Console.WriteLine($"{arr.ToStr()}");
        }



        static void demo1()
        {
            string input = Console.ReadLine();
            string[] t = input.Split(' ');

            int num1 = int.Parse(t[0]);
            int num2 = int.Parse(t[1]);
            int max = int.Parse(t[2]);


            List<int> news = new List<int>();
            news.Add(num1);
            news.Add(num2);

            int index = 0;
            while (news.Count < max)
            {
                int newInt = news[index] * news[index + 1];

                if (newInt > 10)
                {
                    int n1 = newInt / 10;
                    int n2 = newInt % 10;
                    //Console.WriteLine("n1 = " + n1);
                    //Console.WriteLine("n2 = " + n2);

                    news.Add(n1);
                    news.Add(n2);
                }
                else
                {
                    news.Add(newInt);
                }
                index++;
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write(news[i] + " ");
            }
        }

        static void demo2()
        {
            string input = Console.ReadLine();
            string[] t = input.Split(' ');
            string year = t[0];
            int yearInt = int.Parse(year);

            int bxNum = int.Parse(t[1]);
            int index = 0;
            while (true)
            {
                index++;
                int cuYear = yearInt + index;
                char[] arr = cuYear.ToString().ToCharArray();
                HashSet<int> set = new HashSet<int>();
                foreach (char item in arr)
                {
                    set.Add(int.Parse(item.ToString()));
                }
                if (set.Count == bxNum)
                {
                    Console.Write($"{index} {cuYear}");
                    break;
                }
            }
        }

        //static void demo3()
        //{
        //    string nStr = Console.ReadLine();
        //    int n = int.Parse(nStr);
        //    string pStr = Console.ReadLine();
        //    string[] p = pStr.Split(' ');
        //    int[] intP = Array.ConvertAll(p, int.Parse);

        //    List<Dictionary<int, bool>> weiAll = new List<Dictionary<int, bool>>();
        //    for (int j = 0; j < 20; j++)
        //    {
        //        Dictionary<int, bool> wei1 = new Dictionary<int, bool>();
        //        for (int i = 0; i < 5; i++)
        //        {
        //            wei1[j * 5 + i + 1] = false;
        //        }
        //        weiAll.Add(wei1);
        //    }
        //    List<List<int>> tempOut = new List<List<int>>();
        //    for (int i = 0; i < intP.Length; i++)
        //    {
        //        int pp = intP[i];
        //        List<int> papi = new List<int>();
        //        foreach (var dics in weiAll)
        //        {
        //            int nullCount = dics.Values.Where(x => x == false).Count();
        //            if (nullCount >= pp)
        //            {
        //                int hasp = 0;
        //                foreach (var dic in dics)
        //                {
        //                    if (dic.Value == false)
        //                    {
        //                        dics[dic.Key] = true;
        //                        papi.Add(dic.Key);
        //                        hasp++;
        //                        if (hasp >= pp) break;
        //                    }
        //                }
        //                tempOut.Add(papi);
        //                break;
        //            }
        //        }
        //    }
        //    foreach (var dics in tempOut)
        //    {
        //        foreach (var dic in dics)
        //        {
        //            Console.Write(dic + " ");
        //        }
        //        Console.Write('\n');
        //    }
        //}
        static void demo3()
        {
            string n = Console.ReadLine();
            string p = Console.ReadLine();
            string[] list = p.Split(' ');

            // 制作票数据源
            List<Dictionary<string, int>> tickList = new List<Dictionary<string, int>>();
            for (int i = 1; i <= 100; i++)
            {
                tickList.Add(new Dictionary<string, int> { { "num", i }, { "fand", 0 } });
            }

            // 遍历购买座位数量 2 5 4 2
            foreach (string item in list)
            {
                int num = int.Parse(item);
                StringBuilder sb = new StringBuilder();

                // 循环购买座位数量
                for (int i = 0; i < num; i++)
                {
                    // 找票
                    for (int j = 0; j < tickList.Count; j++)
                    {
                        Dictionary<string, int> dict = tickList[j];
                        if (dict["fand"] == 0)
                        {

                            if (num == 5)
                            {

                            }


                            sb.Append(tickList[j]["num"]);
                            dict["fand"] = 1;
                        }

                        if (sb.Length == num)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine(sb);
            }



            foreach (var kv in tickList)
            {
                Console.Write(kv["num"] + ":" + kv["fand"] + " ");
            }
        }
    }
}
