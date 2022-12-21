using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausurvorbereitung_483 {
     class MeineKlasse : IVersuch {
        private static string woerter;

        public static void MachMal ( ) { }

        public static void Add(string s ) {
            woerter = s;
        }
        public static string ZeigMal ( ) {
            return woerter;
        }

        public void InstanzMethode ( ) { }

        public void VersuchsMal ( ) {
            
        }
    }
}