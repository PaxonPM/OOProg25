


class Movie
{
    // instance fields
    // _navnForVariable
    // keyword = public, private
    private string _title;
    private string _genre;
    private int _year;
    private bool _wonAnOscar;
    private double _imbRating;
    private int _watched;
    

    // constructur
    // Movie objMovie = new Movie("Django", "action", 2014, false, 8.4)
    // Movie obj2Movie = new Movie("klassefesten", "comedy", 2018, false, 7.3)
    public Movie(string tit, string gen, int ye, bool oscar, double rating)
    {
        _title = tit;
        _genre = gen;
        _year = ye;
        _wonAnOscar = oscar;
        _imbRating = rating;
        _watched = 0;
    }


    public int Watched
    {
        get { return _watched; }
    }


    // method
    public string PrintMovie()
    {
        return $"Title: {_title}\nGenre: {_genre}\nYear: {_year}\nWon an oscar?: {_wonAnOscar}\nRating on imdb: {_imbRating}";

    }

    public void Watch()
    {
        _watched = _watched + 1;
    }


}

