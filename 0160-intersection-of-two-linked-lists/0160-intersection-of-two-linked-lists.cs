/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */


//Approach 1
// Length Difference Method (Two-Pointer Approach)
// The key observation here is that if two linked lists intersect, they must share the same tail after the intersection point. The idea is to calculate the length of both linked lists, then align them by skipping the extra nodes in the longer list. Once aligned, we can traverse both lists together until we find the intersection point.

// Explanation:
// Get Length: Calculate the lengths of both linked lists.
// Align the Lists: If one list is longer, move the pointer of the longer list forward to align both lists.
// Traverse Together: Move both pointers in tandem. When the pointers meet at the same node, return that node as the intersection point.
// If there is no intersection, return null.
// Time Complexity:
// O(n + m) where n and m are the lengths of the two lists. We compute the lengths first and then traverse the lists in tandem.
// Space Complexity:
// O(1) as only a constant amount of extra space is used.

public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int lenA = GetLength(headA);
        int lenB = GetLength(headB);
        
        // Align the starting point of both lists
        while (lenA > lenB) {
            headA = headA.next;
            lenA--;
        }
        while (lenB > lenA) {
            headB = headB.next;
            lenB--;
        }

        // Traverse both lists together to find the intersection
        while (headA != null && headB != null) {
            if (headA == headB) {
                return headA;
            }
            headA = headA.next;
            headB = headB.next;
        }

        return null; // No intersection
    }

    private int GetLength(ListNode head) {
        int length = 0;
        while (head != null) {
            length++;
            head = head.next;
        }
        return length;
    }
}
