using QAIntroToSoftwareDevApp.Classes;

string prisonName = string.Empty;
string prisonLocation = string.Empty;

// Get user input on prison
while (string.IsNullOrEmpty(prisonName))
{
    Console.Write("New Prison Name: ");
    prisonName = Console.ReadLine();
}

while (string.IsNullOrEmpty(prisonLocation))
{
    Console.Write($"Location of {prisonName}: ");
    prisonLocation = Console.ReadLine();
}

// Insantiate a new Prison based on the submitted info to the prison variable
Prison prison = new Prison(prisonName, prisonLocation);

// Get number of prison cells from user
int prisonCells = 0;
Console.WriteLine("Please enter an integer for number of cells that is greater than 0");
while (prisonCells < 1)
{
    try
    {
        prisonCells = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a valid integer for the number of cells");
    }
}

// Get each cell's capacity from user then add the cell to the prison object
for (int i = 0; i < prisonCells; i++)
{
    int cellCapacity = 0;
    while (cellCapacity < 1)
    {
        try
        {
            Console.WriteLine("What is the capacity of cell #" + i);
            cellCapacity = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer for the capacity of cell #" + i);
        }
    }
    prison.AddCell(cellCapacity);
}

Console.WriteLine($"{prisonName} has a capacity of: {prison.GetCapacity()}");
