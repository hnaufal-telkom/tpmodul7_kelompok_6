// See https://aka.ms/new-console-template for more information

class Program {
  public static void Main(string[] args) {
    DataMahasiswa103022300163 data = new DataMahasiswa103022300163();

    data.ReadJSON();
    
    Console.WriteLine("");

    KuliahMahasiswa103022300163 dataKuliah = new KuliahMahasiswa103022300163();

    dataKuliah.ReadJSON();
  }
}
