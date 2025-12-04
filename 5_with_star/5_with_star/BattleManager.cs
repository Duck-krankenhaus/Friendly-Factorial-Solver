class BattleManager
{
    private ICharacter _hero;
    private ICharacter _monster;
    private IBattleMonitor _monitor; 

    public BattleManager(ICharacter hero, ICharacter monster, IBattleMonitor monitor)
    {
        _hero = hero;
        _monster = monster;
        _monitor = monitor;
    }

    public void Start()
    {
        _monitor.ShowStart(_hero, _monster);

        while (_hero.IsAlive && _monster.IsAlive)
        {
            Round(_hero, _monster);
            if (!_monster.IsAlive) break;

            Round(_monster, _hero);
        }

        _monitor.ShowWinner(_hero, _monster);
    }

    private void Round(ICharacter attacker, ICharacter defender)
    {
        int _damage = attacker.Attack();
        defender.TakeDamage(_damage);
        _monitor.ShowRound(attacker, defender, _damage);
        System.Threading.Thread.Sleep(500);
    }
}