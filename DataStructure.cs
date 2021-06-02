using System;
using System.Collections;
using System.Collections.Generic;


namespace Programs
{
    class DataStructure
    {
        public void CheckDataStructure()
        {


            // Data types
            // *** Array
            int[] arrayInt = new int[4] { -1, 0,1,2 };
            string[] arrayString = { "Apple","Dog", "Elephant", "Boy", "Cat" };
            ArrayList arrayListInt = new ArrayList();
            Console.WriteLine("*********Array OutPut***************** \n");
            Array.ForEach(arrayString, Console.WriteLine);
            Console.WriteLine(" \n");
            Array.Sort(arrayString);
            var copyofArray = new string[8];
            Array.Copy(arrayString, copyofArray, arrayString.Length);
            Console.WriteLine("Print sorted using String.Join: " + String.Join(",", copyofArray) + "\n");
            
            // *** Array
            
            // *** Hashtable
            Hashtable hashTableInt = new Hashtable();
            hashTableInt.Add("Tom", 150);
            hashTableInt.Add("Harry", 180);
            hashTableInt.Add("Ashley", 130);
            hashTableInt.Add("Daniel", 170);
            Console.WriteLine("*********Hashtable OutPut****\n");
            
            Console.WriteLine("Tom's hight: {0} Item Count: {1}", hashTableInt["Tom"], hashTableInt.Count);
            hashTableInt.Remove("Daniel");
            Console.WriteLine("Harry hight: {0} Item Count: {1}", hashTableInt["Harry"], hashTableInt.Count);
            Console.WriteLine("Contains Daniel: {0}", hashTableInt.Contains("Daniel"));
            // *** Hashtable

            // *** List
            List<int> gListInt = new List<int>();
            gListInt.Add(1);
            gListInt.Add(2);
            gListInt.Add(3);
            gListInt.Add(4);
            gListInt.AddRange(arrayInt);
            gListInt.Reverse();
            Console.WriteLine("*********List OutPut**** \n");
            Console.WriteLine("Unsorted List: " + String.Join(",", gListInt));
            gListInt.Sort();
            Console.WriteLine("Sorted List: " + String.Join(",", gListInt));
            Console.WriteLine("Contains 1: " + gListInt.Contains(1) + " Item Count:" + gListInt.Count);
            // *** List

            // *** LinkedList
            LinkedList<int> linkedListInt = new LinkedList<int>();
            LinkedListNode<int> nodeInt = new LinkedListNode<int>(10);

            linkedListInt.AddFirst(nodeInt);
            nodeInt = new LinkedListNode<int>(20);
            linkedListInt.AddLast(nodeInt);
            LinkedListNode<int> nodeNewInt = new LinkedListNode<int>(30);
            linkedListInt.AddAfter(nodeInt, nodeNewInt);
            var nodePrev = nodeInt.Previous;
            Console.WriteLine("*********linkedList OutPut****\n");

            Console.WriteLine("Contains:" + linkedListInt.Contains(10) + " Prev Node:" + nodePrev.Value + " ListCount:" + linkedListInt.Count);
            linkedListInt.CopyTo(arrayInt, 0);
            Array.ForEach(arrayInt, Console.WriteLine);
            
            // *** LinkedList


            // *** Dictionary
            Dictionary<string, int> gDictionaryInt = new Dictionary<string, int>();
            gDictionaryInt.Add("Tom", 150);
            gDictionaryInt.Add("Harry", 180);
            gDictionaryInt.Add("Ashley", 130);
            gDictionaryInt.Add("Daniel", 170);
            Console.WriteLine("*********Dictionary OutPut****\n");

            Console.WriteLine("Tom's hight: {0} Item Count: {1}", gDictionaryInt["Tom"], gDictionaryInt.Count);
            gDictionaryInt.Remove("Daniel");
            Console.WriteLine("Harry hight: {0} Item Count: {1}", gDictionaryInt["Harry"], gDictionaryInt.Count);
            Console.WriteLine("Contains Daniel: {0}", gDictionaryInt.ContainsKey("Daniel"));

            // *** Dictionary

            // *** Stack
            Stack<int> gStackInt = new Stack<int>();
            gStackInt.Push(1);
            gStackInt.Push(3);
            gStackInt.Push(2);


            Console.WriteLine("*********Stack OutPut**** \n");
            // Displays the properties and values of the Stack.
            Console.WriteLine("myStack");
            Console.WriteLine("Count:    {0}", gStackInt.Count);
            Console.Write("Peek & Pop & Pop Values:{0} & {1}, {2}", gStackInt.Peek(), gStackInt.Pop(), gStackInt.Pop());

            // *** Stack

            // *** Queue
            Queue<int> gQueueInt = new Queue<int>();
            gQueueInt.Enqueue(3);
            gQueueInt.Enqueue(2);
            gQueueInt.Enqueue(1);
            
            Console.WriteLine("\n*********Queue OutPut****\n");
            Console.Write("Peek, Pop & Pop Values:{0} & {1}, {2}", gQueueInt.Peek(), gQueueInt.Dequeue(), gQueueInt.Dequeue());
            // *** Queue


        }

    }
}