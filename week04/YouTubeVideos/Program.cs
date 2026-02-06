using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video firstVideo = new Video("Introduction to C#", "Osawe", 300);
        firstVideo.AddComment(new Comment("Eniye", "This is a great lesson"));
        firstVideo.AddComment(new Comment("Mary", "Very helpful"));
        firstVideo.AddComment(new Comment("Paul", "Thanks for this"));
        videos.Add(firstVideo);

        Video video2 = new Video("OOP Basics", "Sarah", 100);
        video2.AddComment(new Comment("Mike", "Clear and simple"));
        video2.AddComment(new Comment("Lucy", "Nice examples"));
        video2.AddComment(new Comment("James", "I understand now"));
        videos.Add(video2);

        Video video3 = new Video("Classes in C#", "David", 540);
        video3.AddComment(new Comment("Emma", "Well explained"));
        video3.AddComment(new Comment("Chris", "Good pacing"));
        video3.AddComment(new Comment("Ben", "Loved it"));
        video3.AddComment(new Comment("Friday", "never mind"));
        video3.AddComment(new Comment("Emeka", "boring"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author:" + video.GetAuthor());
            Console.WriteLine("Lenght: "+ video.GetLenght());
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("- " + comment.GetName() + ": " + comment.GetText());
            }

            Console.WriteLine();
        }
    }
}




public class Comment
{
    private string _name;
    private string _text;

    // public constructor
    public Comment(string name, string text)
    {
        _name=name;
        _text=text;
    }

    // method to get name 
    public string GetName()
    {
        return _name;
    }
    // method to get text
    public string GetText()
    {
        return _text;
    }

}


public class Video
{
    private string _title;
    private string  _author;
    private int _lenght;

    private List<Comment> _comment;

    public Video(string title, string author, int length)
    {
        _title=title;
        _author=author;
        _lenght=length;
        _comment=new List<Comment>();

    }
    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public int GetCommentCount()
    {
        return  _comment.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    // get the Author of the video
    public string GetAuthor()
    {
        return _author;
    }
    // to get the lenght of comments
    public int GetLenght()
    {
        return _lenght;
    }
    // to get list of comments
    public List<Comment> GetComments()
    {
        return _comment;
    }
}