﻿namespace tpmodul4_1302223040.p
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


    public class DoorMachine
    {
        public enum State { TERKUNCI, TERBUKA }
        State state = State.TERKUNCI;
        
        public void ChangeState(State newState)
        {
            state = newState;
            if (state == State.TERKUNCI)
            {
                Console.WriteLine("Pintu terkunci");
            }
            else if (state == State.TERBUKA)
            {
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        public void DisplayState()
        {
            Console.WriteLine("Status Pintu Sekarang: " + state);
        }
    }

    internal class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kode pos Batununggal: " + KodePos.GetKodePos(KodePos.Kelurahan.Batununggal));
                
            DoorMachine machine = new DoorMachine();
            machine.DisplayState();
            machine.ChangeState(DoorMachine.State.TERBUKA);
            machine.DisplayState();
            machine.ChangeState(DoorMachine.State.TERKUNCI);
            machine.DisplayState();
        }
    }
}
