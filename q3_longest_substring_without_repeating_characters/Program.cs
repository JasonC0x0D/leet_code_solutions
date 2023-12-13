
var solution = new Solution();


List<string> strings = ["abcabcabc",
                        "aaaaaaaaa",
                        "abbcdefgh"];

foreach(var s in strings){
    int ans = solution.LengthOfLongestSubstring(s);
    Console.WriteLine($"{ans} - {s}");
}

public class Solution {
    public int LengthOfLongestSubstring(string s) {

        int longest = 0;

        int startIndex = 0;
        int length = 0;

        while(startIndex + length <= s.Length){
            var sub = s.Substring(startIndex, length);

            length = sub.Length;
            longest = longest >= length ? longest : length;
            
            // Try to add another
            if(s.Length == startIndex + length)
                break;
            
            char nextChar = s[startIndex+length];

            while(sub.Contains(nextChar)){
                sub = s.Substring(++startIndex, --length);
            }

            length++;
        }


        return longest;
    }
}