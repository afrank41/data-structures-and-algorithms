using System;
using Xunit;
using Hashtables.Classes;

namespace HashtablesTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddToHashTable()
        {
            HashTable table = new HashTable();
            table.Add("cat", "cat");

            Assert.Equal("cat", table.Find("cat"));
        }

        [Fact]
        public void CanCheckIfHashTableContainsKey()
        {
            HashTable table = new HashTable();
            table.Add("cat", "cat");

            Assert.True(table.Contains("cat"));
        }
    }
}
