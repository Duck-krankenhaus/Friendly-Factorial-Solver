class BattleMonitor : IBattleMonitor
{
    public void ShowRound(ICharacter attacker, ICharacter defender, int damage)
    {
        Console.WriteLine($"{attacker.Name} dealt {damage} damage. {defender.Name} has {defender.HP} HP left.\n");
    }

    public void ShowStart(ICharacter hero, ICharacter monster)
    {
        Console.WriteLine("Battle starts!");
        Console.WriteLine($"{hero.Name} vs {monster.Name}\n");
    }

    public void ShowWinner(ICharacter hero, ICharacter monster)
    {
        Console.WriteLine("\n=== Battle Finished! ===");
        if (hero.IsAlive) Console.WriteLine($"{hero.Name} wins!");
        else Console.WriteLine($"{monster.Name} wins!");
        Console.WriteLine("\nRAID SHADOW LA.......");
    }
}