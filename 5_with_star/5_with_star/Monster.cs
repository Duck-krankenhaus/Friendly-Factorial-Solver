class Monster : Character
{
    public Monster(string name = "Monster", int hp = 100) : base(name, hp) { }

    public override int Attack()
    {
        return _rnd.Next(5, 21);
    }
}    