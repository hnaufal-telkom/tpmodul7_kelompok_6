// See https://aka.ms/new-console-template for more information

class Program {
  public static void Main(string[] args) {
    // Naufal
    DataMahasiswa103022300163 data = new DataMahasiswa103022300163();

    data.ReadJSON();
    
    Console.WriteLine("");

    KuliahMahasiswa103022300163 dataKuliah = new KuliahMahasiswa103022300163();

    dataKuliah.ReadJSON();
    
    // Fathir
    DataMahasiswa103022300009 data = new DataMahasiswa103022300009();

    data.ReadJSON();

    Console.WriteLine("");

    DataMahasiswa103022300009 dataKuliah = new DataMahasiswa103022300009();

    dataKuliah.ReadJSON();
  }
}
