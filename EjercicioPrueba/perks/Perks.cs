namespace EjercicioPrueba.perks;

public class Perks
{
    public Perks(int maxHp, int baseDamage, int baseArmor) => (MaxHp, CurrentHp, BaseDamage, Evasion, BaseArmor) = (maxHp, maxHp, baseDamage, 0, baseArmor);
    public int MaxHp { get; set; }
    public int CurrentHp { get; set; }
    public int BaseDamage { get; set; }
    public double Evasion { get; set; }
    public int BaseArmor { get; set; }
}