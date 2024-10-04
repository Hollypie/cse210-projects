using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to make Borscht", "Vlad Romonoph", 2000);
        Comment comment1a = new Comment("Shasha", "You're Borscht is Pink and weak :(");
        Comment comment1b = new Comment("Anya", "Your recipe reminds me of my Ukrainian grandmother. Thank you.");
        Comment comment1c = new Comment("Boris", "I'll be making this recipe today.");
        Comment comment1d = new Comment("Vladimir", "My mother makes it with fermented beets.");
        video1.AddComment(comment1a);
        video1.AddComment(comment1b);
        video1.AddComment(comment1c);
        video1.AddComment(comment1d);

        Video video2 = new Video("Knitting mittens", "Maude Hancock", 3587);
        Comment comment2a = new Comment("Emma Dewey", "I was having such trouble with the thumb part, thankyou for this.");
        Comment comment2b = new Comment("Janis", "The noise in the background was so distracting, film when it's quiet.");
        Comment comment2c = new Comment("Justin the Worst", "Your hair is stupid");
        
        video2.AddComment(comment2a);
        video2.AddComment(comment2b);
        video2.AddComment(comment2c);

        Video video3 = new Video("Monster Monster Trucks", "RGT 5000 Rich", 1586);
        Comment comment3a = new Comment("Chuck Dudemeister", "sick rims dude.");
        Comment comment3b = new Comment("John Doe", "Ouch, He'll be feeling that later.");
        Comment comment3c = new Comment("Roy Dierder", "This is totally fake. Stop supporting this AI created crap.");
        
        video3.AddComment(comment3a);
        video3.AddComment(comment3b);
        video3.AddComment(comment3c);
        

         Video video4 = new Video("My cute Kitty Cat", "Becky Hollinger", 456);
        Comment comment4a = new Comment("Ginny Williams", "So cute, I could eat her up.");
        Comment comment4b = new Comment("Jack the Teenager", "Your cat is dumb with it's dumb face and dumb fur and your dumb face and your dumb hair. Life sucks.");
        Comment comment4c = new Comment("Fairy Velma", "This looks exactly like the cat my neighbors lost. Clearly you stole her. I'm calling the police.");
        video4.AddComment(comment4a);
        video4.AddComment(comment4b);
        video4.AddComment(comment4c);
        

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.Display();
        }

        
    }
}