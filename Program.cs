class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa103022300009 data = new DataMahasiswa103022300009();

        data.ReadJSON();

        Console.WriteLine("");

        DataMahasiswa103022300009 dataKuliah = new DataMahasiswa103022300009();

        dataKuliah.ReadJSON();
    }
}