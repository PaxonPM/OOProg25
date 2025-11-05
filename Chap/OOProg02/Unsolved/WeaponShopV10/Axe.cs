
/// <summary>
/// This class represents a Axe. An Axe is 
/// considered to be a weapon.
/// </summary>
public class Axe : Weapon
{
    public const int InitialAxeMinDamage = 20;
    public const int InitialAxeMaxDamage = 50;

    #region Constructor
    public Axe(string description)
        : base(description, InitialAxeMinDamage, InitialAxeMaxDamage)
    {
    }
    #endregion


    #region methods
    public int DamageFromAxe()
    {
        int result = CalculateDamage();

        MinDamage = MinDamage < 3 ? 0 : MinDamage - 3;
        MaxDamage = MaxDamage < 3 ? 0 : MaxDamage - 3;

        return result;


    }

    public void Sharpen()
    {
        MinDamage = InitialAxeMinDamage;
        MaxDamage = InitialAxeMaxDamage;
    }
    #endregion


}