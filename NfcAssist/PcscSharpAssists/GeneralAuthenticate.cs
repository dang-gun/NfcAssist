﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcscSharpAssists
{
    public class GeneralAuthenticate
    {
        public byte Version { get; } = 0x01;
        public byte Msb { get; set; }
        public byte Lsb { get; set; }
        public KeyType KeyType { get; set; }
        public byte KeyNumber { get; set; }

        public byte[] ToArray()
        {
            return new[] { Version, Msb, Lsb, (byte)KeyType, KeyNumber };
        }
    }
}
