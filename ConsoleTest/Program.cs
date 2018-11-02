using GameMaker.Data;
using GameMaker.Data.Type;
using System;
using System.Collections.Generic;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DataManager dm = DataManager.New("c:\tmp\test");
            DataManager.Save(dm);

            /*
            VariableList vl = new VariableList();
            vl["a.t1"] = new Number(15, 0, 10);
            vl["a.t2"] = new Number(16, 20, 30);
            vl["a.t4"] = new Enumerator("option1", new List<string> { "option1", "option2", "option3" });
            vl["aa.t3"] = new Number(17, 0, 30);
            vl["aa.t4"] = new Number(18);
            vl["a.name"] = new Text("Paco");
            vl["a.text"] = new Text("Test {.name} {aa.t3}");
            vl["a.bool"] = new Bool(true);

            VariableList.CloneObject("a", "b");

            PrintVariables(vl);
            Console.WriteLine("...");
            PrintVariables(new VariableList("a"));
            Console.WriteLine("...");
            PrintVariables(new VariableList("aa"));
            Console.WriteLine("...");
            PrintVariables(new VariableList("b"));
            Console.WriteLine("...");
            */
            Console.ReadKey();
        }

    }
}
