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
        public clsMision MisionSeleccionada { get { return misionSeleccionada; } set { misionSeleccionada = value; } }
        public DelegateCommand MostrarDetallesCommand { 
            get {
                mostrarDetallesCommand = new DelegateCommand(MostrarContenidoCommand_Execute, MostrarDetallesCommand_CanExecute);
                return mostrarDetallesCommand; 
            } }  
        public bool DatosMisionEsVisible { get { return datosMisionEsVisible; } }
        #endregion

        #region Constructores
        #endregion

        #region Comandos
        /// <summary>
        /// Descripcion:Metodo que muestra los detalles de la mision seleccionada haciendo visibles 3 labels mediante el bool datosMisionEsVisible
        /// </summary>
        private void MostrarContenidoCommand_Execute()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool MostrarDetallesCommand_CanExecute()
        {
            return true;
        }
        #endregion

    }
}
