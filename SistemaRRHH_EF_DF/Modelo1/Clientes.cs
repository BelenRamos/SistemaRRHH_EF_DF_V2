﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo1
{
    public partial class Clientes
    {
        public Clientes()
        {
            ClientesTelefonos = new HashSet<ClientesTelefonos>();
            OlClientes = new HashSet<OlClientes>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }

        public virtual ICollection<ClientesTelefonos> ClientesTelefonos { get; set; }
        public virtual ICollection<OlClientes> OlClientes { get; set; }
    }
}
