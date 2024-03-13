using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAndResizableArray
{
    public class MyQueueUsingLinkedList<Item>
    {
        private Node<Item> first, last;
        public bool isEmpty()
        {
            return first == null;
        }
        public void Enqueue(Item item) {
            Node<Item> oldLast = last;
            last = new Node<Item>();
            last.item = item;
            last.next = null;

            if (isEmpty())
            {
                first = last;
            }
            else
            {
                oldLast.next = last;
            }
        }
        public Item Dequeue()
        {
            Item item = first.item;
            first = first.next;
            return item;
        }
    }
}
