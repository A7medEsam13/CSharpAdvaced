using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Generics
{
    public static class App
    {
        public static void Run()
        {
            MyDictionary<int, string> myDic = new MyDictionary<int, string>();
            myDic.Add(1, "one");
            myDic.Add(2, "two");

            Console.WriteLine(myDic.Get(1));
            Console.WriteLine(myDic.ContainsKey(3));

        }
         
        public class MyDictionary<TKey, TValue>
        {
            private Dictionary<TKey, TValue> _dictionary=new Dictionary<TKey, TValue>();

            public void Add(TKey key, TValue value)
            {
                _dictionary.Add(key, value);
            }
            public TValue Get(TKey key) => _dictionary[key];

            public string ContainsKey(TKey key) => _dictionary.ContainsKey(key) ? "True" : "False";
        }
            
            
            
    }
        

        

}

