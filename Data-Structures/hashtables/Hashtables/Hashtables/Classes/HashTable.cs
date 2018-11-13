using LinkedLists.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    class HashTable
    {
        LinkdList[] table = new LinkdList[1024];

        public int GetHash(string key)
        {
            int hashIndex = 0;
            foreach (char letter in key)
            {
                hashIndex += (int)letter;
            }

            hashIndex *= 601;
            hashIndex %= 1024;

            return hashIndex;
        }

        public void Add(string key, object value)
        {
            int index = GetHash(key);
            Node node = new Node(key, value);

            if (table[index] == null)
            {
                LinkdList list = new LinkdList(node);
                table[index] = list;
            }
            else
            {
                table[index].Append(node);
            }
        }

        public object Find(string key)
        {
            int index = GetHash(key);
            LinkdList list = table[index];

            if (list.Head.Key.ToString() == key) return list.Head.Value;
            else if (list.Head.Next != null)
            {
                while (list.Current.Next != null)
                {
                    if (list.Current.Key.ToString() == key) return list.Current.Value;
                }
            }

            return "Not Found";
        }
    }
}
