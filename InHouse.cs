using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProjectDLyn
{
    class InHouse : Part
    {
        private int v1;
        private string text;
        private decimal v2;
        private int v3;
        private int v4;
        private int v5;
        private int v6;

        //Inhouse constructor with parameters
        public InHouse (int pID, string n, int inS, decimal price, int min, int max, int mID)
            :base(pID, n, inS, price, min, max)
        {
            MachineID = mID;
        }

        public InHouse ( string n, int inS, decimal price, int min, int max, int mID)
            :base(n, inS, price, min, max)
        {
            MachineID = mID;
        }

        
        public int MachineID { get; set; }

    }
}
