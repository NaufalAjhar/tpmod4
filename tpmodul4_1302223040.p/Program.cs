using static tpmodul4_1302223040.p.KodePos;

namespace tpmodul4_1302223040.p
{
    public class KodePos
    {
        public enum Kelurahan
        {
            Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
        }

        public static int GetKodePos(Kelurahan kelurahan)
        {
            int[] kodePosArray =
            {
                40266, 40287, 40267, 40256, 40287, 40286,  40286, 40286, 40272, 40274, 40273  
            };

            return kodePosArray[(int)kelurahan];
        }
        
    }

    internal class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kode pos Batununggal: " + KodePos.GetKodePos(KodePos.Kelurahan.Batununggal));
        }
    }
}
