palindrome();
void palindrome()
{
    while (true)
    {
        Console.Write("Enter a Word to know if it is a Palindrome (or press enter to quit):");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Shutting Down!!");
            break;
        }
        bool isPalindrome = true;
        int len = input.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (char.ToLower(input[i]) != char.ToLower(input[len - i - 1]))
            {
                isPalindrome = false;
                break;
            }
        }
        if (isPalindrome)
        {
            Console.WriteLine("This word is a Palindrome!");
        }
        else
        {
            Console.WriteLine("This word is not a Palindrome");
        }
    }
}