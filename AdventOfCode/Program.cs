string[] lines = File.ReadAllLines(@"M:\Programming\AdventOfCode\input.txt");

int GetPriority(char c)
{
    return char.IsLower(c) ? (c - 'a' + 1) : (c - 'A' + 27);
}

char FindCommonCharacter(string s1, string s2, string s3)
{
    foreach (char c in s1)
    {
        if (s2.IndexOf(c) != -1 && s3.IndexOf(c) != -1)
            return c;
    }
    return '\0';
}

int sum = 0;
for (int i = 0; i < lines.Length - 2; i += 3)
{
    string s1 = lines[i];
    string s2 = lines[i + 1];
    string s3 = lines[i + 2];

    sum += GetPriority(FindCommonCharacter(s1, s2, s3));
}
Console.WriteLine(sum);