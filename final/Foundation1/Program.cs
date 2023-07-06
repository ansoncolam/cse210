using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Never say Never", "AlanAndrew", 140);
        Comment comment1 = new Comment("blueben22", "Not like it at all.");
        Comment comment2 = new Comment("cc_carson", "Amazing!");
        Comment comment3 = new Comment("D_D12392", "LOL...");
        Comment comment4 = new Comment("FloraFung", "NEVER!!!");

        Video video2 = new Video("What to expect in a Chinese Hotpot Restaurant", "Ellen133", 430);
        Comment comment5 = new Comment("grass_as_always", "@p@");
        Comment comment6 = new Comment("holyhohoho", "That's not true at all. Everything is wrong in this video...");
        Comment comment7 = new Comment("icecreammmy", "Hotpot Tonight!");

        Video video3 = new Video("The Fastest Car in the World", "JoJoBA", 600);
        Comment comment8 = new Comment("karenisthebest", "Come on...");
        Comment comment9 = new Comment("*labo*", "@karenisthebest ???");
        Comment comment10 = new Comment("mouse2222", "I perfer train");
        Comment comment11 = new Comment("nononoxxxx", "ummmmmm....");
        Comment comment12 = new Comment("over_over", "boring");

        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        video1.SetComment(comment1);
        video1.SetComment(comment2);
        video1.SetComment(comment3);
        video1.SetComment(comment4);

        video2.SetComment(comment5);
        video2.SetComment(comment6);
        video2.SetComment(comment7);

        video3.SetComment(comment8);
        video3.SetComment(comment9);
        video3.SetComment(comment10);
        video3.SetComment(comment11);
        video3.SetComment(comment12);

        Console.WriteLine("");
        foreach(Video video in videoList) {
            video.VideoDisplay();
        }

    }
}