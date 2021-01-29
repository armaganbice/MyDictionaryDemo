using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
        class MyDictionary<TKey, TValue>
        {
            TKey[] _keys;          // Array Populated Generic type for Keys 
            TValue[] _values;      // Array Populated Generic type for Values

            public MyDictionary()  // Constructor Method for MyDictionary ( if new clause)
            {
                _keys = new TKey[0];       // _key arrays add one Tkey instance
                _values = new TValue[0];   // _values arrays add one Tvalue instance
            }

            public void Add(TKey key, TValue value)
            {
                TKey[] tempkeys = _keys;            // defined Temporary Keys array
                TValue[] tempValues = _values;      // defined Temporary Values array

                _keys = new TKey[_keys.Length + 1];         // defined New TKey  array
                _values = new TValue[_values.Length + 1];   // defined New TValue array

                for (int i = 0; i < tempkeys.Length; i++)
                {
                    _keys[i] = tempkeys[i];
                }
                for (int i = 0; i < tempValues.Length; i++)
                {
                    _values[i] = tempValues[i];
                }
                _keys[_keys.Length - 1] = key;
                _values[_values.Length - 1] = value;
            }
            public TKey[] Keys
            {
                get { return _keys; }
            }

            public TValue[] Values
            {
                get { return _values; }
            }

            public void List()
            {
                for (int i = 0; i < _keys.Length; i++)
                {
                    Console.WriteLine(_keys[i] + ":" + _values[i]);
                }
            }
        }
    }
