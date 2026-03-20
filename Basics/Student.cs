namespace Practical04;

public enum Options
{
    Aggregate = 1,
    MinMark = 2,
    MaximumMark = 3,
    Grade = 4
}

public class Student
{
    public required string Name { get; init; }
    public decimal[] Marks { get; init; } = new decimal[5];

    public static decimal AverageMarks;

    /// <summary>
    /// Calculates and returns average marks of the student.
    /// Return Type: decimal
    /// </summary>
    public decimal CalculateAverageMarks()
    {
        AverageMarks = Marks.Average();
        return AverageMarks;
    }

    /// <summary>
    /// Determines grade based on marks using pattern matching.
    /// Return Type: string
    /// </summary>
    public string CalculateGrade(decimal marks)
    {
        return marks switch
        {
            > 90 => "A",
            > 80 => "B",
            > 70 => "C",
            <= 70 => "D"
        };
    }
}