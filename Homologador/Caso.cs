﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homologador
{
    public class Caso
    {
        public int Grupo { get; set; }
        public string  Descripcion { get; set; }
        public string Documento { get; set; }
        public int Lines { get; set; }
        public string Estado { get; set; }
        public bool HasNotaCredit { get; set; }
        public bool HasNotaDebit { get; set; }
    }
}
