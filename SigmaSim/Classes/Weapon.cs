namespace SigmaSim.Classes
{
    public enum DamageType
    {
        Unknown,
        Numeric,
        D3,
        D6
    }

    public enum SpecialRule
    {
        None,
        RollHit6DoesD3MortalsInstead,
        RollHit6DoesD3MortalsAswell,
        RollHit6IncreaseRendBy1,
    }

    /// <summary>
    /// Class to represent a weapon used in the simulation. a simulation can have multiple weapons
    /// such as 5 Brutes attacking 3 with Great swords doing 3 attacks each and 2 with hand axes foing 4 attacks each ect
    /// </summary>
    public class Weapon
    {
        public string name { get; set; }
        public int attacks { get; set; }
        public int toHit { get; set; },
        public int toWound { get; set; }
        public int rend { get; set; }
        public DamageType damageType { get; set; }
        public int damage { get; set; }
        public SpecialRule specialRule {get;set;}
    }
}