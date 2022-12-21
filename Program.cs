using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausurvorbereitung_483 {

    delegate int MeinDelegate ( int x , int y );

    class Program {
        static void Main ( string [ ] args ) {
            MeineKlasse mk = new MeineKlasse();
            MeineKlasse.Add("Sinn");
            MeineKlasse.ZeigMal ( );
            mk.InstanzMethode ( );

            IVersuch[] ivArr = new IVersuch[2];
            ivArr [ 0 ] = new Klasse2();
            ivArr [ 1 ] = new MeineKlasse();

            Console.WriteLine ( "======================");
            //Delegates

            MeinDelegate russi = MeineMethode ;
            Console.WriteLine ( russi(47, 11));

            //event EventHandler<EventArgs> russiEvent;
            
        
        }

        public static int MeineMethode ( int x , int y ) {
            return x + y;
        }
    }
}
