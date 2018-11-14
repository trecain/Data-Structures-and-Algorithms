using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {
        /// <summary>
        /// creates the hashtable using nodes similar to a linkedlist
        /// </summary>
        public Node[] HashTable { get; set; }

        public Hashtable(int buckets)
        {
            // uses the amount of buckets to set the array size
            HashTable = new Node[buckets];
        }


        /// <summary>
        /// adds a node to the hashtable and sets the key and value pair properties on the node
        /// </summary>
        /// <param name="key">key to look up</param>
        /// <param name="value">value to grab</param>
        public void Add(string key, object value)
        {
            // uses the hash method to generate the Nodes hash value
            int hash = GetHash(key);
            // sets property to the proper index in the Hashtable array
            Node bucketToPlaceHash = HashTable[hash];
            // value to break out of the if statement
    
            while (bucketToPlaceHash != null)
            {
                if (bucketToPlaceHash.Key == key)
                {
                    bucketToPlaceHash.Value = value;
                    return;
                } 
                bucketToPlaceHash = bucketToPlaceHash.Next;
            }
                Node newEntry = new Node(key, value);
                newEntry.Next = HashTable[hash];
                HashTable[hash] = newEntry;
        }


        /// <summary>
        /// gets a value from a key
        /// </summary>
        /// <param name="key">key to search for in the hashtable</param>
        /// <returns></returns>
        public object Find(string key)
        {
            int hash = GetHash(key);
            Node bucketToPlaceHash = HashTable[hash];
            while (bucketToPlaceHash != null)
            {
                if (bucketToPlaceHash.Key == key)
                    return bucketToPlaceHash.Value;
                bucketToPlaceHash = bucketToPlaceHash.Next;
            }
            return null;
        }


        /// <summary>
        /// returns a bool if key is in the hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <returns>key to search for node in hashtable</returns>
        public bool Contains(string key)
        {
            int hash = GetHash(key);
            Node bucketToPlaceHash = HashTable[hash];
            while (bucketToPlaceHash != null)
            {
                if (bucketToPlaceHash.Key == key)
                    return true;
                bucketToPlaceHash = bucketToPlaceHash.Next;
            }
            return false;
        }


        /// <summary>
        /// determines and sets the key of or key/value pair
        /// </summary>
        /// <param name="key">key to loop through to add up char values</param>
        /// <returns></returns>
        public int GetHash(string key)
        {
            int hash = 0;
            foreach(int i in key)
            {
                hash += i;
            }
            return hash % HashTable.Length;
        }
    }
}
