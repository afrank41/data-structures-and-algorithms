using LinkedLists.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class HashTable
    {
        LinkdList[] table = new LinkdList[1024];

        /// <summary>
        /// Gets the hash for the given key
        /// </summary>
        /// <param name="key">The key</param>
        /// <returns></returns>
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

        /// <summary>
        /// Adds the specified key.
        /// </summary>
        /// <param name="key">The key</param>
        /// <param name="value">The value</param>
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

        /// <summary>
        /// Finds the specified key value pair in a hash table
        /// </summary>
        /// <param name="key">The key</param>
        /// <returns>the value of the key value pair searched for</returns>
        public object Find(string key)
        {
            int index = GetHash(key);

            if (table[index] == null)
            {
                return "Not Found";
            }
            else if (table[index].Head.Key.ToString() == key)
            {
                return table[index].Head.Value;
            }
            else if (table[index].Head.Next != null)
            {
                while (table[index].Current != null)
                {
                    if (table[index].Current.Key.ToString() == key)
                    {
                        return table[index].Current.Value;
                    }

                    table[index].Current = table[index].Current.Next;
                }
            }

            return "Not Found";
        }

        /// <summary>
        /// Determines whether hash table contains the searched for key
        /// </summary>
        /// <param name="key">The key</param>
        /// <returns> true if hash table contains the key searched for</returns>
        public bool Contains(string key)
        {
            if (Find(key).ToString() == "Not Found")
            {
                return false;
            }

            return true;
        }
    }
}
