﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect.Network.Packets.Client
{
    public class RetrieveBagItemPacket : CerasPacket
    {
        public int Slot { get; set; }
        public int Quanity { get; set; }

        public RetrieveBagItemPacket(int slot, int qty)
        {
            Slot = slot;
            Quanity = qty;
        }
    }
}