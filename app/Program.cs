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
        
    }
}
