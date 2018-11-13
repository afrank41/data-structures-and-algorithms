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
    }
}
