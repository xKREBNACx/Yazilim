using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> yemekler = new MyDictionary<string>();
            yemekler.Add("makarna");
            yemekler.Add("Orkide");
        }
    }
}
