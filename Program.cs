// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


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