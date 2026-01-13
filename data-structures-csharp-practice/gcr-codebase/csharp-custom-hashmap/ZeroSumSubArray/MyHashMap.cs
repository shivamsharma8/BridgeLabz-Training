using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.HashMapHashSet.ZeroSumSubArray
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

        public V Get(K key)
        {
            int index = GetBucketIndex(key);
            Node head = buckets[index];
            while (head != null)
            {
                if (head.Key.Equals(key)) return head.Value;
                head = head.Next;
            }
            return default(V);
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
        

        public static void Solve(int[] arr)
        {
            MyHashMap<int, List<int>> hashMap = new MyHashMap<int, List<int>>();
            int sum = 0;

            List<int> initial = new List<int>();
            initial.Add(-1);
            hashMap.Put(0, initial);

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (hashMap.ContainsKey(sum))
                {
                    List<int> indices = hashMap.Get(sum);
                    foreach (int index in indices)
                    {
                        Console.WriteLine("Subarray found from index " + (index + 1) + " to " + i);
                    }
                    indices.Add(i);
                    hashMap.Put(sum, indices);
                }
                else
                {
                    List<int> newIndices = new List<int>();
                    newIndices.Add(i);
                    hashMap.Put(sum, newIndices);
                }
            }
        }
    }
}
