
double netPriceBook = 30;
double netPriceDVD = 50;
double netPriceGame = 100;

int noOfBooksInOrder = 0;
int noOfDVDsInOrder = 12;
int noOfGamesInOrder = 4;

double totalOrders = noOfDVDsInOrder + noOfBooksInOrder;

double totalNetPrice = netPriceBook * noOfBooksInOrder + 
                       netPriceDVD * noOfDVDsInOrder + 
                       netPriceGame * noOfGamesInOrder;

bool receiveSpecialOffer1 = false;
bool receiveSpecialOffer2 = false;
bool receiveSpecialOffer3 = false;
bool receiveSpecialOffer4 = false;
bool receiveSpecialOffer5 = false;

if (totalNetPrice > 1000)
{
    // SO#1
    receiveSpecialOffer1 = true;
}

if (noOfBooksInOrder > noOfGamesInOrder)
{
    // SO#2
    receiveSpecialOffer2 = true;
}
if (noOfBooksInOrder > 10 || noOfDVDsInOrder > 10 || noOfGamesInOrder > 10)
{
    // SO#3
    receiveSpecialOffer3 = true;
}
if ((totalOrders > 10 && totalOrders < 20) || noOfGamesInOrder >= 5)
{
    // SO#4
    receiveSpecialOffer4 = true;
}
int count = 0;
if (receiveSpecialOffer1) count++;
if (receiveSpecialOffer2) count++;
if (receiveSpecialOffer3) count++;
if (receiveSpecialOffer4) count++;

if (count == 2)
{
    receiveSpecialOffer5 = true;
}



Console.WriteLine($"You ordered {noOfBooksInOrder} books, " +
                  $"{noOfDVDsInOrder} DVDs and " +
                  $"{noOfGamesInOrder} games");

Console.WriteLine($"You qualify for special offer #1 : {receiveSpecialOffer1}");
Console.WriteLine($"You qualify for special offer #2 : {receiveSpecialOffer2}");
Console.WriteLine($"You qualify for special offer #3 : {receiveSpecialOffer3}");
Console.WriteLine($"You qualify for special offer #4 : {receiveSpecialOffer4}");
