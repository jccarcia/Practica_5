namespace Practica_5
{
    public class Asientos
    {
        public int fila { get; set; }
        public int columna { get; set; }
        public int status { get; set; }

        public Asientos(int fila, int columna, int status)
        {
            this.fila = fila;
            this.columna = columna;
            this.status = status;
        }
    }

    
}