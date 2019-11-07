using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    public class Sala
    {
        public String nombreEven { get; set; }
        public String fecha { get; set; }
        public String hora { get; set; }

        List<Asientos> ls = new List<Asientos>();
        public List<Asientos> listSala { get => ls; set => ls = value; }

        public Sala(string nombreEven, string fecha, string hora)
        {
            this.nombreEven = nombreEven;
            this.fecha = fecha;
            this.hora = hora;
        }
    }
}
