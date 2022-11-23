public class Solution {
    public int LengthOfLastWord(string s) {
        int result = 0;
        bool trim = true;
        bool lastWord = false;
        for(int i = s.Length; i > 0; i--)
        {
            if(trim && s[i-1] == ' ')
            {
                Console.WriteLine("trim");
            }
            else if(!lastWord && s[i-1] != ' ')
            {
                trim = false;
                lastWord = true;
                Console.WriteLine("trim complete");
            }
            if(lastWord && s[i-1] != ' ')
            {
                result++;
                Console.WriteLine("Last Word");
            }
            else if(!trim && s[i-1] == ' ')
            {
                lastWord = false;
                Console.WriteLine("Complete");
                i = 0;
            }
        }

        return result;
    }
}