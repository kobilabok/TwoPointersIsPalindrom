// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Is Palindrom

var input = "aurora"; //racecar, aurora

Console.WriteLine(IsPalindrom(input));

bool IsPalindrom(string s){

    int left = 0;
    int right = s.Length - 1;

     while(left < right){

        if(s[left] != s[right]){
            return false;
        }
        left++;
        right--;
     }

    return true;
}


// Two Numbers - Return True if sum of two numbers equal target number
int[] numbers = [1, 2, 4, 6, 8, 9, 14, 15];
int targetNum = 13;

Console.WriteLine(CheckForTarget(numbers, targetNum));

bool CheckForTarget(int[] nums, int target){
    int left = 0;
    int right = nums.Length - 1;

    while(left < right){

        // current number is current sum
        int curr = nums[left] + nums[right];
        if(curr == target){
            return true;
        }
        if(curr > target){
            right--;
        }
        else{
            left++;
        }
    }
    return false;
}