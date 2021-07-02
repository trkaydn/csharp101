using System;

namespace arayuzler_interface
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur() 
        {
            return 4;
        }

        public abstract Marka HangiMarkaninAraci();

        public virtual Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}