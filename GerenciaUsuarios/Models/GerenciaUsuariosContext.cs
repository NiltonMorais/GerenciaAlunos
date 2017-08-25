using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GerenciaUsuarios.Models
{
    public class GerenciaUsuariosContext: DbContext
    {
        public GerenciaUsuariosContext(): base("DefaultConnection")
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}