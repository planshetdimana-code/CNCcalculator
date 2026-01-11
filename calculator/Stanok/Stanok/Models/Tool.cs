namespace Stanok.Models;

public class Tool
{
    public double Diameter { get; set; }
    public int Flutes { get; set; }
    public string ImagePath { get; set; } = string.Empty;
    public override string ToString() => $"Ø{Diameter} · {Flutes}p";
}

