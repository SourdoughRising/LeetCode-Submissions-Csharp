public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romaNums = new Dictionary<char, int>();
        romaNums.Add('I', 1);
        romaNums.Add('V', 5);
        romaNums.Add('X', 10);
        romaNums.Add('L', 50);
        romaNums.Add('C', 100);
        romaNums.Add('D', 500);
        romaNums.Add('M', 1000);

        int[] ints = new int[s.Length];
        int result = 0;

        for (int x = 0; x < s.Length; x++)
        {
            ints[x] = romaNums[s[x]];
        }
        int i = 0;
        while (i < ints.Length)
        {
            if (i < ints.Length - 1 && ints[i] < ints[i + 1])
            {
                result = result + ints[i + 1] - ints[i];
                i += 2;
            }
            else
            {
                result = result + ints[i];
                i++;
            }
        }


        return result;

    }
}