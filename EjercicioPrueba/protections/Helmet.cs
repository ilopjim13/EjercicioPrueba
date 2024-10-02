using EjercicioPrueba.character;
using EjercicioPrueba.pets;

namespace EjercicioPrueba.protections;

public class Helmet :Protection
{
    public bool HelmetPet { get; set; }
    public Helmet(string name, int armor, double evasionRate, bool helmetPet) : base(name, armor, evasionRate)
    {
        HelmetPet = helmetPet;
    }

    public override void Apply(Character character)
    {
        if (HelmetPet)
        {
            Pet pet = new Pet("Pepe", 5);
            character.Pet = pet;
        }
        else base.Apply(character);
    }

    protected override void AddEquipment(Character character)
    {
        character.Helmet = this;
    }

    protected override void QuitEquipment(Character character)
    {
        character.Helmet = null;
    }

    protected override bool CheckEquipament(Character character)
    {
        return character.Helmet != null;
    }
}