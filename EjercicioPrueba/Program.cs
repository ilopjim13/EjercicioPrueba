

namespace EjercicioPrueba
{
    class Program
    {
        static void Main()
        {
            Weapon sword = new Sword("Steel Fang", 25, 0.06, 5);
            Protection shield = new Shield("Shield", 10, 0.06);
            var character = new Character("Ronan", 150, 10, 20, [sword, shield]);
            var loot = LootGenerator();
            
            var enemy = new Character("Goblin", 30, 50, 10, [shield]);
            
            sword.Equip(character);
            shield.Equip(character);
            shield.Equip(enemy);

            var combat = true;
            Console.WriteLine("You've run into a goblin, the fight begins!");
            while (combat)
            {
                var attack = character.Attack();
                var defenseEnemy = enemy.Defense();
                if (enemy.ReceiveDamage(DamageCalculator(attack, defenseEnemy)))
                {
                    Console.WriteLine("You have missed the attack!!");
                }

                var attackEnemy = enemy.Attack();
                var defense = character.Defense();
                if (character.ReceiveDamage(DamageCalculator(attackEnemy, defense)))
                {
                    Console.WriteLine("You have dodged the attack!!");
                }

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
        
        
        static int DamageCalculator(int attacker, int defender) 
        {
            if (attacker >= defender)
            {
                return attacker - defender;
            }

            return 0;
        }


        static List<ITem> LootGenerator()
        {
            var loot = new List<ITem>
            {
                new Shield("Shield of Valor", 100,  0.05),
                new Helmet("Helmet of Insight", 50,  0.1),
                new Shield("Chestplate of Fortitude", 150, 0.02),
                new Helmet("Gauntlets of Dexterity",40, 0.12),
                new Boots("Boots of Swiftness", 30, 0.15),
                new Sword("Sword of Dawn", 50,  0.2, 100),
                new Axe("Axe of Fury", 60, 0.15, 120 ),
                new Sword("Claymore", 40, 0.25, 90),
                new Sword("Dagger of Silence", 30, 0.3, 80),
                new Hammer("Hammer of Thunder", 70, 0.1, 150)
            };

            return loot;
        }
    
    }
}




