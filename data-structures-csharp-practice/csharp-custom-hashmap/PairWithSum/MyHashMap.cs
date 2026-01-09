using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.HashMapHashSet.PairWithSum
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

        private int capacity = 100;
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


        public bool CheckPair(int[] arr, int target)
        {
            MyHashMap<int, int> hashMap = new MyHashMap<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (hashMap.ContainsKey(complement))
                {
                    return true;
                }
                hashMap.Put(arr[i], 1);
            }
            return false;
        }
    }
}
