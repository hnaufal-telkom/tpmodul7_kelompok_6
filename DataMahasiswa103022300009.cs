using System.Text.Json;
using System.Text.Json.Serialization;

class Data
{
    [JsonPropertyName("nama")]
    public Nama Nama { get; set; }

    [JsonPropertyName("nim")]
    public long Nim { get; set; }

    [JsonPropertyName("fakultas")]
    public string Fakultas { get; set; }
}

class Nama
{
    [JsonPropertyName("depan")]
    public string Depan { get; set; }

    [JsonPropertyName("belakang")]
    public string Belakang { get; set; }
}

class DataMahasiswa103022300009
{

    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_1_103022300009.json");

        try
        {
            Data data = JsonSerializer.Deserialize<Data>(jsonString);

            if (data == null)
            {
                Console.WriteLine("Deserialization Failed");
                return;
            }

            Console.WriteLine($"Nama {data.Nama.Depan} {data.Nama.Belakang} dengan NIM {data.Nim} dari fakultas {data.Fakultas}");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

}