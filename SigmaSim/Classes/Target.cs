namespace SigmaSim.Classes
{
    internal enum ReRolls
    {
        None,
        Ones,
        All
    }

    internal enum SpecialRules
    {
        SavesOfRevenHeal1Wound,
        IgnoresRend,
        IgnoresRendOf1
    }
    internal class Target
    {
        internal int save { get; set; }
        internal bool mysticShield { get; set; }
        internal int saveModifier { get; set; }
        internal ReRolls reRolls { get; set; }
    }
}