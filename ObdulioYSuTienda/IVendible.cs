﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public interface IVendible
    {
        public int Precio { get; set; }
        public int TiempoGarantia { get; set; }
        public double TiempoMedio();
    }
}
