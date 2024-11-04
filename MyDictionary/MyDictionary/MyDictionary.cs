using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, V>
    {
        T[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new T[0];
            values = new V[0];
        }

        public void Add(T Keys, V Values)
        {
            T[] tempKeys = keys;
            V[] tempValues = values;

            keys = new T[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = Keys;
            values[values.Length - 1] = Values;



        }

        public int keysLength
        {
            get { return keys.Length; }
        }

        public int valuesLength
        {
            get { return values.Length; }
        }



        public T[] Keys
        {
            get { return keys; }
        }

        public V[] Values
        {
            get { return values; }
        }

    }
}
