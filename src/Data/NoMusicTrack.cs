namespace NoMusicPaid.Data;

public class NoMusicTrack
{
    public string? id;
    public string? title;
    public NoMusicGenre genre;

    public string GetDownloadLink()
    {
        return $"https://drive.google.com/uc?authuser=0&id={id}&export=download";
    }

    public string GetEmbedLink()
    {
        return $"https://docs.google.com/uc?export=download&id={id}";
    }
}