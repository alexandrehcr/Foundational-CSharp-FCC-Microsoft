int heroHealth = 10, monsterHealth = 10;
Random random = new Random();

while (heroHealth > 0 && monsterHealth > 0)
{
    // Hero attack
    int attack = random.Next(1, 11);
    monsterHealth -= attack;
    
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");
    
    if (monsterHealth <= 0)
        break;
    
    // Monster attack
    attack = random.Next(1, 11);
    heroHealth -= attack;
    
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
}
Console.WriteLine(monsterHealth < heroHealth ? "Hero wins!" : "Monster Wins!");
