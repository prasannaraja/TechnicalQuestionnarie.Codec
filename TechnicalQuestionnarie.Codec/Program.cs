Console.WriteLine("Enter the plateau size (e.g. 5x5):");
string plateauSize = Console.ReadLine();
string[] plateauSizeArr = plateauSize.Split('x');

int x = 1, y = 1;
string facing = "NORTH";

Console.WriteLine("Enter the commands:");
string commands = Console.ReadLine();

if(!string.IsNullOrEmpty(commands))
{
    Execute(commands);
    Console.WriteLine("Final position: {0} {1} {2}", x, y, facing);
    Console.ReadLine();
}
else
{
    Console.WriteLine("command cannot be empty");
    Console.ReadLine();
}

void MoveLeft()
{
    switch (facing)
    {
        case "NORTH":
            facing = "WEST";
            break;
        case "WEST":
            facing = "SOUTH";
            break;
        case "SOUTH":
            facing = "EAST";
            break;
        case "EAST":
            facing = "NORTH";
            break;
    }
}
    
void Execute(string commands)
{
    foreach (char command in commands)
    {
        if (command == 'L')
            MoveLeft();
    }
}