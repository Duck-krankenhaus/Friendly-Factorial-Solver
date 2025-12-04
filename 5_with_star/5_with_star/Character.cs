abstract class Character : ICharacter
{
    public string Name { get; protected set; } 
    public int HP { get; protected set; }     
    public bool IsAlive => _hp > 0;           

    protected int _hp;                  
    protected Random _rnd = new Random();    

    public Character(string name, int hp)
    {
        Name = name;
        _hp = hp;
        HP = hp;
    }

    public abstract int Attack();             

    public void TakeDamage(int damage)   
    {
        _hp -= damage;
        if (_hp < 0) _hp = 0;
        HP = _hp;
    }
}