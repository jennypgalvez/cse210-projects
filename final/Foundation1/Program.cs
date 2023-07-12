using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("What Matters Most", "The church of Jesus Christ", 1.34);
        Video video2 = new Video("The Will of God", "The church of Jesus Christ", 3.02);
        Video video3 = new Video("The Hope of God's Light", "The church of Jesus Christ", 6.46);

        video1.AddComment(new Comment("Sandy", "President Monson's reminder to SHOW love to others has helped me strengthen and deepen my relationships with my family.  What a treasure!"));
        video1.AddComment(new Comment("PetsNPatients", "Yes, this message is a truth that can't be denied.  "));
        video1.AddComment(new Comment("gillbarr1", "One of the most important messages to learn.  Never be afraid to tell someone that you love them"));

        video2.AddComment(new Comment("noodleproduction", "This is exactly what I needed to hear. Brought tears to my eyes…"));
        video2.AddComment(new Comment("ErickLopez", "My favorite video of all time… I wish everyone reading this the best in life no matter what you may be going through "));

        video3.AddComment(new Comment("angie266", "I've felt God's light. It's so warm and peaceful and euporhic"));

        List<Video> videos = new List<Video> {video1, video2, video3};

        foreach (Video video in videos)
        {
            video.DisplayDetails();
        }
    }
}