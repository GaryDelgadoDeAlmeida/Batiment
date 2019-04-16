using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Batiment
{
    public class Maison : Batiment
    {
        private int NbPieces;

        public Maison() : base()
        {
            this.NbPieces = 0;
        }

        public Maison(string adresse, int nbPieces) : base(adresse)
        {
            this.NbPieces = nbPieces;
        }

        public int getNbPieces()
        {
            return this.NbPieces;
        }

        public void setNbPieces(int nbPieces)
        {
            this.NbPieces = nbPieces;
        }

        public override string ToString()
        {
            return "La maison a " + this.NbPieces + " pièces situé à l'adresse " + this.adresse;
        }
    }
}
