public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        //find the shortest string


        if (strs == null || strs.Length == 0) { return ""; Console.WriteLine("empty string returned"); }
        for (int i = 0; i < strs[0].Length; i++)
        {
            char c = strs[0][i];
            Console.WriteLine("c = {0}", c);
            for (int j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || strs[j][i] != c)
                {
                    Console.WriteLine("strs[0].Substring(0,{0}) = {1}", i, strs[0].Substring(0, i));
                    return strs[0].Substring(0, i);
                }
            }
        }

        return strs[0];
    }
}