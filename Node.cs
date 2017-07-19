namespace LinkedListApp
{
    class Node
    {
        // Contains an integer value in the linked list
        // Points to a specific node within the list
        // Last node will point to null
        public Node next;
        public int item;

        public Node()
        {
            next = null;
            item = 0;
        }

        public Node(int value)
        {
            next = null;
            item = value;
        }
    }
}
