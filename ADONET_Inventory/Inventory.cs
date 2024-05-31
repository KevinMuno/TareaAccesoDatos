using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Inventory
{
    public class Inventory
    {
        public int ID { get; set; }
        public int MakeId { get; set; }
        public string PetName { get; set; }
        public string Color {  get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
