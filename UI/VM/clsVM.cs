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
            try
            {
                // Inicializar la lista
                listadoCaballosConRazas = new ObservableCollection<clsCaballoConRazas>();


                // Obtener datos desde la capa BL
                List<clsCaballo> caballos = clsManejadoraCaballosBLBD.listadoCompletoCaballosBL();
                List<clsRaza> razas = clsManejadoraRazasBLBD.listadoCompletoRazasBL();

                clsRaza razaPreterminada = new clsRaza(0, "SELECCIONE UNA OPCION");

                // Para que aparezca en la primera línea la raza preterminada
                razas.Insert(0,razaPreterminada);

                


                // Llenar lista con objetos clsCaballoConRazas
                foreach (var caballo in caballos)
                {
                    clsCaballoConRazas caballoConRazas = new clsCaballoConRazas(caballo,razas);
                    listadoCaballosConRazas.Add(caballoConRazas);
                }

                actualizar = new DelegateCommand(actualizar_execute);

            }
            catch (Exception ex)
            {
                // TODO: Avisar al usuario mediante un display alert que algo ha pasado con la BD
            }
            
        }




        #endregion

        #region Métodos

        private async void actualizar_execute()
        {
            int numFilasAfectadas = 0;

            //TODO: Código que actualice la raza de los caballos cambiados
            foreach(clsCaballoConRazas caballo in listadoCaballosConRazas)
            {
                //Esto seria si es en local
                //numFilasAfectadas +=  clsManejadoraCaballosBL.actualizarRazaCaballoBL(caballo.IdCaballo, caballo.RazaSeleccionada.IdRaza);
                
                if(caballo.RazaSeleccionada.IdRaza != 0 && caballo.IdRaza != caballo.RazaSeleccionada.IdRaza)
                {
                    numFilasAfectadas += clsManejadoraCaballosBLBD.actualizarRazaCaballoBL(caballo.IdCaballo, caballo.RazaSeleccionada.IdRaza);
                }
                
            }

            await Application.Current.MainPage.DisplayAlert("Enhorabuena", "Se han actualizado " + numFilasAfectadas + " caballos", "OK"); 
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
