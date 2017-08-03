namespace SigmaSim.Classes
{
    internal class Result
    {
        internal int attemptedHits { get; set; }
        internal int successfullHits { get; set; }
        internal int attemptedWounds { get; set; }
        internal int successfullWounds { get; set; }
        internal int attemptedSaves { get; set; }
        internal int failedSaves { get; set; }
        internal int damageRolls { get; set; }
        internal int damageDone { get; set; }
    }
}