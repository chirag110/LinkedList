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





//-------------------------------------------------------------------------------------------------------------------------

// Approach 2: Two-Pointer Swap Method
// In this approach, we use two pointers that traverse both linked lists. Once a pointer reaches the end of a list, it switches to the beginning of the other list. This ensures that the two pointers will meet at the intersection after at most two full traversals of the lists.



// Explanation:
// Two Pointers: Start two pointers at the heads of both lists.
// Switch Lists: When a pointer reaches the end of a list, switch it to the head of the other list.
// Meet at Intersection: If there is an intersection, the two pointers will meet at the same node. If not, they will both reach the end (null) at the same time.
// Time Complexity:
// O(n + m) where n and m are the lengths of the two lists. Each pointer traverses each list at most once.
// Space Complexity:
// O(1) as no extra space is used except for the two pointers.



// public class Solution {
//     public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
//         if (headA == null || headB == null) return null;

//         ListNode pointerA = headA;
//         ListNode pointerB = headB;

//         while (pointerA != pointerB) {
//             // Move each pointer to the other list after reaching the end
//             pointerA = (pointerA == null) ? headB : pointerA.next;
//             pointerB = (pointerB == null) ? headA : pointerB.next;
//         }

//         return pointerA; // Either both are null or they meet at the intersection node
//     }
// }






//-------------------------------------------------------------------------------------------------------------------------
// Approach 3: HashSet Method
// We can use a HashSet to store the nodes of one list while traversing it. Then, we traverse the second list, checking if any node is already present in the HashSet. The first common node is the intersection



// Explanation:
// HashSet Storage: Traverse the first list and store each node in a HashSet.
// Check Second List: Traverse the second list and check if any node is already in the HashSet.
// Return the first node that appears in the HashSet as the intersection.
// Time Complexity:
// O(n + m) where n and m are the lengths of the two lists. We traverse both lists once.
// Space Complexity:
// O(n) where n is the length of the first list, as we store its nodes in a HashSet.


// using System.Collections.Generic;

// public class Solution {
//     public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
//         HashSet<ListNode> visitedNodes = new HashSet<ListNode>();

//         // Store nodes of list A in a HashSet
//         ListNode current = headA;
//         while (current != null) {
//             visitedNodes.Add(current);
//             current = current.next;
//         }

//         // Traverse list B and check for intersection
//         current = headB;
//         while (current != null) {
//             if (visitedNodes.Contains(current)) {
//                 return current;
//             }
//             current = current.next;
//         }

//         return null; // No intersection
//     }
// }





//---------------------------------------------Conclusion------------------------------------------------------------------
// 1.)Length Difference Method (Approach 1) and Two-Pointer Swap Method (Approach 2) have O(1) space complexity, making them the most efficient in terms of space.
// 2.)The HashSet Method (Approach 3) is less efficient in terms of space, but it is conceptually simpler.
// 3.)Approach 2 is usually preferred because it is more elegant and doesn’t require calculating the length or storing any extra nodes.
// For most cases, Approach 2 (Two-Pointer Swap) is the optimal approach due to its simplicity and space efficiency.


