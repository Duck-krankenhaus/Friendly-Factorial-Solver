class Program
{
    static void Main(string[] args)
    {
        Hero _hero = new Hero();
        Monster _monster = new Monster();
        IBattleMonitor _monitor = new BattleMonitor(); // use interface

        BattleManager _battle = new BattleManager(_hero, _monster, _monitor);
        _battle.Start();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
