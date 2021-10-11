using CoexWorkshop;
using System;
using System.Diagnostics;
    
int iterations = 1000000;

var cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
var ram = new PerformanceCounter("Memory", "Available MBytes");
Stopwatch processTime = new();
cpu.NextValue();
ram.NextValue();

// Regex Method
processTime.Restart();
RegexCicle(iterations);
processTime.Stop();
PrintStats(cpu.NextValue(), ram.NextValue(), processTime.ElapsedMilliseconds, nameof(RegexCicle));

// Exception Method
processTime.Restart();
try
{
    ExceptionCicle(iterations);
}
catch (Exception)
{
    // Console.WriteLine(exception.Message);
}
processTime.Stop();
PrintStats(cpu.NextValue(),ram.NextValue(), processTime.ElapsedMilliseconds,nameof(ExceptionCicle));

// IF Method
processTime.Restart();
IfCicle(iterations);
processTime.Stop();
PrintStats(cpu.NextValue(), ram.NextValue(), processTime.ElapsedMilliseconds, nameof(IfCicle));


void RegexCicle(int cicleLength)
{
    for (int i = 0; i < cicleLength; i++)
    {
        Week1.RegexValidation("Asdsdsdsd");
        Week1.RegexValidation("Asd");
        Week1.RegexValidation("Aasddsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsddfadasdsdssdsdsdsdsdsdsdsdsdsddssd");
        Week1.RegexValidation("asdsdsdsd");
    }
}

void IfCicle(int cicleLength)
{
    for (int i = 0; i < cicleLength; i++)
    {
        Week1.IfValidation("Asdsdsdsd");
        Week1.IfValidation("Asd");
        Week1.IfValidation("Aasddsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsddfadasdsdssdsdsdsdsdsdsdsdsdsddssd");
        Week1.IfValidation("asdsdsdsd");
    }
}

void ExceptionCicle(int cicleLength)
{
    for (int i = 0; i < cicleLength; i++)
    {
        Week1.ExceptionsValidation("Asdsdsdsd");
        Week1.ExceptionsValidation("Asd");
        Week1.ExceptionsValidation("Aasddsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsddfadasdsdssdsdsdsdsdsdsdsdsdsddssd");
        Week1.ExceptionsValidation("asdsdsdsd");
    }
}

void PrintStats(float cpuValue, float ramValue, float elapsedTime, string methodName)
{
    Console.WriteLine($"{methodName}:");
    Console.WriteLine($"Time: {elapsedTime} ms");
    Console.WriteLine($"CPU Value: {cpuValue}, Ram value: {ramValue} \n");
}