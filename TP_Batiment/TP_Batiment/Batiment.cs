using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Batiment
{
    public class Batiment
    {
        protected string adresse;

        public Batiment()
        {
            this.adresse = "????";
        }

        public Batiment(string adresse)
        {
            this.adresse = adresse;
        }

        public string getAdresse()
        {
            return this.adresse;
        }

        public void setAdresse(string adresse)
        {
            this.adresse = adresse;
        }

        public override string ToString()
        {
            return "Le batiment a pour adresse " + this.adresse;
        }
    }
}
