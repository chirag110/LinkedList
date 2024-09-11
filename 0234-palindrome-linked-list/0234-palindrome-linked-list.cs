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
