static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        department = department?.ToUpper();

        if (id.HasValue)
        {
            return $"[{id.Value}] - {name} - {department ?? "OWNER"}";
        }
        else if (!id.HasValue) {
            return $"{name} - {department ?? "OWNER"}";
        }
        else
        {
            return $"{name} - {department ?? "N/A"}";
        }
    }
}
