using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Entidades
{
    public class Compra
    {
        public virtual int Id { get; set; }
        public virtual int CantItems { get; set; }
        public virtual decimal CostoTotal { get; set; }
        public virtual DateTime Fecha { get; set; }

        public Compra(int id, int cantItems, decimal costoTotal, DateTime fecha)
        {
            Id = id;
            CantItems = cantItems;
            CostoTotal = costoTotal;
            Fecha = fecha;
        }

        public Compra()
        {
            Id = 0;
            CantItems = 0;
            CostoTotal = 0;
            Fecha = DateTime.Now;
        }
    }
}
