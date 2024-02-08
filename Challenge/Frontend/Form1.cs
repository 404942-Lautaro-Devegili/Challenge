using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Frontend.Datos;
using Frontend.Entidades;

namespace Frontend
{
    public partial class frmCompras : Form
    {
        public ISessionFactory sessionFactory;
        public HelperDao DBHelper;
        public int filtro = 0;
        public int descOascID = 0;
        public int descOascCantItems = 0;
        public int descOascCostoTotal = 0;
        public int descOascFecha = 0;
        public frmCompras()
        {
            InitializeComponent();
            DBHelper = new HelperDao();
        }

        private List<Compra> GetCompras()
        {
            return DBHelper.TraerCompras();
        } 

        private void AgregarRows(List<Compra> comprasAAñadir)
        {
            foreach (var compraAAñadir in comprasAAñadir)
            {
                string fechaFormateada = formatearFecha(compraAAñadir.Fecha);

            dgvHistCompras.Rows.Add(compraAAñadir.Id, compraAAñadir.CantItems, compraAAñadir.CostoTotal, fechaFormateada, compraAAñadir.Fecha);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Compra> Compras = GetCompras();
            AgregarRows(Compras);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvHistCompras.Rows.Clear();
            List<Compra> Compras = GetCompras();
            if (filtro == 0)
            {
                List<Compra> ComprasFiltradas = new List<Compra>();
                foreach (Compra c in Compras)
                {
                    if (c.CostoTotal > 1000)
                    {
                        ComprasFiltradas.Add(c);
                    }
                }
                AgregarRows(ComprasFiltradas);
                filtro = 1;
                btnFiltrar.Text = "Quitar Filtro";
            } else
            {
                AgregarRows(Compras);
                filtro = 0;
                btnFiltrar.Text = "Filtrar Mayores 1000";
            }

        }

        private void OrdernarPorFecha()
        {

            if (descOascFecha == 0)
            {
                dgvHistCompras.Sort(dgvHistCompras.Columns[4], ListSortDirection.Descending);
                descOascFecha = 1;
            }
            else
            {
                dgvHistCompras.Sort(dgvHistCompras.Columns[4], ListSortDirection.Ascending);
                descOascFecha = 0;
            }

        }

        private void OrdernarPorID()
        {
            if (descOascID == 0)
            {
                dgvHistCompras.Sort(dgvHistCompras.Columns[0], ListSortDirection.Descending);
                descOascID = 1;
            }
            else
            {
                dgvHistCompras.Sort(dgvHistCompras.Columns[0], ListSortDirection.Ascending);
                descOascID = 0;
            }
        }

        private void OrdernarPorCostoTotal()
        {
            if (descOascCostoTotal == 0)
            {
                dgvHistCompras.Sort(dgvHistCompras.Columns[2], ListSortDirection.Descending);
                descOascCostoTotal = 1;
            }
            else
            {
                dgvHistCompras.Sort(dgvHistCompras.Columns[2], ListSortDirection.Ascending);
                descOascCostoTotal = 0;
            }
        }

        private void OrdernarPorCantItems()
        {
            if (descOascCantItems == 0)
            {
                dgvHistCompras.Sort(dgvHistCompras.Columns[1], ListSortDirection.Descending);
                descOascCantItems = 1;
            }
            else
            {
                dgvHistCompras.Sort(dgvHistCompras.Columns[1], ListSortDirection.Ascending);
                descOascCantItems = 0;
            }
        }

        private string formatearFecha(DateTime fecha)
        {
            DateTime fechaOriginal = DateTime.ParseExact(fecha.ToString(), "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            string fechaFormateada = fechaOriginal.ToString("dd 'de' MMMM 'de' yyyy", new System.Globalization.CultureInfo("es-ES"));

            return fechaFormateada;
        }

            

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            OrdernarPorFecha();
        }

        private void btnOrdenarPorItems_Click(object sender, EventArgs e)
        {
            OrdernarPorCantItems();
        }

        private void btnOrdenarPorId_Click(object sender, EventArgs e)
        {
            OrdernarPorID();
        }

        private void btnOrdenarPorCosto_Click(object sender, EventArgs e)
        {
            OrdernarPorCostoTotal();
        }
    }
}
