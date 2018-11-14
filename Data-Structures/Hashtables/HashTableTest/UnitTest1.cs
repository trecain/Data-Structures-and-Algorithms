using System;
using Xunit;
using Hashtables.Classes;

namespace HashTableTest
{
    public class UnitTest1
    {
        /// <summary>
        /// can test a value can be added to the hashtable
        /// </summary>
        [Theory]
        [InlineData("Lebron", "James")]
        public void CanCheckInsertion(string key, object value)
        {
            Hashtable ht = new Hashtable(5);
            ht.Add(key, value);
            Assert.True(ht.Contains(key));
        }


        /// <summary>
        /// testing the contains method
        /// </summary>
        [Fact]
        public void ContainsMethodWorks()
        {
            Hashtable ht = new Hashtable(6);
            ht.Add("John", "Wall");
            ht.Add("Mike", "Jordan");
            Assert.True(ht.Contains("John"));
            Assert.False(ht.Contains("Kobe"));
        }


        /// <summary>
        /// can test the find method
        /// </summary>
        [Fact]
        public void CanFindValue()
        {
            Hashtable ht = new Hashtable(5);
            ht.Add("V", "W");
            ht.Add("W", "V");
            Assert.False(ht.Contains("D"));
        }
        
        
        /// <summary>
        /// can test for collision one
        /// </summary>
        [Fact]
        public void CanTestForCollisionOne()
        {
            Hashtable ht = new Hashtable(5);
            ht.Add("V", "W");
            ht.Add("W", "V");
            Assert.True(ht.Contains("W") && ht.Contains("V"));
        }


        /// <summary>
        /// can test for collision one
        /// </summary>
        [Fact]
        public void CanTestForCollisionTwo()
        {
            Hashtable ht = new Hashtable(5);
            ht.Add("RRR", "PPR");
            ht.Add("PPR", "RRR");
            Assert.True(ht.Find("RRR") != ht.Find("PPR"));
        }
    }
}
