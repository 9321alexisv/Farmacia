﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasFarmacia
{
    public class VentaItem
    {
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
    }
}
