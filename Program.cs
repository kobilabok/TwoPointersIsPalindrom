// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/* Example 1: Given a string s, return true if it is a palindrome, false otherwise.

A string is a palindrome if it reads the same forward as backward. That means, after reversing it, it is still the same string. For example: "abcdcba", or "racecar".
*/

using System.Globalization;

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


/* Example 2: Given a sorted array of unique integers and a target integer, return true if there exists a pair of numbers that sum to target, false otherwise. This problem is similar to Two Sum. (In Two Sum, the input is not sorted).

For example, given nums = [1, 2, 4, 6, 8, 9, 14, 15] and target = 13, return true because 4 + 9 = 13.

*/
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

// Example 3: Given two sorted integer arrays arr1 and arr2, return a new array that combines both of them and is also sorted.

int[] numOne = [1, 4, 3, 7, 20];
int[] numTwo = [3, 5, 6];

var newArray = CombineArrays(numOne, numTwo);

foreach(int num in newArray){
    Console.WriteLine(num);
}

List<int> CombineArrays(int[] arr1, int[] arr2){

    List<int> result = new List<int>();

    int i = 0;
    int j = 0;

    while(i < arr1.Length && j < arr2.Length){
        if(arr1[i] < arr2[j]){

            result.Add(arr1[i]);
            i++;
        }
        else{
            result.Add(arr2[j]);
            j++;
        }
    }

    while (i < arr1.Length){
        result.Add(arr1[i]);
        i++;
    }

    while(j < arr2.Length){
        result.Add(arr2[j]);
        j++;
    }

    return result;
}


/*
Example 4: 392. Is Subsequence.

Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a sequence of characters that can be obtained by deleting some (or none) of the characters from the original string, while maintaining the relative order of the remaining characters. For example, "ace" is a subsequence of "abcde" while "aec" is not.
*/

string stringOne = "ace";
string stringTwo = "abcde";

Console.WriteLine(IsSubsequence(stringOne, stringTwo));

bool IsSubsequence(string s, string t){

    int i = 0;
    int j = 0;

    while(i < s.Length && j < t.Length){

        if(s[i] == t[j]){
            i++;
        }
        j++;
    }
    return i == s.Length;
}