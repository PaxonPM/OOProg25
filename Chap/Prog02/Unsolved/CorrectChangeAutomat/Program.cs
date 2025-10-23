int price = 266;
int payedAmount = 500;
int returnAmount = payedAmount - price;
int calcAmount = returnAmount;
int twohundred = 0;
int twentyCoin = 0;
int tenCoin = 0;
int twoCoin = 0;

while (calcAmount > 0)
{
    if (calcAmount > 200) { twohundred += 1; calcAmount -= 200; }
    else if (calcAmount > 20) { twentyCoin += 1; calcAmount -= 20; }
    else if (calcAmount > 10) { tenCoin += 1; calcAmount -= 10; }
    else if (calcAmount > 0) { twoCoin += 1; calcAmount -= 2; }

}
Console.WriteLine($"The total he needs returned is: {returnAmount}\n" +
    $"You need 200kr: {twohundred}, 20kr: {twentyCoin}, 10kr: {tenCoin}, 2kr: {twoCoin}");
