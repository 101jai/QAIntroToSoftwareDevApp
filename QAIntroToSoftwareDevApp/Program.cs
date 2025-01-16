using QAIntroToSoftwareDevApp.Classes;

Prison belmarsh = new Prison("HMP Belmarsh", "London");

// Add cells to the prison using Add Cell method
belmarsh.AddCell(10);
belmarsh.AddCell(5);

// Add prisoners to the prison using Add Prisoner method, incrementing the id each time. This adds the prisoners to the first cell that has capacity.
int currentPrisonerId = 0;
belmarsh.AddPrisoner(new Prisoner(currentPrisonerId, "John Doe", 30, "Software Piracy", DateTime.MaxValue, RiskLevel.HIGH));
currentPrisonerId++;
belmarsh.AddPrisoner(new Prisoner(currentPrisonerId, "Jeremy Doe", 30, "Software Piracy", DateTime.MaxValue, RiskLevel.HIGH));
currentPrisonerId++;

// Log the prison's capacity and information on the prisoners within the prison
Console.WriteLine(belmarsh.GetCapacity());
foreach(Prisoner prisoner in belmarsh.GetPrisoners())
{
    Console.WriteLine(prisoner.ToString());
}

// Remove a prisoner from the prison using the Remove Prisoner method and log the remaining prisoners
belmarsh.RemovePrisoner(0);
Console.WriteLine("\n After removing Prisoner with id 0");

foreach (Prisoner prisoner in belmarsh.GetPrisoners())
{
    Console.WriteLine(prisoner.ToString());
}