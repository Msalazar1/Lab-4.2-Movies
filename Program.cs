
using System;
using System.Collections.Generic;


namespace Lab_4._2_Movies
{
    class Movie
    {
        private string MovieName;
        private string MovieCat;

        public Movie(string Title, string Category)
        {
            MovieName = Title;
            MovieCat = Category;

        }

        public string Title
        {
            get
            {
                return MovieName;
            }
        }
        public string Category
        {
            get
            {
                return MovieCat;
            }
        }


    }

        class Program
        {
            static void Main(string[] args)
            {

                List<Movie> movieList = new List<Movie>
                {
                    new Movie("Mad Max Beyond Thunderdome", "SciFi"),
                    new Movie("Return of the Jedi", "SciFi"),
                    new Movie("Krull", "SciFi"),
                    new Movie("Grandmas Boy", "Comedy"),
                    new Movie("Billy Madison", "Comedy"),
                    new Movie("Happy Gilmore", "Comedy"),
                    new Movie("Iron Man", "Action"),
                    new Movie("Thor Ragnarok", "Action"),
                    new Movie("Doctor Strange", "Action"),
                    new Movie("Salems Lot", "Horror"),
                    new Movie("A Nightmare on Elm Street", "Horror"),
                    new Movie("Silver Bullet", "Horror")
                };



            bool keepgoing = true;
                while (keepgoing)
                {
                    Console.WriteLine("Welcome to Movie Mania! We list movies so you don't have to!");
                    Console.WriteLine();
                    Console.WriteLine($"There are {movieList.Count} movies in this list."); // add count here
                    Console.WriteLine();
                    Console.WriteLine("The categories for today are: SciFi, Comedy, Action, and Horror.  Choose your category: ");

                    string entry = Console.ReadLine().ToLower();

                    if (!(entry == "scifi" || entry == "comedy" || entry == "action" || entry == "horror"))
                    {
                        Console.WriteLine("Invalid category.  Try again.");
                    }


                    if (entry == "scifi")
                    {
                        foreach (var m in movieList)
                        {
                            if (m.Category == "scifi")
                            {
                                Console.WriteLine(m.Title);
                            }
                            /*if (m.Category == "comedy")
                            {
                                Console.WriteLine(m.Title);
                            }
                            if (m.Category == "action")
                            {
                                Console.WriteLine(m.Title);
                            }
                            if (m.Category == "horror")
                            {
                                Console.WriteLine(m.Title);
                            }*/
                            
                            

                        }
                    }
                    Console.WriteLine("Would you like to choose another?  yes/no");

                    string goAgain = Console.ReadLine().ToLower();

                    if (goAgain == "yes")
                    {
                        keepgoing = true;
                    }
                    else
                    {
                        keepgoing = false;
                        {
                            Console.WriteLine("Thanks for visiting Movie Mania!");
                        }
                    }
                }

            }  //Had to give up on this one.  Couldn't get the list to print for the life of me.  I tried so many different things... it's probably something really small that I forgot.  I will revisit this!
        }
    
}
 