using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisebusVerwaltung_Clitent_v0._3
{
    public class Buslinie
    {
        private int linienID;
        private int fahrplanID;
        private int busID;
        private string start;
        private string ende;

        public Buslinie()
        {
            //leer
        }

        public Buslinie(int linienID, int fahrplanID, int busID, string startHaltestelle, string endHaltestelle)
        {
            this.LinienID = linienID;
            this.FahrplanID = fahrplanID;
            this.BusID = busID;
            this.Start = startHaltestelle;
            this.Ende = endHaltestelle;
        }

        public int LinienID { get => linienID; set => linienID = value; }
        public int FahrplanID { get => fahrplanID; set => fahrplanID = value; }
        public int BusID { get => busID; set => busID = value; }
        public string Start { get => start; set => start = value; }
        public string Ende { get => ende; set => ende = value; }
    }
}
