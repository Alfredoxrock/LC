using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


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
        
    }
}
