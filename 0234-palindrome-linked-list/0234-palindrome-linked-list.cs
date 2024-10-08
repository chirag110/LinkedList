/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

//Approach 1
// Two-Pointer (Reverse the Second Half) Approach
// Explanation
// Use two pointers (slow and fast) to find the middle of the linked list. The slow pointer moves one step at a time, while the fast pointer moves two steps.
// Once the fast pointer reaches the end, the slow pointer will be at the middle.
// Reverse the second half of the linked list starting from the slow pointer.
// Compare the first half with the reversed second half. If they are identical, the linked list is a palindrome.

// Time and Space Complexity
// Time Complexity: O(n), where n is the number of nodes in the linked list. We traverse the list a few times (to find the middle, to reverse the second half, and to compare).
// Space Complexity: O(1), since we only use a few pointers and do not require additional data structures.

public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null || head.next == null) return true;
        
        // Step 1: Find the middle of the linked list
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        // Step 2: Reverse the second half of the linked list
        ListNode secondHalfStart = ReverseList(slow);

        // Step 3: Compare the first and second halves
        ListNode firstHalfStart = head;
        while (secondHalfStart != null) {
            if (firstHalfStart.val != secondHalfStart.val) {
                return false;
            }
            firstHalfStart = firstHalfStart.next;
            secondHalfStart = secondHalfStart.next;
        }

        return true;
    }

    private ListNode ReverseList(ListNode head) {
        ListNode prev = null, current = head, next = null;
        while (current != null) {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
}





//Approach 2

// Using a Stack
// Explanation
// Traverse the linked list and push the values of each node onto a stack.
// Traverse the linked list again and pop elements from the stack. Compare the popped value with the current node value.
// If all values match, then the linked list is a palindrome.

// Time and Space Complexity
// Time Complexity: O(n), where n is the number of nodes in the linked list. We make two passes through the list.
// Space Complexity: O(n), due to the stack storing all node values.


// using System.Collections.Generic;

// public class Solution {
//     public bool IsPalindrome(ListNode head) {
//         if (head == null || head.next == null) return true;

//         // Step 1: Push all values onto a stack
//         Stack<int> stack = new Stack<int>();
//         ListNode current = head;
//         while (current != null) {
//             stack.Push(current.val);
//             current = current.next;
//         }

//         // Step 2: Compare values while popping from the stack
//         current = head;
//         while (current != null) {
//             if (current.val != stack.Pop()) {
//                 return false;
//             }
//             current = current.next;
//         }

//         return true;
//     }
// }







// Approach 3
//     . Using a Fast and Slow Pointer with a List
// Explanation
// Use two pointers (slow and fast) to traverse the linked list.
// Push the slow pointer values to a list.
// When the fast pointer reaches the end, the slow pointer will be at the middle.
// Continue moving the slow pointer while popping values from the list and comparing them to check if the list is a palindrome.


// Time and Space Complexity
// Time Complexity: O(n), where n is the number of nodes in the linked list. We traverse the list twice.
// Space Complexity: O(n), due to the list storing half of the node values.





// using System.Collections.Generic;

// public class Solution {
//     public bool IsPalindrome(ListNode head) {
//         if (head == null || head.next == null) return true;

//         List<int> vals = new List<int>();
//         ListNode slow = head, fast = head;

//         // Step 1: Push first half of the values to the list
//         while (fast != null && fast.next != null) {
//             vals.Add(slow.val);
//             slow = slow.next;
//             fast = fast.next.next;
//         }

//         // If the list has odd number of elements, skip the middle element
//         if (fast != null) {
//             slow = slow.next;
//         }

//         // Step 2: Compare the values in reverse order
//         for (int i = vals.Count - 1; i >= 0; i--) {
//             if (vals[i] != slow.val) {
//                 return false;
//             }
//             slow = slow.next;
//         }

//         return true;
//     }
// }





//Approach 4
// Recursive Approach
// Explanation
// Use recursion to traverse to the end of the linked list and then check if the values match in reverse order as you return back from the recursive calls.


// Time and Space Complexity
// Time Complexity: O(n), where n is the number of nodes in the linked list. We traverse the list once.
// Space Complexity: O(n), due to the recursive call stack.




// public class Solution {
//     private ListNode frontPointer;

//     public bool IsPalindrome(ListNode head) {
//         frontPointer = head;
//         return RecursivelyCheck(head);
//     }

//     private bool RecursivelyCheck(ListNode currentNode) {
//         if (currentNode == null) return true;

//         bool isPalindrome = RecursivelyCheck(currentNode.next) && (frontPointer.val == currentNode.val);

//         frontPointer = frontPointer.next;
//         return isPalindrome;
//     }
// }

