using LinkedListAndResizableArray;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            MyStackUsingLinkedList<object> list = new MyStackUsingLinkedList<object>();

            list.Push(1);
            list.Push("1");
            list.Push('c');
            list.Push(2.5);

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }
          
            MyStackUsingResizableArray myStackUsingResizableArray = new MyStackUsingResizableArray();
            myStackUsingResizableArray.push("1");
            Console.WriteLine(myStackUsingResizableArray.Pop());
              */
            MyQueueUsingLinkedList<int> queue = new MyQueueUsingLinkedList<int>();
            queue.Enqueue(1);
            Console.WriteLine(queue.Dequeue());

        }
    }
}