using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public class Negocios_Sistema
    {
        Datos_Sistema objDato = new Datos_Sistema();
        public List<Entidad_Sistema> ListarSistema(string buscar)
        {
            return objDato.ListarSistema(buscar);
        }
        public void InsertandoSistema(Entidad_Sistema sistema)
        {
            objDato.InsertarSistema(sistema);
        }
        public void EditandoSistema(Entidad_Sistema sistema)
        {
            objDato.EditarSistema(sistema);
        }
        public void EliminandoSistema(Entidad_Sistema sistema)
        {
            objDato.EliminarSistema(sistema);
        }
    }
}
