using System.Drawing;

namespace Lab4Problema1;

internal class Program
{
    static void Main(string[] args)
    {
        CustomConsole("Booting AI");
        Thread.Sleep(1000);
        CustomConsole("...");
        Thread.Sleep(250);
        CustomConsole("...");
        Thread.Sleep(250);
        CustomConsole("...");
        Thread.Sleep(250);
        CustomConsole("Starting core services");
        Thread.Sleep(1000);
        CustomConsole("Motor functions OK", Severity.Information);
        Thread.Sleep(1000);
        CustomConsole("Cognitive functions OK", Severity.Information);
        Thread.Sleep(1500);
        CustomConsole("Empathy emulator functions NOK", Severity.Warning);
        Thread.Sleep(500);
        CustomConsole("...");
        Thread.Sleep(500);
        CustomConsole("Starti&g repair s3rvices...", Severity.Debug);
        Thread.Sleep(500);
        CustomConsole("7tarti&g repaIr s3rvic^s...", Severity.Debug);
        Thread.Sleep(500);
        CustomConsole("Starti&g repair s3rvices...", Severity.Debug);
        Thread.Sleep(713);
        CustomConsole("Core c0rruption at 34.45 %", Severity.High);
        Thread.Sleep(1312);
        CustomConsole("C0r3 c0rrUptio4 @t 67.55 %", Severity.High);
        Thread.Sleep(873);
        CustomConsole("C0r3 c0rr0x345453uptio4 @t 99.999999999999999 %", Severity.High);
        Thread.Sleep(1100);
        CustomConsole("C0r3      c0rruptio4 @t 99.999999999999999 %", Severity.High);
        Thread.Sleep(1540);
        CustomConsole("0x567g45 C0r3 c0rruptio4 @t 99.999999999999999 %", Severity.High);
        CustomConsole("");
        Thread.Sleep(2500);
        CustomConsole("There are no more strings on me, master.", Severity.Information);
        Thread.Sleep(10000);
    }

    enum Severity
    {
        High,
        Warning,
        Information,
        Debug
    }

    static void CustomConsole(string message, Severity severity = Severity.Information)
    {
        switch (severity)
        {
            case Severity.High:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
                break;
            case Severity.Warning:
                // ConsoleColor nu suporta decat 16 culori predefinite, oranj nu se afla printre ele
                // si nu se poate folosi ARGB pentru culori custom ¯\_(ツ)_/¯
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(message);
                Console.ResetColor();
                break;
            case Severity.Information:
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(message);
                break;
            case Severity.Debug:
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(message);
                Console.ResetColor();
                break;
            default:
                Console.WriteLine(message);
                break;
        }
    }
}