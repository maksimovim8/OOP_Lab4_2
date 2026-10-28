using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_2
{
    class Post
    {
        public DateTime Date;
        public string Text;
        public int LikesCount;
        public List<Comment> Comments;
        public string Author;

        public Post(string author, string text)
        {
            Author = author;
            Text = text;
            LikesCount = 0;
            Date = DateTime.Now;
            Comments = new List<Comment>();
        }


        // Збільшує кількість лайків поста на 1
        public void Like()
        {
            LikesCount++;
        }


        // Додає переданий коментар до списку коментарів поста
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }


        // Виводить повну інформацію про пост, а саме
        // автора, дату створення, текст, кількість лайків
        // та всі коментарі.
        public void PostInfo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("User: " + Author);
            Console.WriteLine("Date: " + Date);
            Console.WriteLine(Text);
            Console.WriteLine("Likes: " + LikesCount);
            Console.WriteLine("\nComments");

            foreach (Comment comment in Comments)
            {
                comment.DisplayInfo();
            }
            Console.WriteLine("---------------------------------");
        }
        

    }
}
