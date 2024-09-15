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

// Iterative Bit Manipulation
// The most efficient way is to treat the binary number as a stream of bits and keep updating the result by shifting the bits left (multiplying the current result by 2) and adding the current node's value. This is like building the binary number from left to right.

// Explanation:
// Initialize result = 0.
// Traverse the linked list.
// For each node, left shift result by 1 position (result << 1) and add the current node's value (result | head.val).
// Repeat the process until all nodes are processed.
// Time Complexity:
// O(n) where n is the number of nodes in the linked list. We iterate through the list once.
// Space Complexity:
// O(1) because we are using a constant amount of extra space, regardless of the input size (ignoring input size storage).


public class Solution {
    public int GetDecimalValue(ListNode head) {
        int result = 0;
        while (head != null) {
            result = (result << 1) | head.val;
            head = head.next;
        }
        return result;
    }
}

//-------------------------------------------------------------------------------------------------------------------------
//Approach 2

// Convert Binary to String and Then to Integer
// Another approach is to traverse the linked list, collect the binary digits as a string, and then convert that string to an integer using C#'s built-in Convert.ToInt32 method.
