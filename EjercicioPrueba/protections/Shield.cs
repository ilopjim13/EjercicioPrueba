using EjercicioPrueba.character;

namespace EjercicioPrueba.protections;

public class Shield :Protection
{
    public Shield(string name, int armor, double evasionRate) : base(name, armor, evasionRate)
    {
    }

    protected override void AddEquipment(Character character)
    {
        //throw new NotImplementedException();
    }

    protected override void QuitEquipment(Character character)
    {
        //throw new NotImplementedException();
    }

    protected override bool CheckEquipament(Character character)
    {
        //throw new NotImplementedException();
        return true;
    }
}