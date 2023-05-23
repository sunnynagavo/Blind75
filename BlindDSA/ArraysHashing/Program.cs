// See https://aka.ms/new-console-template for more information
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine( "Welcome to the arrays and hashing topics in blind 75");
Console.WriteLine("------------------------------------------------------------");

// Arrays
// 1. Contains Duplicate
// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
int[] nums = { 1, 2, 3, 4 };
Console.WriteLine($"This array contains duplicate { ContainsDuplicate(nums) }" );
static bool ContainsDuplicate(int[] nums)
{
    HashSet<int> set = new HashSet<int>();

    foreach(int num in nums)
    {
        if (set.Contains(num))
        {
            return true;
        }
        set.Add(num);
    }
    return false;
}


Console.ReadLine();
