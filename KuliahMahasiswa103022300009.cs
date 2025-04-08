using System.Text.Json;
using System.Text.Json.Serialization;

class DataKuliah
{
    [JsonPropertyName("courses")]
    public Course[] Courses { get; set; }
}

class Course
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

class KuliahMahasiswa103022300009
{

    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_2_103022300009.json");

        try
        {
            DataKuliah data = JsonSerializer.Deserialize<DataKuliah>(jsonString);

            if (data == null)
            {
                Console.WriteLine("Deserialization Failed");
                return;
            }

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < data.Courses.Length; i++)
            {
                Console.WriteLine($"MK {i + 1} {data.Courses[i].Code} - {data.Courses[i].Name}");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

}