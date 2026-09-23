using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
    public class Book
    {
        private int _pages;
        public string Title { get; }
        public int Pages
        {
            get => _pages;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Pages cannot be zero or negative.");
                }
                _pages = value;
            }
        }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages; // This will invoke the setter and validate the pages
        }
    }
}
