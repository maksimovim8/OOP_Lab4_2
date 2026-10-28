using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_2
{
    internal class Comment
    {
        public string Author;
        public string Text;
        public DateTime CreatedAt;

         public Comment(string author, string text)
        {
            Author = author;
            Text = text;
            CreatedAt = DateTime.Now;
        }


        // Виводить автора, дату створення та текст коментаря
        public void DisplayInfo()
        {
            Console.WriteLine("Comment by: " + Author);
            Console.WriteLine("\nComment added: " + CreatedAt.ToString());
            Console.WriteLine(Text);
        }

    }
}
