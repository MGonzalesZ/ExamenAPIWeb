using System;
using System.Collections.Generic;

namespace ExamenAPIWeb.DAL.DataContext
{
    public partial class Telefono
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? NumeroTelefonico { get; set; }
    }
}
