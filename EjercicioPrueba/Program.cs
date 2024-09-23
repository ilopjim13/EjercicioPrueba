

namespace EjercicioPrueba
{
    class Program
    {
        static void Main()
        {
            Weapon sword = new Sword("Steel Fang", 15, 0.06, 5);
            var character = new Character("Ronan", 150, 10, 20, [sword]);
            var loot = LootGenerator();
            
            var enemy = new Character("Goblin", 30, 50, 10, []);
            
            sword.Equip(character);

            var combat = true;
            Console.WriteLine("You've run into a goblin, the fight begins!");
            while (combat)
            {
                var attack = character.Attack();
                var defenseEnemy = enemy.Defense();
                enemy.ReceiveDamage(attack - defenseEnemy);

                var attackEnemy = enemy.Attack();
                var defense = character.Defense();
                character.ReceiveDamage(attackEnemy - defense);

                if (character.CurrentHp == 0)
                {
                    Console.WriteLine("You lose!!");
                    combat = false;
                } else if (enemy.CurrentHp == 0)
                {
                    Console.WriteLine("You Win!!");
                    combat = false;
                    var index = new Random().Next(loot.Count);
                    var randomLoot = loot[index]; ;
                    Console.WriteLine("The enemy has dropped an item");
                    randomLoot.Apply(character);
                    randomLoot.Equip(character);
                    character.Heal(100);
                }

            }
            
        }


        static List<ITem> LootGenerator()
        {
            var loot = new List<ITem>
            {
                new Helmet("Shield of Valor", 100,  0.05),
                new Helmet("Helmet of Insight", 50,  0.1),
                new Helmet("Chestplate of Fortitude", 150, 0.02),
                new Helmet("Gauntlets of Dexterity",40, 0.12),
                new Helmet("Boots of Swiftness", 30, 0.15),
                new Sword("Sword of Dawn", 50,  0.2, 100),
                new Axe("Axe of Fury", 60, 0.15, 120 ),
                new Sword("Claymore", 40, 0.25, 90),
                new Sword("Dagger of Silence", 30, 0.3, 80),
                new Sword("Hammer of Thunder", 70, 0.1, 150)
            };

            return loot;
        }
    
    }
}




