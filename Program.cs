Console.WriteLine("Please Write an amount of seconds: ");
int input = Convert.ToInt32(Console.ReadLine());

int days = input / 86400;
int hours = (input % 86400) / 3600;
int minutes = (input % 3600) / 60;
int seconds = input % 60;
double daysExact = input / 86400.0;

Console.WriteLine($"Days: {days}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Seconds: {seconds}");


Console.WriteLine($"Formatted: {days}.{hours:D2}:{minutes:D2}:{seconds:D2}");


Console.WriteLine($"In total that's: {daysExact:F5} days.");
