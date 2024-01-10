using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplikacijaNiOP
{
    internal class PodaktovniKontekst
    {
        private List<Korisnik> korisnici;
        private List<Poruke> poruke;
        private List<Razgovor> razgovori;

        public List<Korisnik> Korisnici { get { return korisnici; } }
        public List<Poruke> Poruke { get{ return poruke; } }
        public List<Razgovor> Razgovori { get { return razgovori; } }


    }
}
