using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljka_nasljedivanje
{
    class Biljka
    {
    }
    class Cvijet : Biljka
    {
    }

    class Stablo : Biljka
    {
        bool otpadajuListovi;
        //svojstvo
        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }

        //konstruktor
        public Stablo(bool otpadajuListovi1)
        {
            otpadajuListovi = otpadajuListovi1;
        }
    }
    class Bjelogoricno : Stablo
    {
        bool _otpadajuListovi;
        public Bjelogoricno(bool otpadajuListovi1) : base(otpadajuListovi1)
        {
            _otpadajuListovi = otpadajuListovi1;
        }
        public override string ToString()
        {
            return "Otpadaju listovi = " + _otpadajuListovi;
        }
    }
    class Crnogoricno : Stablo
    {
        bool _otpadajuListovi;
        
        public Crnogoricno(bool otpadajuListovi1) : base(otpadajuListovi1)
        {
            _otpadajuListovi = otpadajuListovi1;
        }

        public override string ToString()
        {
            return "Otpadaju listovi = " + _otpadajuListovi;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Crnogoricno bor = new Crnogoricno(false);
            Bjelogoricno hrast = new Bjelogoricno(true);

            Console.WriteLine("Hrast: " + hrast.ToString());
            Console.WriteLine("Bor: " + bor.ToString());

            Console.ReadKey();
        }
    }
}
