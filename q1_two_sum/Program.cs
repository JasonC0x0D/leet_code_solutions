int[] myNumbers = [1,2,3,8,9,10];
int myTarget = 18;

var myAns = TwoSum(myNumbers, myTarget);

Console.WriteLine($"{myAns[0]}, {myAns[1]}");

int[] TwoSum(int[] nums, int target) {
    
    Dictionary<int,int> valueMap = new();

    for (int i = 0; i < nums.Length; i++)
    {
        int x = target - nums[i];
        if(valueMap.TryGetValue(x, out int index))
            return new int[] {index,i};
        else
            valueMap.TryAdd(nums[i],i);
    }
    throw new Exception("Target not found in nums");
}