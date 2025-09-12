/// <summary>
/// This class represents a dice cup containing two dice.
/// </summary>
public class DiceCup
{
    #region Instance fields
    private Die[] _dice;
    #endregion

    #region Constructor
    public DiceCup(int diceCount)
    {
        InitDice(diceCount);
    }
    #endregion

    public void InitDice(int dices)
    {
        _dice = new Die[dices];
        Console.WriteLine($"{_dice.Length}");
        for (int i = 0; i < _dice.Length; i++)
        {
            _dice[i] = new Die();
        }
    }
    // Implement a property TotalValue: the sum of 
    // the face values of the dice in the cup
    //
    public int TotalValue()
    {
        int total = 0;
        for (int i = 0; i < _dice.Length; i++)
        {
            total += _dice[i].FaceValue;
            Console.WriteLine($"The value of die {i} is: {_dice[i].FaceValue}\n");
        }
        return total;
    }

    // Implement a method Shake: all the dice in the cup should be rolled
    //
    public void Shake()
    {
        for(int i = 0; i < _dice.Length; i++)
        {
            _dice[i].Roll();
        }
    }
}
