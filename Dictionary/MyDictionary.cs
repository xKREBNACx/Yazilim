using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T>
    {
        T[] yemekler;
       
        //constructer
        public MyDictionary()
        {
            yemekler = new T[0];
        }
        
        public void Add(T yemek)
        {

            T[] eskiyemekler=yemekler;
            yemekler = new T[yemekler.Length+1];
            for (int i = 0; i < eskiyemekler.Length; i++)
            {
                yemekler[i] = eskiyemekler[i];
            }

            yemekler[yemekler.Length - 1] = yemek;
            Console.WriteLine(yemek + "   Eklendi.");
            


            
           
        }
    }
}
