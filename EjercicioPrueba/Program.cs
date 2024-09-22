
using EjercicioPrueba;

Weapon espada = new Sword("espada", 6);


Character character = new Character("pepe", 5, 5, 5, [espada]);

espada.Apply(character);