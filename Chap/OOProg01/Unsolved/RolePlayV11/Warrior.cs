
public class Warrior
{
    #region Instance fields
    private string _name;
    private int _level;
    private int _hp;
    private int _currentHp;
    private bool _dead;
    #endregion

    #region Constructor
    public Warrior(string name, int hp)
    {
        _name = name;
        _level = 1;
        _hp = hp;
        _currentHp = _hp;
        _dead = false;
    }
    #endregion

    #region Properties
    public string Name
    {
        get { return _name; }
    }

    public int Level
    {
        get { return _level; }
    }

    public int Hp
    {
        get { return _hp; }
    }

    public bool Dead
    {
        get
        {
            if (_hp <= 0)
            {
                _dead = true;
                return _dead;
            }
            else
            {
                _dead = false;
                return _dead;
            }
        }
    }
    #endregion

    #region Methods
    public void LevelUp()
    {
        _level = _level + 1;
    }

    public void Damagetaken(int damage)
    {
        _hp -= damage;
    }

    public int DealDamage()
    {
        Random rnd = new Random();
        int dmgValue = rnd.Next(10, 20);
        return dmgValue;
    }
    #endregion
}
