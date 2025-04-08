// See https://aka.ms/new-console-template for more information

class Program {
  public static void Main(string[] args) {
    // Naufal
    DataMahasiswa103022300163 dataN = new DataMahasiswa103022300163();

    dataN.ReadJSON();
    
    Console.WriteLine("");

    KuliahMahasiswa103022300163 dataKuliahN = new KuliahMahasiswa103022300163();

    dataKuliahN.ReadJSON();
    
    // Fathir
    DataMahasiswa103022300009 dataF = new DataMahasiswa103022300009();

    dataF.ReadJSON();

    Console.WriteLine("");

    DataMahasiswa103022300009 dataKuliahF = new DataMahasiswa103022300009();

    dataKuliahF.ReadJSON();
    
    // Haidar
    DataMahasiswa103022330140 dataH = new DataMahasiswa103022330140();

    dataH.ReadJSON();
    
    Console.WriteLine("");

    KuliahMahasiswa103022330140 dataKuliahH = new KuliahMahasiswa103022330140();

    dataKuliahH.ReadJSON();
  }
}
