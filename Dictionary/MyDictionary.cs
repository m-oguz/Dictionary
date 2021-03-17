using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<MyKey,MyValue>
    {
        
        MyKey[] keys;
        MyValue[] values;

        MyKey[] tempKeys;
        MyValue[] tempValues;


        public MyDictionary()
        {
            keys = new MyKey[0];
            values = new MyValue[0];
        }

        public void Add(MyKey theKey, MyValue theValue)
        { 
            
            tempKeys = keys;
            tempValues = values;
            
            
            keys = new MyKey[tempKeys.Length+1];
            values = new MyValue[tempValues.Length+1];

            for (int i = 0; i<tempKeys.Length;i++)
            {
                 keys[i] = tempKeys[i];
                 values[i] = tempValues[i];
            }
            keys[keys.Length-1] = theKey;
            values[values.Length-1] = theValue;
        }
        public void listTheKeys()
        {
            Console.WriteLine("The words that you can translate to Finnish:");
            Console.WriteLine("-----------------------------------------------");
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
        }
        
        public MyValue Get(MyKey key)
        {
            int j=keys.Length +1 ;
           for(int i=0; i < keys.Length; i++)
            {
                if(key.Equals(keys[i]))
                {
                    j = i;
                }
            }
            return values[j];
        }
    }
}
