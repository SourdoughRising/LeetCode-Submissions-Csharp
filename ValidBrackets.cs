public class Solution
{

    public bool IsValid(string s)
    {

        //Define the brackets
        Dictionary<char, char> map = new Dictionary<char, char>();

        map.Add(')', '(');
        map.Add(']', '[');
        map.Add('}', '{');

        //Instantiate a stack to store bracket occurances
        Stack<char> myStack = new Stack<char>();

        //Loops through the string
        for (int i = 0; i < s.Length; i++)
        {
            //Instantiate the current character
            char c = s[i];

            //If this character is an opening bracket
            if (map.ContainsKey(c))
            {
                //If the stack is empty, push a dummy value '#', else clear the top of the stack
                char topElement = myStack.Count == 0 ? '#' : myStack.Pop();

                //if the top of the stack isn't the opening bracket, then the brackets are invalid
                if (topElement != map[c])
                {
                    return false;
                }
            }
            //else if the character is a closing bracket
            else
            {
                myStack.Push(c);
            }
        }
        //if the stack is empty, the brackets are valid.
        return myStack.Count == 0;
    }
}