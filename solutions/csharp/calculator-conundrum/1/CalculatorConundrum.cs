public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        return operation switch 
        {
                "+" => $"{operand1} + {operand2} = {operand1 + operand2}",
                "-" => $"{operand1} - {operand2} = {operand1 - operand2}",
                "*" => $"{operand1} * {operand2} = {operand1 * operand2}",
                "/" => operand2 == 0 ? "Division by zero is not allowed." : $"{operand1} / {operand2} = {operand1 / operand2}",
""  => throw new ArgumentException("Operation cannot be empty."),
        null => throw new ArgumentNullException(nameof(operation), "Operation cannot be null."),
        _   => throw new ArgumentOutOfRangeException(nameof(operation), "Unknown operation.")
    };
    }
}
