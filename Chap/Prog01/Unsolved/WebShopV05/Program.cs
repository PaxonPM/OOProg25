
double netPriceBook = 30;
double netPriceDVD = 50;
double netPriceGame = 100;

int noOfBooksInOrder = 23;
int noOfDVDsInOrder = 16;
int noOfGamesInOrder = 7;

double netPrice = noOfBooksInOrder * netPriceBook + noOfDVDsInOrder * netPriceDVD + noOfGamesInOrder * netPriceGame;
double taxAmountOfNet = netPrice * 0.10;
int shippingCost = 49;
double cardFee = (netPrice + taxAmountOfNet + shippingCost) * 0.02;

double totalPrice = netPrice + taxAmountOfNet + shippingCost + cardFee; // This variable should contain the total price for the order


Console.WriteLine($"You ordered {noOfBooksInOrder} books, " +
                  $"{noOfDVDsInOrder} DVDs and " +
                  $"{noOfGamesInOrder} games");
Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");
