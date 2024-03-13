using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAndResizableArray
{
    public class MyStackUsingResizableArray
    {
        int numberOfElementsInStack = 0;
        string[] stackArray;
        public MyStackUsingResizableArray() { 
            stackArray = new string[1];
        }
        public void push(string Item)
        {
            if(numberOfElementsInStack == stackArray.Length){
                Resize(2 * stackArray.Length);
            }
            stackArray[numberOfElementsInStack] = Item;
            numberOfElementsInStack++;
        }
        public void Resize(int capacity)
        {
            string[] copy = new string[capacity];
            for(int i = 0; i < numberOfElementsInStack; i++)
            {
                copy[i] = stackArray[i];
            }
            stackArray = copy;
        }
        public string Pop()
        {
            string item = stackArray[--numberOfElementsInStack];
            stackArray[numberOfElementsInStack] = null;
            if(numberOfElementsInStack > 0 && numberOfElementsInStack == stackArray.Length) {
                Resize(stackArray.Length / 2);
            }
            return item;
        }

    }
}
