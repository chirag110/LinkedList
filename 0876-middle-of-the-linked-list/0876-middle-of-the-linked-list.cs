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
