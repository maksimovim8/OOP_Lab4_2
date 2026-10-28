using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_2
{
    internal class User
    {
        public string Name { get; }
        public string Email { get; }
        public string Nickname { get; } //@nickname

        private List<Post> Posts = new List<Post>();

        
        public User(string name, string email, string nickname)
        {
            Name = name;
            Email = email;
            Nickname = nickname;
        }


        // Створює новий пост, додає його до списку користувача
        // та повертає створений об'єкт.
        public Post CreatePost(string text)
        {
            Post post = new Post(Nickname, text);
            Posts.Add(post);
            return post;
        }

        // Видаляє пост зі списку користувача.
        // Якщо пост не знайдено, то виводить повідомлення про помилку.
        public void DeletePost(Post post)
        {
            if (Posts.Remove(post))
            {
                Console.WriteLine("Post deleted.");
            }
            else
            {
                Console.WriteLine("You can`t delete this post.");
            }
        }



        // Виводить інформацію про останні п'ять постів користувача починаючи з останнього.
        // Якщо постів менше п'яти, то виводить усі наявні.
        public void GetLastFivePost()
        {
            if (Posts.Count == 0)
            {
                Console.WriteLine("No posts available.");
                return;
            }

            int lastPost = Posts.Count-1;
            int count = 0;

            foreach(Post post in Posts)
            {
                if (count == 5)
                {
                    break;
                }

                Posts[lastPost].PostInfo();
                count++;
                lastPost--;
            }
        }


        // Дозволяє переглянути останні п'ять постів іншого користувача.
        // Якщо передано самого себе, то виводить попередження.
        public void ViewPost(User user) 
        {
            if (user == this)
            {
                Console.WriteLine("Chose another user");
                return;
            }
            Console.WriteLine("Latest posts of " + user.Nickname);
            user.GetLastFivePost();
        }

        // Ставить лайк під вибраним постом та виводить повідомлення.
        public void LikePost(Post post)
        {
            post.Like();
            Console.WriteLine("Post liked");
        }


        // Створює коментар від імені вибраного користувача,
        // додає його до поста та виводить повідомлення.
        public void CommentPost(Post post, string comment)
        {
            Comment newComment = new Comment(Nickname, comment);
            post.AddComment(newComment);

            Console.WriteLine("Comment added.");
        }
    }
}
