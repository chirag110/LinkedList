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


// Explanation:
// Use a StringBuilder to collect the binary digits as a string while traversing the list.
// Convert the binary string to an integer using Convert.ToInt32(binaryStr, 2).
// Time Complexity:
// O(n) where n is the number of nodes. We traverse the list once to build the string.
// Space Complexity:
// O(n) because we are storing the binary digits as a string in a StringBuilder.


// public class Solution {
//     public int GetDecimalValue(ListNode head) {
//         StringBuilder binaryStr = new StringBuilder();
//         while (head != null) {
//             binaryStr.Append(head.val);
//             head = head.next;
//         }
//         return Convert.ToInt32(binaryStr.ToString(), 2);
//     }
// }




//-------------------------------------------------------------------------------------------------------------------------

//Approach 3
// Recursive Method
// We can also solve this problem recursively by computing the size of the linked list and then building the result from the most significant to the least significant bit.


// Explanation:
// First, compute the length of the linked list.
// Use recursion to compute the decimal value by converting each bit's position value and summing the results.
// Time Complexity:
// O(n) for calculating the length of the list and traversing the list recursively.
// Space Complexity:
// O(n) for the recursive call stack.



// public class Solution {
//     public int GetDecimalValue(ListNode head) {
//         int length = GetLength(head);
//         return ConvertToInteger(head, length - 1);
//     }

//     private int GetLength(ListNode head) {
//         int length = 0;
//         while (head != null) {
//             length++;
//             head = head.next;
//         }
//         return length;
//     }

//     private int ConvertToInteger(ListNode head, int position) {
//         if (head == null) return 0;
//         return (head.val << position) + ConvertToInteger(head.next, position - 1);
//     }
// }






//----------------------------------------------Conclusion---------------------------------------------------------------


// Conclusion:
// Iterative Bit Manipulation (Approach 1) is the most efficient in terms of both time and space.
// The String Conversion (Approach 2) is less space efficient because it uses extra memory to store the binary string.
// The Recursive Method (Approach 3) has the same time complexity as the others but is less efficient due to the recursive call stack.
// For most cases, Approach 1 is the best due to its simplicity and optimal space usage.

