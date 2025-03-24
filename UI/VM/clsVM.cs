using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UI.Models;
using UI.VM.Utils;

namespace UI.VM
{
    public class clsVM : INotifyPropertyChanged
    {

        #region Atributos

        private ObservableCollection<clsCaballoConRazas> listadoCaballosConRazas;
        private DelegateCommand actualizar;


        #endregion

        #region Propiedades

        public ObservableCollection<clsCaballoConRazas > ListadoCaballosConRazas { 

            get
            {
                return listadoCaballosConRazas;
            }
        
        }

        public DelegateCommand Actualizar { 
            get 
            { 
                return actualizar; 
            } 
        }

        #endregion

        #region Constructores

        public clsVM()
        {
            // Inicializar la colección
            listadoCaballosConRazas = new ObservableCollection<clsCaballoConRazas>();

            // Obtener datos desde la capa BL
            List<clsCaballo> caballos = clsManejadoraCaballosBL.obtenerTodosLosCaballosBL();
            List<clsRaza> razas = clsManejadoraRazasBL.obtenerTodasLasRazasBL();

            // Poblar la colección con objetos clsCaballoConRazas
            foreach (var caballo in caballos)
            {
                listadoCaballosConRazas.Add(new clsCaballoConRazas(caballo, razas));
            }
        }

        #endregion

        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")

        {

            PropertyChanged?.Invoke(this, new
            PropertyChangedEventArgs(propertyName));

        }
        #endregion

    }
}
