class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("User 1", "Great video!");
        video1.AddComment("User 2", "I learned a lot from this.");

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment("User 3", "Awesome content!");
        video2.AddComment("User 4", "Can't wait for the next video.");

        Video video3 = new Video("Video 3", "Author 3", 150);
        video3.AddComment("User 5", "Very informative.");
        video3.AddComment("User 6", "Thanks for sharing.");

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}