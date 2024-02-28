using System.Collections;

namespace LinkedListAndResizableArray
{
    public class MyStackUsingLinkedList<Item> : IEnumerable<Item>
    {
        private Node<Item> first = null;

        public bool isEmpty()
        {
            return first == null;
        }
        public void Push(Item item)
        {
            Node<Item> oldFirst = first;
            first = new Node<Item>();
            first.item = item;
            first.next = oldFirst;
        }
        public Item Pop()
        {
            Item value = first.item;
            first = first.next;
            return value;
        }

        public IEnumerator<Item> GetEnumerator()
        {
            Node<Item> current = first;
            while (current != null)
            {
                yield return current.item;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
