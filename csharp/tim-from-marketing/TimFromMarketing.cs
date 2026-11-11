static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string dep = (department ?? "OWNER").ToUpper();

        if (id == null)
        {
            return $"{name} - {dep}";
        }

        return $"[{id}] - {name} - {dep}";
    }
    
}
