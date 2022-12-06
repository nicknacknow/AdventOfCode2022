string[] lines = File.ReadAllLines(@"M:\Programming\AdventOfCode\input.txt");

bool IsNumberInRange(int min, int max, int num)
{
    return (num >= min && num <= max);
}

int sum = 0;
List<List<int>> prev = new List<List<int>>();
int i = 0;
foreach(string line in lines)
{
    string[] pair = line.Split(",");
    string[] elf1 = pair[0].Split("-");
    string[] elf2 = pair[1].Split("-");
    int[] nelf1 = { int.Parse(elf1[0]), int.Parse(elf1[1]) };
    int[] nelf2 = { int.Parse(elf2[0]), int.Parse(elf2[1]) };

    if (IsNumberInRange(nelf2[0], nelf2[1], nelf1[0]) && IsNumberInRange(nelf2[0], nelf2[1], nelf1[1]))
    {
        prev.Add(new List<int>{ nelf1[0], nelf1[1] });
        sum++;
    }
    else if (IsNumberInRange(nelf1[0], nelf1[1], nelf2[0]) && IsNumberInRange(nelf1[0], nelf1[1], nelf2[1]))
    {
        prev.Add(new List<int> { nelf2[0], nelf2[1] });
        sum++;
    }
    i++;
    if (i % 2 == 0)
    {


        prev = new List<List<int>>();
    }
}