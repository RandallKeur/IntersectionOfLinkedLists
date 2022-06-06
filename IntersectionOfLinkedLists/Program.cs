// See https://aka.ms/new-console-template for more information


//  Definition for singly-linked list.


class Program
{
    public static void Main(string[] args)
    {

        var solution = new Solution();

        var headA = solution.LoadList(new int[] { 4,1});
        
        var headB = solution.LoadList(new int[] { 5,6,1});

        var headC = solution.LoadList(new int[] { 8, 4, 5 });
        
        solution.AppendToList(headA, headC);
        //solution.PrintList(headA);
        solution.AppendToList(headB, headC);
        //solution.PrintList(headB);

        solution.GetIntersectionNode(headA, headB);
    }
}
