/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

//Approach 1
// Two-Pointer (Floyd's Tortoise and Hare) Approach
// Explanation
// This approach uses two pointers, slow and fast:

// Both pointers start at the head of the linked list.
// The slow pointer moves one step at a time, while the fast pointer moves two steps at a time.
// If there is a cycle, the fast pointer will eventually meet the slow pointer.
// If there is no cycle, the fast pointer will reach the end of the list (null).


// Time and Space Complexity
// Time Complexity: O(n), where n is the number of nodes in the linked list. In the worst case, the fast pointer may need to traverse the entire list.
// Space Complexity: O(1), since we are only using two pointers.


public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null || head.next == null) return false;

        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null) {
            slow = slow.next;          // Move slow pointer by 1 step
            fast = fast.next.next;     // Move fast pointer by 2 steps

            if (slow == fast) {        // Cycle detected
                return true;
            }
        }

        return false; // No cycle detected
    }
}




//Approach 2
// Using a HashSet
// Explanation
// Traverse the linked list.
// Store each visited node in a HashSet.
// If a node is encountered that is already in the HashSet, a cycle exists.
// If the traversal reaches the end (null), there is no cycle.

// Time and Space Complexity
// Time Complexity: O(n), where n is the number of nodes in the linked list. We traverse each node once.
// Space Complexity: O(n), due to the extra space required for the HashSet to store all nodes.

// using System.Collections.Generic;

// public class Solution {
//     public bool HasCycle(ListNode head) {
//         if (head == null) return false;

//         HashSet<ListNode> visitedNodes = new HashSet<ListNode>();
//         ListNode current = head;

//         while (current != null) {
//             if (visitedNodes.Contains(current)) { // Cycle detected
//                 return true;
//             }
//             visitedNodes.Add(current);
//             current = current.next;
//         }

//         return false; // No cycle detected
//     }
// }






//Approach 3


