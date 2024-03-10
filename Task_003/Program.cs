void Main()
{
    int[] arr = [1678, 24, 345, 46, 50];
    dz3(arr, arr.Length - 1);
}

void dz3(int[] nums, int n) {
    if (n < 0) return;
    Console.Write(nums[n] + " ");
    dz3(nums, n - 1);
}

Main();
