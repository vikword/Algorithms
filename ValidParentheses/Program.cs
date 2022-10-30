bool IsValid(string s)
{
    var stack = new Stack<char>();

    foreach (var c in s.ToCharArray())
    {
        if (c is '(' or '[' or '{')
            stack.Push(c);

        else
        {
            if (stack.Count == 0)
                return false;

            var d = stack.Pop();

            if (c == ')' && d != '(' || c == ']' && d != '[' || c == '}' && d != '{')
                return false;
        }
    }

    return stack.Count == 0;
}

Console.WriteLine(IsValid("()"));