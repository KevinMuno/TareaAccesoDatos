﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET
{
    public class Inventory
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Color { get; set; }
        public string PetName { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
