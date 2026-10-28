namespace Lab4_2
{
    class Program
    {
        static void Main()
        {
            //Симуляція постів, він же твітер, зроблений за булку з маком

            //Створення користувачів і постів
            User Oleg = new User("Oleg", "olegpro@gmail.com", "@oleleg7");
            User Ivan = new User("Ivan", "hdhdh@gmail.com", "@IvanLOl");

            Post post1 = Oleg.CreatePost("Test 1. Hi, I`m Oleg. ffhhfhfh");
            Post post2 = Oleg.CreatePost("Test 2. I like play minecraft.");
            Post post3 = Oleg.CreatePost("Test 3");
            Post post4 = Oleg.CreatePost("Test 4");
            Post post5 = Oleg.CreatePost("test 5");
            Post post6 = Oleg.CreatePost("Test 6");

            Console.ReadLine();

            // Інший користувач переглядає пости
            Ivan.ViewPost(Oleg);
            Console.ReadLine();

            //Інший користувач ставить лак під постом і коментує. Потім показується пост, який прокоментували
            Ivan.LikePost(post1);
            Ivan.CommentPost(post1, "Cool, me too.");

            post1.PostInfo();
            Console.ReadLine();

            //Сворення ще одного поста і перегляд останніх 5 постів самого користувача
            Console.Clear();

            Post post8 = Oleg.CreatePost("Test 8 . I like apple");
            Oleg.GetLastFivePost();
            Console.ReadLine();

            //Видалення поста користувача
            Console.WriteLine("\n Пiсля видалення останнього поста");
            Oleg.DeletePost(post8);
            Oleg.GetLastFivePost();
            Console.ReadLine();
        }
    }
}
