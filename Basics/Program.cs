using Practical04;

Console.Write("Enter Student Name: ");
string name = Console.ReadLine() ?? "Unknown";
decimal[] marks = new decimal[5];

for (int i = 0; i < 5; i++)
{
    while (true)
    {
        Console.Write($"Enter marks {i + 1} in range [0–100]: ");
        if (decimal.TryParse(Console.ReadLine(), out var mark) && mark >= 0 && mark <= 100)
        {
            marks[i] = mark;
            break;
        }
        Console.WriteLine("Marks should be in range of 0-100 only. Try again.");
    }
}

Console.WriteLine("\nChoose Option:");
Console.WriteLine("1 - Aggregate");
Console.WriteLine("2 - MinMark");
Console.WriteLine("3 - MaximumMark");
Console.WriteLine("4 - Grade");

var student = new Student
{
    Name = name,
    Marks = marks
};
int input;
while (true)
{
    input = int.Parse(Console.ReadLine() ?? "0");

    if (input < 1 || input > 4)
    {
        Console.WriteLine("Please Enter correct option in range [1-4].");
    }
    else break;
}


var option = (Options)input;
var studentMarks = student.Marks;

switch (option)
{
    case Options.Aggregate:
        Console.WriteLine($"{student.Name}: {student.CalculateAverageMarks()}");
        break;

    case Options.MinMark:
        Console.WriteLine($"Minimum Marks: {studentMarks.Min()}");
        break;

    case Options.MaximumMark:
        Console.WriteLine($"Maximum Marks: {studentMarks.Max()}");
        break;

    case Options.Grade:
        var avg = student.CalculateAverageMarks();
        Console.WriteLine($"Grade: {student.CalculateGrade(avg)}");
        break;

    default:
        Console.WriteLine("Please Enter Correct Option.");
        break;
}
