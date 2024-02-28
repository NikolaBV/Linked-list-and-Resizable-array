using LinkedListAndResizableArray;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyStackUsingLinkedList<object> list = new MyStackUsingLinkedList<object>();

            list.Push(1);
            list.Push("1");
            list.Push('c');
            list.Push(2.5);
        }
    }
}