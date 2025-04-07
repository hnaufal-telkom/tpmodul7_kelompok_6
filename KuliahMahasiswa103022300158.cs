using System.Text.Json;
using System.Text.Json.Serialization;

public class MataKuliah
{
    [JsonPropertyName("code")]
    public string Kode { get; set; }

    [JsonPropertyName("name")]
    public string Nama { get; set; }
}

public class KuliahMahasiswa
{
    [JsonPropertyName("courses")]
    public MataKuliah[] MataKuliah { get; set; }
}

public class KuliahMahasiswa1234567890
{
    public void ReadJSON()
    {
        try
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "tp7_2_103022300158.json");
            string jsonString = File.ReadAllText(filePath);
            
            KuliahMahasiswa data = JsonSerializer.Deserialize<KuliahMahasiswa>(jsonString);

            if (data?.MataKuliah == null || data.MataKuliah.Length == 0)
            {
                Console.WriteLine("Tidak ada mata kuliah yang diambil.");
                return;
            }

            Console.WriteLine("Daftar mata kuliah yang diambil:");

            for (int i = 0; i < data.MataKuliah.Length; i++)
            {
                Console.WriteLine($"MK {i + 1} {data.MataKuliah[i].Kode} - {data.MataKuliah[i].Nama}");
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File JSON tidak ditemukan: {ex.Message}");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error parsing JSON: {ex.Message}");
        }
    }
}