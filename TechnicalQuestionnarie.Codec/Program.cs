Console.WriteLine("Enter the plateau size (e.g. 5x5):");
string plateauSize = Console.ReadLine();
string[] plateauSizeArr = plateauSize.Split('x');
int maxX = int.Parse(plateauSizeArr[0]);
int maxY = int.Parse(plateauSizeArr[1]);

int x = 1, y = 1;
string facing = "NORTH";

Console.WriteLine("Enter the commands:");
string commands = Console.ReadLine();

Execute(commands);
Console.WriteLine("Final position: {0} {1} {2}", x, y, facing);
Console.ReadLine();

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

void MoveRight()
{
    switch (facing)
    {
        case "NORTH":
            facing = "EAST";
            break;
        case "EAST":
            facing = "SOUTH";
            break;
        case "SOUTH":
            facing = "WEST";
            break;
        case "WEST":
            facing = "NORTH";
            break;
    }
}

void MoveForward()
{
    switch (facing)
    {
        case "NORTH":
            if (y < maxY)
                y++;
            break;
        case "EAST":
            if (x < maxX)
                x++;
            break;
        case "SOUTH":
            if (y > 1)
                y--;
            break;
        case "WEST":
            if (x > 1)
                x--;
            break;
    }
}

void Execute(string commands)
{
    foreach (char command in commands)
    {
        if (command == 'L')
            MoveLeft();
        else if (command == 'R')
            MoveRight();
        else if (command == 'F')
            MoveForward();

        // check if the robot is still within the plateau
        if (x < 1 || x > maxX || y < 1 || y > maxY)
        {
            Console.WriteLine("Robot went out of the plateau! Ignoring command: " + command);
            break;
        }
    }
}