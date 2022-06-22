﻿using System;
using System.Linq;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "bot", "apple", "apricot" };
            int minimalLength = words
            .Where(w => w.StartsWith("a"))
            .Min(w => w.Length);
            Console.WriteLine(minimalLength);

            Console.WriteLine("-----------------------------");

            int[] numbers = { 4, 7, 10 };
            int product = numbers.Aggregate(1, (int interim, int next) => interim * next);
            Console.WriteLine(product);   

            Console.WriteLine("-----------------------------");

            Func<string> greet = () => "Hello, World!";
            Console.WriteLine(greet());

            Console.WriteLine("-----------------------------");

            string name = Console.ReadLine() => Conslle.WriteLine("Hello" + name);


            Console.ReadKey();
        }

        //How to flatten a multi-level double-linked list
        public Node Flatten(Node head) {
        Stack<Node> myStack = new Stack<Node>();
        Node current = head;
        
        while(current != null){
            if(current.child != null){
                if(current.next != null){
                    myStack.Push(current.next);
                    current.next.prev = null;
                }
                 current.next = current.child;
                 current.child.prev = current;
                 current.child = null;
            }
            if(current.next != null){
                current = current.next;
            }
            else{
                break;
            }
            
        }
        
        while(myStack.Count != 0){
            current.next = myStack.Peek();
            myStack.Pop();
            current.next.prev = current;
            while(current != null && current.next != null)
            {
                current = current.next;
            }
        }
        
        return head;
    }




/*
       public static bool HasCycle(ListNode head){
        if (head == null) return false;
        // Create a temporary node
        var slow = head;
        var fast = head.next;
        while (fast != null && fast.next != null){
            if (slow == fast) return true;
            slow = slow.next;
            fast = fast.next.next;
        }
        return false;
       }

       public ListNode DetectCycle(ListNode head) {
        if(head == null || head.next == null) return null;
        ListNode slow = head;
        ListNode fast = head;
        while( fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
            if(slow == fast) break;
        }
        
        if(fast == null || fast.next == null) return null;
        
        fast = head;
        
        while (fast != slow){
            fast = fast.next;cd de
            slow = slow.next;
        }
        
        return fast;
        
         }

         //My own answer

         public ListNode DetectCycle(ListNode head) {
        if(head == null || head.next == null) return null;
        ListNode slow = head;
        ListNode fast = head;
        while( fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
            if(slow == fast) break;
        }
        
        if(fast == null || fast.next == null) return null;
        
        /*fast = head;
        
        while (fast != slow){
            fast = fast.next;
            slow = slow.next;
        }
        
        return fast;*/

        /*
        
        ListNode origin = head;
        slow = slow.next;
        
        while(origin != slow)
        {
            if(slow == fast){
                slow = slow.next;
                origin = origin.next;
            }else{
                slow = slow.next;
            }
            
        }
        return origin;
        
        
    }

    public ListNode GetIntersectionNode(ListNode headA, ListNode headB){
        ListNode l1 = headA;
        ListNode l2 = headB;
        
        
        while(l1 != l2){
            if(l1 == null){
                l1 = headB;
            }
            if(l2 == null){
                l2 = headA;
            }
            if(l1 == l2) break;
            l1 = l1.next;
            l2 = l2.next;
        }
        return l1;
    }

    public ListNode RemoveNthFromEnd(ListNode head, int n){
        if(head == null) return null;
         
         ListNode start = new ListNode(-1);
         start.next = head;
         ListNode left = start;
         ListNode right = start;
       
        var numb = n + 1;
        
        
        while(right != null ){
            right = right.next;
            if(numb <= 0){
                left = left.next;
            }
             numb = numb - 1;
        }
        left.next = left.next.next;
        return start.next;
    }

    public ListNode ReverseList(ListNode head){
        ListNode previous = null;
        while(head != null){
            ListNode next = head.next;
            head.next = previous;
            previous = head; 
            head = next;
        }
        return previous;
    }

    public ListNode removeElements(ListNode head, int val) {
         while(head != null && head.val == val){
            head = head.next;
        }
        
        ListNode current = head;
        while(current != null && current.next != null){
            if(current.next.val == val){
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }
        
        return head;
    }
    */

        
    }
}
