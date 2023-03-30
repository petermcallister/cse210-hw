using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create 3-4 videos
        var videos = new List<Video>()
        {
            new Video("Funny Cats", "John Doe", 120),
            new Video("Cooking with Jamie", "Jamie Oliver", 300),
            new Video("Gardening Tips", "Jane Smith", 180),
            new Video("Fitness for Beginners", "Joe Johnson", 240)
        };

        // Add 3-4 comments for each video
        videos[0].AddComment(new Comment("Alice", "This is hilarious!"));
        videos[0].AddComment(new Comment("Bob", "I can't stop watching it!"));
        videos[0].AddComment(new Comment("Charlie", "My cat does the same thing!"));

        videos[1].AddComment(new Comment("David", "Great recipe, Jamie!"));
        videos[1].AddComment(new Comment("Emma", "I'll definitely try this at home."));
        videos[1].AddComment(new Comment("Frank", "I love your accent, Jamie!"));

        videos[2].AddComment(new Comment("Grace", "Thanks for the tips, Jane!"));
        videos[2].AddComment(new Comment("Henry", "I'm inspired to start my own garden."));
        videos[2].AddComment(new Comment("Isabella", "What's the name of that flower?"));

        videos[3].AddComment(new Comment("Jack", "I'm out of breath already!"));
        videos[3].AddComment(new Comment("Katie", "I'll join your fitness class, Joe."));
        videos[3].AddComment(new Comment("Liam", "Do you have any tips for back pain?"));

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
