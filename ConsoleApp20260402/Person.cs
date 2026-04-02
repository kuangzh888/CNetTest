using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20260402
{
    internal class Person
    {
        // 默认 private
        //public string Name;
        //public int Age;


        private string name;
        private int age;
        public Person() { }

        public string Name { get => name; set => name = value; }
        //public int Age { get => age; set => age = value > 120 ? 120 : value; }

        public int Age { get => age; 
            set {
                if (value > 120)
                {
                    age = 120;
                } else
                {
                    age = value;
                }
            }
        }

        //public Person(string name, int age) {
        //    this.Name = name;
        //    this.Age = age;
        //}


        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
}
