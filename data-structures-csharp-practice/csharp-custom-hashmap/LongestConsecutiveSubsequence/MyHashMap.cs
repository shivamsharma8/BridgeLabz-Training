using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.HashMapHashSet.LongestConsecutiveSubsequence
{
    public class MyHashMap<K, V>
    {
        public class Node
        {
            public K Key;
            public V Value;
            public Node Next;

            public Node(K key, V value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        private int capacity = 1000;
        private Node[] buckets;

        public MyHashMap()
        {
            buckets = new Node[capacity];
        }

        private int GetBucketIndex(K key)
        {
            int hashCode = key.GetHashCode();
            int index = hashCode % capacity;
            return Math.Abs(index);
        }

        public void Put(K key, V value)
        {
            int index = GetBucketIndex(key);
            Node head = buckets[index];
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    head.Value = value;
                    return;
                }
                head = head.Next;
            }
            Node newNode = new Node(key, value);
            newNode.Next = buckets[index];
            buckets[index] = newNode;
        }

        public bool ContainsKey(K key)
        {
            int index = GetBucketIndex(key);
            Node head = buckets[index];
            while (head != null)
            {
                if (head.Key.Equals(key)) return true;
                head = head.Next;
            }
            return false;
        }
        

        public int FindLongest(int[] arr)
        {
            MyHashMap<int, bool> hashMap = new MyHashMap<int, bool>();
            for (int i = 0; i < arr.Length; i++)
            {
                hashMap.Put(arr[i], true);
            }

            int longestStreak = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!hashMap.ContainsKey(arr[i] - 1))
                {
                    int currentNum = arr[i];
                    int currentStreak = 1;

                    while (hashMap.ContainsKey(currentNum + 1))
                    {
                        currentNum += 1;
                        currentStreak += 1;
                    }

                    if (currentStreak > longestStreak)
                    {
                        longestStreak = currentStreak;
                    }
                }
            }
            return longestStreak;
        }
    }
}
