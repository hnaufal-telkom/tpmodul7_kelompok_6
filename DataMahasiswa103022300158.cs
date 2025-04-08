using System.Text.Json;
using System.Text.Json.Serialization;

public class Nama
{
    [JsonPropertyName("depan")]
    public string NamaDepan { get; set; }

    [JsonPropertyName("belakang")]
    public string NamaBelakang { get; set; }
}

public class DataMahasiswa
{
    [JsonPropertyName("nama")]
    public Nama Nama { get; set; }

    [JsonPropertyName("nim")]
    public string NIM { get; set; }

    [JsonPropertyName("fakultas")]
    public string Fakultas { get; set; }
}

public class DataMahasiswa103022300158
{
    public void ReadJSON()
    {
        try
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "tp7_1_103022300158.json");

            string jsonString = File.ReadAllText(filePath);

            DataMahasiswa data = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);

            if (data == null)
            {
                Console.WriteLine("Data kosong.");
                return;
            }

            Console.WriteLine(
                $"Nama {data.Nama.NamaDepan} {data.Nama.NamaBelakang} " +
                $"dengan NIM {data.NIM} dari fakultas {data.Fakultas}"
            );
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File tidak ditemukan: {ex.Message}");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Format JSON tidak valid: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
        }
    }
}