//Movie 1
string title = "Terminator 2";
string genre = "Action/sci-fi";
int year = 1991;
bool wonAnOscar = true;
double imbRating = 8.6;

//Movie 2
string title1 = "Terminator 3";
string genre1 = "Action/sci-fi";
int year1 = 2003;
bool wonAnOscar1 = false;
double imbRating1 = 6.3;

Movie movie1 = new Movie(title, genre, year, wonAnOscar, imbRating);
Movie movie2 = new Movie(title1, genre1, year1, wonAnOscar1, imbRating1);

Console.WriteLine(movie1.PrintMovie());
Console.WriteLine("-----------------------------------");
Console.WriteLine(movie2.PrintMovie());

movie1.Watch();
movie1.Watch();
movie1.Watch();

movie2.Watch();

Console.WriteLine(movie1.Watched);
Console.WriteLine(movie2.Watched);


/*
Console.WriteLine("Udskriver Movie 1 - uden funktioner: ");

Console.WriteLine("Title: " + title);
Console.WriteLine("Genre: " + genre);
Console.WriteLine("Year: " + year);
Console.WriteLine("Oscar: " + wonAnOscar);
Console.WriteLine("Rating: " + imbRating);
Console.WriteLine();



//Movie 2
string title1 = "Terminator 3";
string genre1 = "Action/sci-fi";
int year1 = 2003;
bool wonAnOscar1 = false;
double imbRating1 = 6.3;

Console.WriteLine("Udskriver Movie 2 - uden funktioner: ");

Console.WriteLine("Title: " + title1);
Console.WriteLine("Genre: " + genre1);
Console.WriteLine("Year: " + year1);
Console.WriteLine("Oscar: " + wonAnOscar1);
Console.WriteLine("Rating: " + imbRating1);
Console.WriteLine();
*/
/*
//////////////////// Med PrintMovie Funktioner //////////////////////////////////////////////////////////////////
// Direkte udskriv til Console (ikke så smart i længden!)
void PrintMovie(string title, string genre, int year, bool oscar, double rating)
{
    Console.WriteLine("Title: " + title);
    Console.WriteLine("Genre: " + genre);
    Console.WriteLine("Year: " + year);
    Console.WriteLine("Oscar: " + oscar);
    Console.WriteLine("Rating: " + rating);
}

Console.WriteLine("Udskriver Movie 1 - med PrintMovie funktionen: ");
PrintMovie(title, genre, year, wonAnOscar, imbRating);

Console.WriteLine();


// Returnere en string, som kan bruges til at udskrive til Console (Bedre løsning)
string PrintMovie2(string title, string genre, int year, bool oscar, double rating)
{
    string temp = "Title: " + title + "\n";
    temp = temp + "Genre: " + genre + "\n";
    temp += "Year: " + year + "\n";
    temp += "Oscar: " + oscar + "\n";
    temp += "Rating: " + rating;
    return temp;
}


Console.WriteLine("Udskriver Movie 2 - med PrintMovie2 funktionen og variable som argument: ");
string movie = PrintMovie2(title1, genre1, year1, wonAnOscar1, imbRating1);

Console.WriteLine(movie);
Console.WriteLine();

Console.WriteLine("Udskriver Movie 2 - med PrintMovie2 funktionen med værdier som argument: ");
Console.WriteLine(PrintMovie2("Terminator 3", "Action/Sci-fi", 2003, false, 6.3));
Console.WriteLine();


// Med string interpolation (formateret string)
string PrintMovie3(string title, string genre, int year, bool oscar, double rating)
{
    return $"Title: {title}\nGenre: {genre}\nYear: {year}\nOscar: {oscar}\nRating: {rating}";
}

Console.WriteLine("Udskriver Movie 2 - med PrintMovie3 funktionen med værdier som argument: ");
Console.WriteLine(PrintMovie3("Terminator 3", "Action/Sci-fi", 2003, false, 6.3));

*/