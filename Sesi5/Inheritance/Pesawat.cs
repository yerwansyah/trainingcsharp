public class Pesawat
{
    public string? nama, ketinggian, jumlahPenumpang;
    public int jumlahRoda;

    public void terbang()
    {
        Console.WriteLine ("Pesawat tempur dengan nama {0} \n" +
                            "yang mempunyai jumlah roda {1} \n"+
                            "sedang berada pada ketinggian {2} \n"+
                            "dengan membawa penumpang sebanyak {3} \n"+
                            "akan meledakan senjata",
        this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
        Console.WriteLine();
    }
}
