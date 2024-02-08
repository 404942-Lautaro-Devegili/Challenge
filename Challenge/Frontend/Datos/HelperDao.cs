using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Linq;
using System.Reflection;
using NHibernate;
using System.Xml;
using System.IO;
using Org.BouncyCastle.Utilities;
using Frontend.Entidades;
using MySqlX.XDevAPI;
namespace Frontend.Datos
{
    public class HelperDao
    {
        public ISessionFactory sessionFactory;
        private Configuration cfg;
        public HelperDao()
        {
            cfg = new Configuration();
            // Configurar la cadena de conexión
            cfg.DataBaseIntegration(db =>
            {
                db.Dialect<MySQL57Dialect>(); // O el dialecto correspondiente a tu base de datos
                db.Driver<MySqlDataDriver>();
                //db.ConnectionString = "Server=mysqlchall9368.ddns.net\r\n;Database=chaldb;User Id=ConexionBase;Password=conexionPass;";
                db.ConnectionString = "Server=mysqlchall9368.ddns.net;Database=chaldb;User Id=userAfuera;Password=passAfuera;";
                //db.ConnectionString = "Server=localhost;Database=chaldb;User Id=ConexionBase;Password=conexionPass;";
                db.LogSqlInConsole = true; // Opcional: para ver las consultas SQL en la consola
                db.LogFormattedSql = true; // Opcional: para ver las consultas SQL formateadas en la consola
            });
            //cfg.AddFile("C:\\Users\\Krlitos\\source\\repos\\Challenge\\Frontend\\Compra.hbm.xml");

            string directorioProyecto = AppDomain.CurrentDomain.BaseDirectory;

            string directorioFrontend = Path.GetFullPath(Path.Combine(directorioProyecto, "..", "..", "..", "Frontend"));

            string rutaArchivo = Path.Combine(directorioFrontend, "Compra.hbm.xml");

            cfg.AddFile(rutaArchivo);


            // Mapear las clases
            //cfg.AddAssembly(Assembly.GetExecutingAssembly());

        }

        public void CrearSesion()
        {
            sessionFactory = cfg.BuildSessionFactory();
        }

        public List<Compra> TraerCompras()
        {
            CrearSesion();
            var session = sessionFactory.OpenSession();

            var query = session.Query<Compra>();
            var result = query.ToList();
            CerrarSesion();
            return result;
        }

        private void AbrirSesion()
        {
            sessionFactory.OpenSession();
        }


        private void CerrarSesion()
        {
            sessionFactory.Close();
        }

    }
}
