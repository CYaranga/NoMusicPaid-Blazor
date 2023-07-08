using System.Data;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using static System.Net.WebRequestMethods;

namespace NoMusicPaid.Data;

public class NoMusic
{
    public string? id;
    public string? title;
    public NoMusicGenre genre;
    public List<NoMusicTrack>? tracks;

    public string GetDownloadLink()
    {
        return $"https://drive.google.com/uc?authuser=0&id={id}&export=download";
    }

    public string GetEmbedLink()
    {
        return $"https://docs.google.com/uc?export=download&id={id}";
    }

    public async Task<List<NoMusic>> GetData()
    {
        var result = new List<NoMusic>();
        try
        {
            using var client = new HttpClient();
            string content = await client.GetStringAsync("data/NoMusicData.csv");

            using var reader = new StringReader(content);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            };

            using var csv = new CsvReader(reader, config);
            using var dr = new CsvDataReader(csv);

            var dt = new DataTable();
            dt.Load(dr);

            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return result;
        }
    }
}