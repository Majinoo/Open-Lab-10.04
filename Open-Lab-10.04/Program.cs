using System;
namespace Open_Lab_10._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            Book LOTR2 = new Book(69,"Petrov Život");
            Book LOTR3 = new Book(200, "Dudov Kabinet", 2022, "Sci-Fi", "Majo");
            Book HOBIT = new Book();
            LOTR.Write();
            LOTR2.Write();
            LOTR3.Write();
            HOBIT.Write();
        }
        public class Book
        {
            public Book()
            {
                RelaseDate = -1;
                Pages = -1;
                Title = "-1";
                Cathegory = "-1";
                Author = "-1";
            }

            public Book(int pages, string title)
            {
                Pages = pages;
                Title = title;
                RelaseDate = -1;
                Cathegory = "-1";
                Author = "-1";
            }

            public Book(int pages, string title, int relaseDate, string cathegory, string author)
            {
                Pages = pages;
                Title = title;
                RelaseDate = relaseDate;
                Cathegory = cathegory;
                Author = author;
            }


            public string Title { get; set; }
            private int pages;
            public int Pages
            {
                get { return pages; }
                set
                {
                    if (value < 0)
                    {
                        pages = 1;
                    }
                    else
                    {
                        pages = value;
                    }
                }
            }
            public string Cathegory { get; set; }
            public string Author { get; set; }
            private int relaseDate;
            public int RelaseDate
            {
                get { return relaseDate; }
                set
                {
                    if (value < 1450 || value > 2021)
                    {
                        relaseDate = -1;
                    }
                    else
                    {
                        relaseDate = value;
                    }
                }
            }

            public void Write()
            {
                Console.WriteLine("Názov: " + Title);
                Console.WriteLine("Počet strán: " + Pages);
                Console.WriteLine("Žáner: " + Cathegory);
                Console.WriteLine("Autor: " + Author);
                Console.WriteLine("Dátum vydania: " + RelaseDate);

            }
        }
    }
}