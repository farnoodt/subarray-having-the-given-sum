// See https://aka.ms/new-console-template for more information
int[] nums = { 2, 6, 0, 9, 7, 3, 1, 4, 1, 10 };
int target = 15;

findSubarray(nums, target);


static void findSubarray(int[] nums, int target)
{
    int left = 0;
    int sum = 0;

    for (int right = 0; right < nums.Length; right++)
    {
        sum += nums[right];
        if(sum == target)
            Console.WriteLine(left + " - " + right);
        while (sum > target)
        {
            sum -= nums[left];
            
            left++;
            if (sum == target)
                Console.WriteLine(left + " - " + right);
        }
    }
}