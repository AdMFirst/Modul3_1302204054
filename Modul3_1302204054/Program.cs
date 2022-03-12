
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

public class PosisiKarakterGame
{
    public statePosisi positionRightNow = statePosisi.Berdiri;
    public enum statePosisi
    {
        Jongkok, Berdiri, Tengkurap, Terbang
    }

    public enum triggerPosisi
    {
        TombolS, TombolW, TombolX
    }
    public class actionPosisi
    {
        public statePosisi prevPosition;
        public statePosisi nextPosition;
        public triggerPosisi trigger;

        public actionPosisi(statePosisi a,statePosisi b,triggerPosisi c)
        {
            prevPosition = a;
            nextPosition = b;
            trigger = c;
        }
    }

    public actionPosisi[] allPossibleAction = {
        new actionPosisi(statePosisi.Jongkok,statePosisi.Berdiri,triggerPosisi.TombolW),
        new actionPosisi(statePosisi.Jongkok,statePosisi.Tengkurap,triggerPosisi.TombolS),
        new actionPosisi(statePosisi.Berdiri,statePosisi.Jongkok,triggerPosisi.TombolS),
        new actionPosisi(statePosisi.Berdiri,statePosisi.Terbang,triggerPosisi.TombolW),
        new actionPosisi(statePosisi.Tengkurap,statePosisi.Jongkok,triggerPosisi.TombolW),
        new actionPosisi(statePosisi.Terbang,statePosisi.Berdiri,triggerPosisi.TombolS),
        new actionPosisi(statePosisi.Terbang,statePosisi.Jongkok,triggerPosisi.TombolX)
    };

    public void triggerIsTriggered(triggerPosisi button)
    {
        for(int i = 0; i < allPossibleAction.Length; i++)
        {
            if(allPossibleAction[i].trigger == button && positionRightNow == allPossibleAction[i].prevPosition)
            {
                positionRightNow = allPossibleAction[i].nextPosition;
                
                if(button == triggerPosisi.TombolS)
                {
                    Console.WriteLine("tombol arah bawah ditekan");
                } else if (button == triggerPosisi.TombolW)
                {
                    Console.WriteLine("tombol rah atas ditekan");
                }
                break;

            }
        }
    }

}

public class main
{
    public static void Main(String[] args)
    {
        KodeBuah test = new KodeBuah();
        Console.WriteLine(test.getKodeBuah(KodeBuah.namaBuah.Apel));

        PosisiKarakterGame bapakKamu = new PosisiKarakterGame();
        Console.WriteLine("Kondisi player saat ini adalah "+ bapakKamu.positionRightNow);
        Console.WriteLine("Pencat W");
        bapakKamu.triggerIsTriggered(PosisiKarakterGame.triggerPosisi.TombolW);
        Console.WriteLine("Kondisi player saat ini adalah " + bapakKamu.positionRightNow);
        Console.WriteLine("Pencat S");
        bapakKamu.triggerIsTriggered(PosisiKarakterGame.triggerPosisi.TombolS);
        Console.WriteLine("Kondisi player saat ini adalah " + bapakKamu.positionRightNow);
        Console.WriteLine("Pencat S");
        bapakKamu.triggerIsTriggered(PosisiKarakterGame.triggerPosisi.TombolS);
        Console.WriteLine("Kondisi player saat ini adalah " + bapakKamu.positionRightNow);
        Console.WriteLine("Pencat S");
        bapakKamu.triggerIsTriggered(PosisiKarakterGame.triggerPosisi.TombolS);
        Console.WriteLine("Kondisi player saat ini adalah " + bapakKamu.positionRightNow);
        Console.WriteLine("Pencat W");
        bapakKamu.triggerIsTriggered(PosisiKarakterGame.triggerPosisi.TombolW);
        Console.WriteLine("Kondisi player saat ini adalah " + bapakKamu.positionRightNow);
        Console.WriteLine("Pencat W");
        bapakKamu.triggerIsTriggered(PosisiKarakterGame.triggerPosisi.TombolW);
        Console.WriteLine("Kondisi player saat ini adalah " + bapakKamu.positionRightNow);
        Console.WriteLine("Pencat W");
        bapakKamu.triggerIsTriggered(PosisiKarakterGame.triggerPosisi.TombolW);
        Console.WriteLine("Kondisi player saat ini adalah " + bapakKamu.positionRightNow);
        Console.WriteLine("Pencat X");
        bapakKamu.triggerIsTriggered(PosisiKarakterGame.triggerPosisi.TombolX);
        Console.WriteLine("Kondisi player saat ini adalah " + bapakKamu.positionRightNow);

    }
}