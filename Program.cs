// See https://aka.ms/new-console-template for more information

class Program {
  public static void Main(string[] args) {
    DataMahasiswa103022330140 data = new DataMahasiswa103022330140();

    data.ReadJSON();
    
    Console.WriteLine("");

    KuliahMahasiswa103022330140 dataKuliah = new KuliahMahasiswa103022330140();

    dataKuliah.ReadJSON();
  }
}
