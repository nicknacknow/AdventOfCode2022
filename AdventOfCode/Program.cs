string[] lines = File.ReadAllLines(@"M:\Programming\AdventOfCode\input.txt");

Dictionary<string, int> values = new Dictionary<string, int>
{
    ["A"] = 1, // rock
    ["B"] = 2, // paper         OPPONENT
    ["C"] = 3, // scissors

    ["X"] = 1, // rock
    ["Y"] = 2, // paper
    ["Z"] = 3, // scissors
};


int total_score = 0;
foreach (string line in lines)
{
    string[] inp = line.Split(" ");
    string opp = inp[0];
    string us = inp[1];

    if (us == "X") // LOSE NOW
        us = (values[opp] == 1) ? "Z" : values.FirstOrDefault(x=> x.Value == (values[opp] - 1)).Key;
    else if (us == "Y") // DRAW NOW
        us = opp;
    else // win
        us = (values[opp] == 3) ? "X" : values.FirstOrDefault(x => x.Value == (values[opp] + 1)).Key;


    if (values[us] == values[opp]) // we draw
        total_score += (values[us] + 3);
    else if (values[us] - values[opp] == 1 || values[us] - values[opp] == -2) // we win
        total_score += (values[us] + 6);
    else //(values[us] < values[opp]) // we lose
        total_score += (values[us]);
}

Console.WriteLine(total_score);