using System.ComponentModel.DataAnnotations;

public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var sizeA = GetListSize(headA);
        var sizeB = GetListSize(headB);

        var startingPoint = Math.Abs(sizeA - sizeB);

        var i = 0;

        while (i != startingPoint)
        {
            if (sizeA > sizeB)
            {
                headA = headA.next;
                i++;
            }
            else
            {
                headB = headB.next;
                i++;
            }
        }

        ListNode intersectionNode = null;
        var intersectionFlag = false;
        while (headA is not null || headB is not null)
        {
            if (headA == headB)
            {
                if (intersectionFlag == false)
                {
                    intersectionNode = headA;
                    intersectionFlag = true;                
                    //Console.WriteLine($"head A value is: {headA.val} and head B value is: {headB.val}");
                }
            }
            else
            {
                intersectionNode = null;
                intersectionFlag = false;
            }
            headA = headA.next;
            headB = headB.next;
        }

        return intersectionNode;
    }

    private int GetListSize(ListNode head)
    {
        var size = 0;
        while (head != null)
        {
            size++;
            head = head.next;
        }

        return size;
    }
    public ListNode LoadList(int[] values)
    {
        var head = new ListNode(values[0]);
        var previousNode = head;
        for (var i = 1; i < values.Length; i++)
        {
            
            var NewNode = new ListNode(values[i]);
            previousNode.next = NewNode;
            previousNode = NewNode;
        }

        return head;
    }

    public void AppendToList(ListNode head, ListNode addedHead)
    {
        while (head.next != null)
        {
            head = head.next;
        }
        head.next = addedHead;
    }

    public void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.WriteLine($"current value is: {head.val}");
            head = head.next;
        }
    }
}