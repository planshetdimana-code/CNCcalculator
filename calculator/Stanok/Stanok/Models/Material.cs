namespace Stanok.Models;

public class Material
{
    public string Key { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int Hardness { get; set; }
    public double VcMin { get; set; }
    public double VcMax { get; set; }
    public double DefaultVc { get; set; }
    public double FzMin { get; set; }
    public double FzMax { get; set; }
    public double DefaultFz { get; set; }
    public double Kc1 { get; set; }
    public double Mc { get; set; }
    public string Description { get; set; } = string.Empty;
}
