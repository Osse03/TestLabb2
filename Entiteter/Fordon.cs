﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter
{
    public class Fordon
    {
        public string FordonID { get; set; }
        public string Typ { get; set; }
        public int BattariNivå { get; set; }
        public string Status { get; set; }

        public Hyra Hyra { get; set; }

        public Användare Användare { get; set; }

    }
}
