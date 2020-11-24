using System;
using System.Collections.Generic;

namespace Programs
{
    public class Trees
    {
        // Do not edit the class below except
        // for the BreadthFirstSearch method.
        // Feel free to add new properties
        // and methods to the class.
        public class Node
        {
            public string name;
            public List<Node> children = new List<Node>();

            public Node(string name)
            {
                this.name = name;
            }

            public List<string> BreadthFirstSearch(List<string> array)
            {
                // Write your code here.
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(this);
                while (queue.Count > 0)
                {
                    Node current = queue.Dequeue();
                    array.Add(current.name);
                    current.children.ForEach(o => queue.Enqueue(o));
                }
                return array;
            }

            public Node AddChild(string name)
            {
                Node child = new Node(name);
                children.Add(child);
                return this;
            }
        }
    }
}