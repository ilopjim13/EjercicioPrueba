using EjercicioPrueba.character;

namespace EjercicioPrueba.protections;

public class BodyArmor :Protection
{
    public BodyArmor(string name, int armor, double evasionRate) : base(name, armor, evasionRate)
    {
    }

    protected override void AddEquipment(Character character)
    {
        character.BodyArmor = this;
    }

    protected override void QuitEquipment(Character character)
    {
        character.BodyArmor = null;
    }

    protected override bool CheckEquipament(Character character)
    {
        return character.BodyArmor != null;
    }
}