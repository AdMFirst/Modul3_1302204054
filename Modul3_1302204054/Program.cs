namespace soal_1
{
    public class KodeBuah
    {

        public enum NamaBuah
        {
            Apel, Aprikot, Alpukat, Pisang, Paprika,
            Blackberry, Ceri, Kelapa, Jagung, Kurma,
            Durian, Anggur, Melon, Semangka
        };
        private readonly String[] kode = {"A00","B00","C00","D00","E00","F00", "G00", "H00",
            "I00", "J00", "K00", "L00", "M00", "N00", "O00"};

        public String getKodeBuah(NamaBuah buah)
        {
            return kode[(int)buah];
        }
    }
}

namespace soal_2
{
    public class PosisiKarakterGame
    {
        public StatePosisi positionRightNow = StatePosisi.Berdiri;
        public enum StatePosisi
        {
            Jongkok, Berdiri, Tengkurap, Terbang
        }

        public enum TriggerPosisi
        {
            TombolS, TombolW, TombolX
        }
        public class ActionPosisi
        {
            public StatePosisi prevPosition;
            public StatePosisi nextPosition;
            public TriggerPosisi trigger;

            public ActionPosisi(StatePosisi a, StatePosisi b, TriggerPosisi c)
            {
                prevPosition = a;
                nextPosition = b;
                trigger = c;
            }
        }

        public ActionPosisi[] allPossibleAction = {
        new ActionPosisi(StatePosisi.Jongkok,StatePosisi.Berdiri,TriggerPosisi.TombolW),
        new ActionPosisi(StatePosisi.Jongkok,StatePosisi.Tengkurap,TriggerPosisi.TombolS),
        new ActionPosisi(StatePosisi.Berdiri,StatePosisi.Jongkok,TriggerPosisi.TombolS),
        new ActionPosisi(StatePosisi.Berdiri,StatePosisi.Terbang,TriggerPosisi.TombolW),
        new ActionPosisi(StatePosisi.Tengkurap,StatePosisi.Jongkok,TriggerPosisi.TombolW),
        new ActionPosisi(StatePosisi.Terbang,StatePosisi.Berdiri,TriggerPosisi.TombolS),
        new ActionPosisi(StatePosisi.Terbang,StatePosisi.Jongkok,TriggerPosisi.TombolX)
    };

        public void Trigger_Is_Triggered(TriggerPosisi button)
        {
            for (int i = 0; i < allPossibleAction.Length; i++)
            {
                if (allPossibleAction[i].trigger == button && positionRightNow == allPossibleAction[i].prevPosition)
                {
                    positionRightNow = allPossibleAction[i].nextPosition;

                    if (button == TriggerPosisi.TombolS)
                    {
                        Console.WriteLine("tombol arah bawah ditekan");
                    }
                    else if (button == TriggerPosisi.TombolW)
                    {
                        Console.WriteLine("tombol rah atas ditekan");
                    }
                    break;

                }
            }
        }

    }
}

namespace main
{
    public class Modul3
    {
        public static void Main()
        {
            soal_1.KodeBuah test = new();
            Console.WriteLine(test.getKodeBuah(soal_1.KodeBuah.NamaBuah.Apel));

            soal_2.PosisiKarakterGame testPlayer = new();
            Console.WriteLine("Kondisi player saat ini adalah " + testPlayer.positionRightNow);
            Console.WriteLine("Pencat W");
            testPlayer.Trigger_Is_Triggered(soal_2.PosisiKarakterGame.TriggerPosisi.TombolW);
            Console.WriteLine("Kondisi player saat ini adalah " + testPlayer.positionRightNow);
            Console.WriteLine("Pencat S");
            testPlayer.Trigger_Is_Triggered(soal_2.PosisiKarakterGame.TriggerPosisi.TombolS);
            Console.WriteLine("Kondisi player saat ini adalah " + testPlayer.positionRightNow);
            Console.WriteLine("Pencat S");
            testPlayer.Trigger_Is_Triggered(soal_2.PosisiKarakterGame.TriggerPosisi.TombolS);
            Console.WriteLine("Kondisi player saat ini adalah " + testPlayer.positionRightNow);
            Console.WriteLine("Pencat S");
            testPlayer.Trigger_Is_Triggered(soal_2.PosisiKarakterGame.TriggerPosisi.TombolS);
            Console.WriteLine("Kondisi player saat ini adalah " + testPlayer.positionRightNow);
            Console.WriteLine("Pencat W");
            testPlayer.Trigger_Is_Triggered(soal_2.PosisiKarakterGame.TriggerPosisi.TombolW);
            Console.WriteLine("Kondisi player saat ini adalah " + testPlayer.positionRightNow);
            Console.WriteLine("Pencat W");
            testPlayer.Trigger_Is_Triggered(soal_2.PosisiKarakterGame.TriggerPosisi.TombolW);
            Console.WriteLine("Kondisi player saat ini adalah " + testPlayer.positionRightNow);
            Console.WriteLine("Pencat W");
            testPlayer.Trigger_Is_Triggered(soal_2.PosisiKarakterGame.TriggerPosisi.TombolW);
            Console.WriteLine("Kondisi player saat ini adalah " + testPlayer.positionRightNow);
            Console.WriteLine("Pencat X");
            testPlayer.Trigger_Is_Triggered(soal_2.PosisiKarakterGame.TriggerPosisi.TombolX);
            Console.WriteLine("Kondisi player saat ini adalah " + testPlayer.positionRightNow);

        }
    }
}