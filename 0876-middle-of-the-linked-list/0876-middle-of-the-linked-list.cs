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
//https://www.youtube.com/watch?v=7LjQ57RqgEc&ab_channel=takeUforward
//https://www.youtube.com/watch?v=5blSG0JZNbg&t=100s&ab_channel=Fraz

//Approach 1 

//First, traverse the entire linked list to count the total number of nodes, n. Then, traverse the list again up to the middle index, n/2, to find the middle node.

//Time and Space Complexity
//Time Complexity: O(n), where n is the number of nodes in the linked list. We make two passes through the list.
//Space Complexity: O(1), since we only use a few variables.
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        int count = 0;
        ListNode current = head;

        // Count the number of nodes
        while (current != null) {
            count++;
            current = current.next;
        }

        // Find the middle node
        int middleIndex = count / 2;
        current = head;

        for (int i = 0; i < middleIndex; i++) {
            current = current.next;
        }

        return current;
    }
}

//Approach 2
//Convert the linked list into an array or list for easy access to the middle element. Then, return the middle element by accessing the index n/2.

//Time and Space Complexity
//Time Complexity: O(n), where n is the number of nodes in the linked list. We traverse the list once.
//Space Complexity: O(n), due to the storage required for the array or list.

// using System.Collections.Generic;

// public class Solution {
//     public ListNode MiddleNode(ListNode head) {
//         List<ListNode> nodes = new List<ListNode>();
//         ListNode current = head;

//         while (current != null) {
//             nodes.Add(current);
//             current = current.next;
//         }

//         return nodes[nodes.Count / 2];
//     }
// }






//Approach 3 


// We use two pointers, slow and fast. Both start at the head of the linked list. The slow pointer moves one step at a time, while the fast pointer moves two steps at a time. By the time the fast pointer reaches the end of the linked list, the slow pointer will be at the middle.

// Time and Space Complexity
// Time Complexity: O(n), where n is the number of nodes in the linked list. We traverse the list once.
// Space Complexity: O(1), since we are only using two pointers.

// public class Solution {
//     public ListNode MiddleNode(ListNode head) {
//         ListNode slow = head;
//         ListNode fast = head;
        
//         while (fast != null && fast.next != null) {
//             slow = slow.next;
//             fast = fast.next.next;
//         }
        
//         return slow;
//     }
// }

