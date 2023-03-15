using System;

public class PesawatTempur : Pesawat 
{
    public void terbangtinggi()
    {
        Console.WriteLine (
            "Pesawat tempur dengan nama {0} \n" +
                            "yang mempunyai jumlah roda {1} \n"+
                            "sedang berada pada ketinggian {2} \n"+
                            "dengan membawa penumpang sebanyak {3} \n"+
                            "akan meledakan senjata",
        this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
        Console.WriteLine();
    }
}