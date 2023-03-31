using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create 3-4 videos
        var videos = new List<Video>()
        {
            new Video("Eating a 30 inch meatball sub", "Meatball Mack", 120),
            new Video("Cooking with Karen", "The Karen", 300),
            new Video("Baking Pretzels", "Pretzel Master", 180),
            new Video("Getting Big without Tren", "Tren Twins", 240)
        };

        // Add 3-4 comments for each video
        videos[0].AddComment(new Comment("Alex", "This is hilarious!"));
        videos[0].AddComment(new Comment("Bob", "I can't stop watching it!"));
        videos[0].AddComment(new Comment("Charlie", "I can't believe he actually did that!"));

        videos[1].AddComment(new Comment("David", "Great recipe!"));
        videos[1].AddComment(new Comment("Emma", "I'll definitely try this at home."));
        videos[1].AddComment(new Comment("Frank", "I love your personality"));

        videos[2].AddComment(new Comment("Grace", "Thanks for the tips!"));
        videos[2].AddComment(new Comment("Henry", "I'm inspired to start my own pretzel shop!"));
        videos[2].AddComment(new Comment("Isabella", "What yeast do you use?"));

        videos[3].AddComment(new Comment("Jack", "This saved my marriage!"));
        videos[3].AddComment(new Comment("Katie", "I'll join your regimen!"));
        videos[3].AddComment(new Comment("Liam", "How many calories do you eat in a day?"));

        // Iterate through the list of videos and display their information
        foreach (var video in videos)
        {
            Console.WriteLine("Title: {0}", video.Title);
            Console.WriteLine("Author: {0}", video.Author);
            Console.WriteLine("Length: {0} seconds", video.Length);
            Console.WriteLine("Number of comments: {0}", video.NumberOfComments());
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine("- {0}: {1}", comment.Name, comment.Text);
            }
            Console.WriteLine();
        }
    }
}
