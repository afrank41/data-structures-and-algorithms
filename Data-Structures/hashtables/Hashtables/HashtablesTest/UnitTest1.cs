using System;
using Xunit;
using Hashtables.Classes;

namespace HashtablesTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Determines whether this instance [can add to hash table].
        /// </summary>
        [Fact]
        public void CanAddToHashTable()
        {
            HashTable table = new HashTable();
            table.Add("cat", "cat");

            Assert.Equal("cat", table.Find("cat"));
        }

        /// <summary>
        /// Determines whether this instance [can check if hash table contains key].
        /// </summary>
        [Fact]
        public void CanCheckIfHashTableContainsKey()
        {
            HashTable table = new HashTable();
            table.Add("cat", "cat");

            Assert.True(table.Contains("cat"));
        }

        /// <summary>
        /// Determines whether this instance [can find collision in hash table].
        /// </summary>
        [Fact]
        public void CanFindCollisionInHashTable()
        {
            HashTable table = new HashTable();
            table.Add("dog", "dog");
            table.Add("god", "god");

            Assert.Equal("god", table.Find("god"));
        }

        /// <summary>
        /// Determines whether this instance [can check if hash table contains collision].
        /// </summary>
        [Fact]
        public void CanCheckIfHashTableContainsCollision()
        {
            HashTable table = new HashTable();
            table.Add("dog", "dog");
            table.Add("god", "god");

            Assert.True(table.Contains("god"));
        }
    }
}
