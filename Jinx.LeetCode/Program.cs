using Jinx.LeetCode.ProblemSet;
using Jinx.LeetCode.面试题;
using System;
using System.Reflection;

namespace Jinx.LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Statistics();
            ISolution test = new ProblemSet_037_解数独();
            test.Test();
        }

        static void Statistics()
        {
            Assembly _assembly = Assembly.Load("Jinx.LeetCode");

            Type[] _type_list = _assembly.GetTypes();

            for (int i = 0; i != _type_list.Length; i++)
            {
                if (_type_list[i].Namespace == "Jinx.LeetCode.ProblemSet")
                {
                    Console.WriteLine(_type_list[i].Name);

                    PropertyInfo[] pi = _type_list[i].GetProperties();
                    object obj = _assembly.CreateInstance($"{_type_list[i].Namespace}.{_type_list[i].Name}");
                    foreach (var item in pi)
                    {
                        Console.WriteLine(item.GetValue(obj));
                    }
                }
            }

        }
    }
}
