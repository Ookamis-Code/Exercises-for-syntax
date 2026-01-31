public static class Identifier
{
    public static string Clean(string identifier)
    {
        identifier = identifier.Replace(" ", "_");
        foreach (char c in identifier) {
            if (char.IsControl(c)) {
                identifier = identifier.Replace(c.ToString(), "CTRL");
            }
        }
        string[] parts = identifier.Split('-');
        if (parts.Length > 1) {
            identifier = parts[0];
            for (int i = 1; i < parts.Length; i++) {
                identifier += char.ToUpper(parts[i][0]) + parts[i].Substring(1);
            }
        }
        identifier = new string(identifier.Where(c => (char.IsLetter(c) || c == '_') && !(c >= 'α' && c <= 'ω')).ToArray());
        return identifier;
    }
    
}
