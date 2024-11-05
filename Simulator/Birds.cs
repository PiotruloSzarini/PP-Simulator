namespace Simulator;
public class Birds : Animals
{
    public bool CanFly { get; set; } = true;
    public override string Info
    {
        get
        {
            string flyAbility = CanFly ? "fly+" : "fly-";
            return $"{Description} ({flyAbility}) <{Size}>";
        }
    }
}