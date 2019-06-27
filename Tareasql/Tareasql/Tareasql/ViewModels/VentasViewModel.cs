using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using Tareasql.Models;

namespace Tareasql.ViewModels
{
    public class VentasViewModel
    {
        private SQLiteConnection conec;
        private static VentasViewModel instance;
        public static VentasViewModel Instance
        {
            get
            {
                if (instance == null) { throw new Exception("Falta inicializar"); }
                return instance;
            }
        }

        public static void Inicializador(String filename)
        {
            if (filename == null) { throw new ArgumentException(); }
            if (instance != null) { instance.conec.Close(); }
            instance = new VentasViewModel(filename);
        }

        private VentasViewModel(String DbPath)
        {
            conec = new SQLiteConnection(DbPath);
            conec.CreateTable<Ventas>();
        }
        public String EstadoMensaje;

        public IEnumerable<Ventas> GetAllVentas()
        {
            try
            {
                return conec.Table<Ventas>();
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }
            return Enumerable.Empty<Ventas>();
        }
    }
}
