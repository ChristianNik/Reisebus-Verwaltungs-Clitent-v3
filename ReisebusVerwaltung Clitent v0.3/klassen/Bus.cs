using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisebusVerwaltung_Clitent_v0._3
{
    public class Bus
    {
        private int busID;
        private int ausstattungsID;
        private int sitzplanID;
        private bool hasWlan;
        private bool hasToilet;
        private bool hasDrinks;
        private int countSeats;
        private int countReclining;
        private int countSleeping;

        public Bus()
        {
            //leer
        }

        public Bus(int busID, int ausstattungsID, int sitzplanID, bool hasWlan, bool hasToilet, bool hasDrinks, int countSeats, int countReclining, int countSleeping)
        {
            this.BusID = busID;
            this.AusstattungsID = ausstattungsID;
            this.SitzplanID = sitzplanID;
            this.HasWlan = hasWlan;
            this.HasToilet = hasToilet;
            this.HasDrinks = hasDrinks;
            this.CountSeats = countSeats;
            this.CountReclining = countReclining;
            this.CountSleeping = countSleeping;
        }

        public int BusID { get => busID; set => busID = value; }
        public int AusstattungsID { get => ausstattungsID; set => ausstattungsID = value; }
        public int SitzplanID { get => sitzplanID; set => sitzplanID = value; }
        public bool HasWlan { get => hasWlan; set => hasWlan = value; }
        public bool HasToilet { get => hasToilet; set => hasToilet = value; }
        public bool HasDrinks { get => hasDrinks; set => hasDrinks = value; }
        public int CountSeats { get => countSeats; set => countSeats = value; }
        public int CountReclining { get => countReclining; set => countReclining = value; }
        public int CountSleeping { get => countSleeping; set => countSleeping = value; }
    }
}
