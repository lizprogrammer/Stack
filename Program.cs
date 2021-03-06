﻿using System;
﻿using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack(); 
            stack.Push(1); 
            stack.Push(2); 
            stack.Push(3);
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop());
        }
    }
    class Stack
    {
        public List<Object> myList = new List<Object>();
        
        public Object Pop()
        {
            var myObject = new Object();
            //Console.WriteLine("Pop!");
            if(this.myList.Count > 0)
            {
                int lastItemIndex = this.myList.Count - 1;
                myObject = this.myList[lastItemIndex];
                myList.RemoveAt(lastItemIndex);
                return myObject;
            }    
            return null;
        }
        public void Push(int myInteger)
        {
            //Console.WriteLine(String.Format("Push {0}!",myInteger));
            this.myList.Add(myInteger);
        }    
        public void Clear()
        {
            myList.Clear();
            Console.WriteLine("Clear!");
        }           
    }
}

/*
Design a class called Stack with three methods.
void Push(object obj)
object Pop()
void Clear()
*/