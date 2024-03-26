using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChatAplikacijaNiOP
{
    internal class Razgovor
    {
        private int id;
        private Korisnik brojKorisnika;
        private bool aktivan;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Korisnik BrojKorisnika
        {
            get { return brojKorisnika; }
            set { brojKorisnika = value; }
        }

        public bool Aktivan
        {
            get { return aktivan; }
            set { aktivan = value; }
        }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((Razgovor)obj).id);

            return rez;
        }
        public override string ToString()
             
           => Aktivan.ToString() + "," + BrojKorisnika.ToString() + "->" + Id.ToString();
    }
}
