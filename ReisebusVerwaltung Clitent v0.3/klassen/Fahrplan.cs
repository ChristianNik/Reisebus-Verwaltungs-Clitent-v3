using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisebusVerwaltung_Clitent_v0._3
{
    public class Fahrplan
    {
        private int fahrplanID;
        private string abfahrtsZeit;
        private DateTime abfahrtdatum;
        private string fahrtdauer;
        private double fahrpreis;

        public Fahrplan()
        {
            //leer
        }

        public Fahrplan(int fahrplanID, string abfahrtsZeit, DateTime abfahrtdatum, string fahrtdauer, double fahrpreis)
        {
            this.FahrplanID = fahrplanID;
            this.AbfahrtsZeit = abfahrtsZeit;
            this.Abfahrtdatum = abfahrtdatum;
            this.Fahrtdauer = fahrtdauer;
            this.Fahrpreis = fahrpreis;
        }

        public int FahrplanID { get => fahrplanID; set => fahrplanID = value; }
        public string AbfahrtsZeit { get => abfahrtsZeit; set => abfahrtsZeit = value; }
        public DateTime Abfahrtdatum { get => abfahrtdatum; set => abfahrtdatum = value; }
        public string Fahrtdauer { get => fahrtdauer; set => fahrtdauer = value; }
        public double Fahrpreis { get => fahrpreis; set => fahrpreis = value; }
    }
}
