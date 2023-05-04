// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Board _board = new Board();

/*
Source source = new Source("None Were With Him","http://www.churchofjeuschrist.org");
Quote holland = new Quote("Elder Holland","Because Jesus walked such a long, lonely path....",source);
_board.AddQuote(holland);
_board.FindQuotesByAuthor("holland");
*/

_board.AddQuote(
    new Quote(
        "Paul",
        "God hath not given us the spirit of fear; but of power, and of love, and of a sound mind.",
        new Source("2 Timothy 1:7")
    )
);

_board.AddQuote(
    new Quote(
        "Sister Elaine S. Dalton",
        "Work hard to achieve your dreams. Don't let discouragement or mistakes delay you.",
        new Source(
        "How to Dare Great Things",
        "https://www.churchofjesuschrist.org/study/new-era/2012/03/how-to-dare-great-things?lang=eng"
        )
    )
);

_board.AddQuote(
    new Quote(
        "Alma",
        "If ye have faith ye hope for things which are not seen, which are true.",
        new Source(
        "Alma 32:21"
    ))
);

_board.AddQuote(
    new Quote(
        "Alma",
        "Live in thanksgiving daily.",
        new Source(
        "Alma 34:38"
    ))
);

_board.AddQuote(
    new Quote(
        "Alma",
        "Counsel with the Lord in all thy doings, and he will direct thee for good.",
        new Source(
        "Alma 37:37"
    ))
);

//_board.GetRandomQuote();

Menu _menu = new Menu(_board);
_menu.Display();