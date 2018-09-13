using System;
﻿using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var myStack = new Stack();
            int n = 1;
            
            myStack.Push(n++);
            myStack.Push(n++);
            myStack.Push(n++);
            
            //myStack.Clear();
            
            while(myStack.myList.Count >0){
                int newInt = (int)myStack.Pop();
                Console.WriteLine(String.Format("Pop {0}!",newInt));
            }
            
            Console.WriteLine("Can't pop!  List is empty!");
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
            Console.WriteLine(String.Format("Push {0}!",myInteger));
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