
using EjMandalorianoBL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjMandaloriano_MAUI_MVVM.ViewModels
{
    public class clsListadoMisionesVM
    {
        public List<clsMision> listadoMisiones { get; set; }

        public clsListadoMisionesVM() {
            listadoMisiones = clsListaMisionesBL.obtenerListaMisiones();
        }
    }
}
