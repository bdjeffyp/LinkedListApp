using System;

namespace LinkedListApp
{
    class SingleLinkedList
    {
        // Contains a collection of Nodes, with each node pointing to the next
        
        // This first node in the list
        private Node headNode = new Node();

        // Constructor
        // Each creates the initial node for the list.
        public SingleLinkedList()
        {
            headNode.next = null;
            headNode.item = 0;
        }

        public SingleLinkedList(int value)
        {
            headNode.next = null;
            headNode.item = value;
        }

        // Methods
        public void AddToEnd(int value)
        {
            // Places a new node onto the end of the list with the given value
            Node newNode = new Node(value);
            Node currentNode = Last();
            currentNode.next = newNode;
        }

        public Node Last()
        {
            // Finds the last node and returns it
            Node currentNode = headNode;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            return currentNode;
        }

        public Node Last(out int count)
        {
            // Finds the last node and returns it and how many steps it took
            Node currentNode = headNode;
            count = 0;

            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
                count++;
            }
            return currentNode;
        }

        public Node Find(int count)
        {
            // Retrieves the Node at the specified location
            Node currentNode = headNode;
            for (int i = 0; i <= count; i++)
            {
                currentNode = currentNode.next;
            }
            return currentNode;
        }

        public void PrintLine(Node aNode)
        {
            // Prints the value for the node given
            Console.WriteLine("{0}", aNode.item);
        }

        public void Print(Node aNode)
        {
            // Prints the value for the node given
            Console.Write("{0}", aNode.item);
        }
    }
}
