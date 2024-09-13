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

//Iterative Approach
// The iterative approach uses three pointers to reverse the linked list: prev, current, and next. Here's the step-by-step breakdown:

// Initialize prev to null and current to head.
// Traverse the linked list while current is not null.
// At each step:
// Save current.next in next.
// Reverse the pointer by setting current.next to prev.
// Move prev to current and current to next.
// After the loop, prev will point to the new head of the reversed linked list.

// Time and Space Complexity
// Time Complexity: O(n), where n is the number of nodes in the linked list. We traverse the list once.
// Space Complexity: O(1), since we only use a few pointers for the reversal.


public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;
        
        while (current != null) {
            ListNode next = current.next;  // Save next node
            current.next = prev;           // Reverse current node's pointer
            prev = current;                // Move prev to current node
            current = next;                // Move current to next node
        }
        
        return prev; // prev will be the new head
    }
}




//Approach 2

// Recursive Approach
// Explanation
// The recursive approach leverages the call stack to reverse the linked list. The base case is when the list is empty (head == null) or has only one node (head.next == null), which is trivially reversed.

// Recursively call ReverseList on the head.next node.
// Once the recursion reaches the end of the list, the rest of the list will be reversed.
// Set head.next.next to head to reverse the current link.
// Set head.next to null to avoid a cycle.
// Return the new head from the base case (the end of the original list).


// Time and Space Complexity
// Time Complexity: O(n), where n is the number of nodes in the linked list. We traverse the list once.
// Space Complexity: O(n), due to the recursive call stack.


// public class Solution {
//     public ListNode ReverseList(ListNode head) {
//         // Base case: If the list is empty or has only one node
//         if (head == null || head.next == null) {
//             return head;
//         }
        
//         // Recursively reverse the rest of the list
//         ListNode newHead = ReverseList(head.next);
        
//         // Reverse the current node's pointer
//         head.next.next = head;
//         head.next = null;
        
//         return newHead;
//     }
// }





//Approach 3
// Using a Stack
// Explanation
// We can use a stack to reverse the linked list. This approach uses extra space to store the nodes and then rebuilds the list in reverse order.

// Traverse the list and push all nodes onto a stack.
// Pop nodes from the stack to reconstruct the list in reverse order.


// Time and Space Complexity
// Time Complexity: O(n), where n is the number of nodes in the linked list. We traverse the list twice (once for pushing and once for popping).
// Space Complexity: O(n), due to the stack storing all nodes.

// using System.Collections.Generic;

// public class Solution {
//     public ListNode ReverseList(ListNode head) {
//         if (head == null) return null;
        
//         Stack<ListNode> stack = new Stack<ListNode>();
//         ListNode current = head;
        
//         // Step 1: Push all nodes onto the stack
//         while (current != null) {
//             stack.Push(current);
//             current = current.next;
//         }

//         // Step 2: Pop nodes from the stack and rebuild the list
//         ListNode newHead = stack.Pop();
//         current = newHead;

//         while (stack.Count > 0) {
//             current.next = stack.Pop();
//             current = current.next;
//         }

//         current.next = null; // Set the last node's next to null
//         return newHead;
//     }
// }


