
public class KodeBuah
{

    public enum namaBuah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika,
        Blackberry, Ceri, Kelapa, Jagung, Kurma,
        Durian, Anggur, Melon, Semangka
    };
    private String[] kode = {"A00","B00","C00","D00","E00","F00", "G00", "H00",
            "I00", "J00", "K00", "L00", "M00", "N00", "O00"};

    public String getKodeBuah(namaBuah buah)
    {
        return kode[(int)buah];
    }
}

public class 

public class main
{
    public static void Main(String[] args)
    {
        KodeBuah test = new KodeBuah();
        Console.WriteLine(test.getKodeBuah(KodeBuah.namaBuah.Apel));
    }
}