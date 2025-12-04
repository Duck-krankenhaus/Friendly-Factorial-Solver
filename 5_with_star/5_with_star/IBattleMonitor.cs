interface IBattleMonitor
{
    void ShowRound(ICharacter attacker, ICharacter defender, int damage);
    void ShowStart(ICharacter hero, ICharacter monster);
    void ShowWinner(ICharacter hero, ICharacter monster);
}