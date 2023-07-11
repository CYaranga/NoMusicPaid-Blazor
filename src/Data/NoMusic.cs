using System.Data;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using static System.Net.WebRequestMethods;

namespace NoMusicPaid.Data;

public class NoMusic
{
    public string? id;
    public string? title;
    public string? artist;
    public string? bpm;
    public string? tone;
    public string? duration;

    public string GetDownloadLink()
    {
        return $"https://docs.google.com/uc?export=download&id={id}";
    }

    public string GetEmbedLink()
    {
        return $"https://docs.google.com/uc?export=download&id={id}";
    }

    public static async Task<List<NoMusic>> GetData(string path)
    {
        var result = new List<NoMusic>();
        try
        {
            using var client = new HttpClient();
            string content = await client.GetStringAsync(path);

            using var reader = new StringReader(content);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            };

            using var csv = new CsvReader(reader, config);
            csv.Context.RegisterClassMap<NoMusicMap>();
            result = csv.GetRecords<NoMusic>().ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error from path {path}");
            Console.WriteLine(ex);
        }

        return result;
    }
}

public sealed class NoMusicMap : ClassMap<NoMusic>
{
    public NoMusicMap()
    {
        Map(m => m.id).Name("id");
        Map(m => m.title).Name("title");
        Map(m => m.artist).Name("artist");
        Map(m => m.bpm).Name("bpm");
        Map(m => m.tone).Name("tone");
        Map(m => m.duration).Name("duration");
    }
}