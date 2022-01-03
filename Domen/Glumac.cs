﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Glumac
    {
        public int GlumacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Pol Pol { get; set; }
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }
    }
}
