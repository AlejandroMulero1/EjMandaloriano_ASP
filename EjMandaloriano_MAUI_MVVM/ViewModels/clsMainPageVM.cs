
using EjMandaloriano_MAUI_MVVM.ViewModels.Utilidades;
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
    public class clsMainPageVM : clsVMBase
    {
        #region Atributos
        private List<clsMision> listaMisiones;
        private clsMision misionSeleccionada;
        private DelegateCommand mostrarDetallesCommand;
        private bool datosMisionEsVisible;
        #endregion

        #region Propiedades
        public List<clsMision> ListaMisiones { get { return listaMisiones; } }
        public clsMision MisionSeleccionada
        {
            get { return misionSeleccionada; }
            set
            {
                misionSeleccionada = value;
                MostrarDetallesCommand.RaiseCanExecuteChanged();
                //datosMisionEsVisible = false;
                //NotifyPropertyChanged("DatosMisionEsVisible");
            }
        }
        public DelegateCommand MostrarDetallesCommand
        {
            get
            {
                return mostrarDetallesCommand;
            }
        }
        public bool DatosMisionEsVisible { get { return datosMisionEsVisible; } set { datosMisionEsVisible = value; } }
        #endregion

        #region Constructores

        public clsMainPageVM()
        {
            mostrarDetallesCommand = new DelegateCommand(MostrarContenidoCommand_Execute, MostrarDetallesCommand_CanExecute);
            listaMisiones = clsListaMisionesBL.obtenerListaMisiones();
        }
        #endregion

        #region Comandos
        /// <summary>
        /// Descripcion:Metodo que muestra los detalles de la mision seleccionada haciendo visibles 3 labels mediante el bool datosMisionEsVisible
        /// Precondiciones:Ninguna
        /// Postcondiciones:Ninguna
        /// </summary>
        private void MostrarContenidoCommand_Execute()
        {
            datosMisionEsVisible = true;
            NotifyPropertyChanged("DatosMisionEsVisible");
            NotifyPropertyChanged("MisionSeleccionada");
        }
        /// <summary>
        /// Metodo que valida si hay alguna mision seleccionada para habilitar el botón 
        /// Precondiciones:Ninguna
        /// Postcondiciones:Ninguna
        /// </summary>
        /// <returns></returns>
        private bool MostrarDetallesCommand_CanExecute()
        {
            bool pulsable = true;

            //Si no hay una persona seleccionada no se puede borrar

            if (misionSeleccionada == null)

            {

                pulsable = false;

            }

            return pulsable;
        }
        #endregion

    }
}
