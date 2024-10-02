using EjercicioPrueba.character;

namespace EjercicioPrueba.protections;

public class Gauntlets :Protection
{
    public Gauntlets(string name, int armor, double evasionRate) : base(name, armor, evasionRate)
    {
    }

    protected override void AddEquipment(Character character)
    {
        character.Gauntlets = this;
    }

    protected override void QuitEquipment(Character character)
    {
        character.Gauntlets = null;
    }

    protected override bool CheckEquipament(Character character)
    {
        return character.Gauntlets != null;
    }
}