namespace EjercicioPrueba.pets;

public class Pet
{
    public string Name { get; set; }
    public int Damage { get; set; }

    public Pet(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public int Attack()
    {
        return Damage;
    }
}