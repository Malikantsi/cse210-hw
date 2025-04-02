using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();


        video1._author = "James Smith";
        video1._length = 120;
        video1._title = "Product management";
        video1.AddComment("Phanton Insider ", "I love the explanation!");
        video1.AddComment("Mpho", "Great tutorial");
        video1.AddComment("Neo", "Interesting definetely goiing to try this");
        video1.AddComment("Lemo", "Lovely");

        video2._author = "Karabo";
        video2._length = 125;
        video2._title = "Ordering on our website";
        video2.AddComment("Tsosi", "Not really helpful");
        video2.AddComment("Telo", "Thanks for the help");
        video2.AddComment("Thabo", "How come i cants fine the green pay button on my side?");

        video3._author = "Kantsi";
        video3._length = 130;
        video3._title = "About us";
        video3.AddComment("Teke", "Love you guys mission statement");
        video3.AddComment("Mpati", "I am starting something like this in my country thank you");
        video3.AddComment("Seara", "where do we find you in Joburg?");


        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title:{video._title} Author:{video._author} Length:{video._length} Comments:{video.DisplayNumComments()}");
            foreach (var comment in video._comments)
            {
                comment.DisplayComment();
            }
            Console.WriteLine();

        }
        


        

        

    }
}