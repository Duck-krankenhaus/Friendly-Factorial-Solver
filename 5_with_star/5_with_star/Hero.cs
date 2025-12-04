class Hero : Character
{
    public Hero(string name = "Hero", int hp = 100) : base(name, hp) { }

    public override int Attack()
    {
        return _rnd.Next(5, 21);
    }
}