using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entidad_Sistema
    {
        private int _idSistema;
        private string _CodigoSistema;
        private string _Autobuses;
        private string  _Choferes;
        private string  _Rutas;

        public int IdSistema { set; get; }
        public string CodigoSistema { set; get; }
        public string Autobuses { set; get; }
        public string Choferes { set; get; }
        public string Rutas { set; get; }
    }
}
