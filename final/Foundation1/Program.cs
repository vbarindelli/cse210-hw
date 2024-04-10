using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Blueberry Cupcakes", "EmiCooks", 300);
        Comment comment1 = new Comment("Sergio", "This receipe was amazing. Will do it again.");
        Comment comment2 = new Comment("Ceci", "Can I replace all purpose flour with whole wheat?.");
        Comment comment3 = new Comment("Mirna", "These were so good! I made them for my daughter's b-day and everybody loved them.");

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        Video video2 = new Video("Cheese Scons", "VirBar", 450);
        Comment comment4 = new Comment("Caro", "This was so easy to do!");
        Comment comment5 = new Comment("Patsy", "Mine did not rise, any ideas?");
        Comment comment6 = new Comment("Sofi", "Do you have a recipe for marinara somewhere?");
        Comment comment7 = new Comment("Jack", "I have moved away from home and this will be my first try at cooking. Wish me luck.");

        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2._comments.Add(comment7);
        
        Video video3 = new Video("Old fashioned pancakes", "Iris", 350);
        Comment comment8 = new Comment("Flor", "These remind me of my grandma's pancakes.");
        Comment comment9 = new Comment("Vir", "I have tried this recipe three times now and cannot get it right. I think there is something off with the measurments.");
        Comment comment10 = new Comment("Diego", "Can I freeze these?");
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        

        Video video4 = new Video("Pizza dough", "EmiCooks", 500);
        Comment comment11 = new Comment("Sergio", "You can never go wrong with homemade pizza.");
        Comment comment12 = new Comment("Fede", "Can I make this with glutten free flour mix?.");
        Comment comment13 = new Comment("Diego", "Can I freeze these?");

        video4._comments.Add(comment11);
        video4._comments.Add(comment12);
        video4._comments.Add(comment13);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Lenght: {video._lenght}");
           
            video.commentsTracking();

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"Name: {comment._name}.");
                Console.WriteLine($"Comment: {comment._comment}");

            }
        }

    }
}
