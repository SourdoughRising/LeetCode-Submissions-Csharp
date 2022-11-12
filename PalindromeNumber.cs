public class Solution
{
    public bool IsPalindrome(int x)
    {
        string input = Convert.ToString(x);
        Console.WriteLine(input);
        char[] charray = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            charray[i] = input[i];
        }
        Console.WriteLine(charray);
        string reverse = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse += charray[i];
        }
        Console.WriteLine(reverse);

        if (input == reverse)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}