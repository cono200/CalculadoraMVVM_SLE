using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculadoraMVVM_SLE.VistaModelo
{
    public class VMCalcular : BaseViewModel
    {
        #region VARIABLES
        public double _numeroOperador1;
        public double _numeroOperador2;
        public string _operadorTexto1;
        public string _operadorTexto2;
        private string _resultado;
        private string _operadorSigno;

        #endregion
        #region CONSTRUCTOR
        public VMCalcular(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public double NumeroOperador1
        {
            get { return _numeroOperador1; }
            set { SetValue(ref _numeroOperador1, value); }
        }
        public double NumeroOperador2
        {
            get { return _numeroOperador2; }
            set { SetValue(ref _numeroOperador2, value); }
        }
        public string OperadorTexto1
        {
            get { return _operadorTexto1; }
            set { SetValue(ref _operadorTexto1, value); }
        }
        public string OperadorTexto2
        {
            get { return _operadorTexto2; }
            set { SetValue(ref _operadorTexto2, value); }
        }
        public string Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        public string OperadorSigno
        {
            get { return _operadorSigno; }
            set { SetValue(ref _operadorSigno, value); }
        }

        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoSimple()
        {

        } 
        public void Limpiar()
        {
           NumeroOperador1 = 0;
            NumeroOperador2 = 0;
            OperadorTexto1 = "";
            OperadorTexto2 = "";
            Resultado = "";
            OperadorSigno = "";
        }

        public void Numeros()
        {

        }





        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand Limpiarcomand => new Command(Limpiar);
        #endregion

    }
}
