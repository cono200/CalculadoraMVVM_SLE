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
        public double _resultado; //AUXILIAR
        public string _operadorSigno;
        public string _mostrarSigno;
        public bool _numero0;
        public bool _numero1;
        public bool _numero2;
        public bool _numero3;
        public bool _numero4;
        public double _numero5;
        public double _numero6;
        public double _numero7;
        public double _numero8;
        public double _numero9;
        public double _signoMultiplicar;
        public bool _signoRestar;
        public bool _signoSumar;
        public double _signoDividir;
        public string _mostrarDigito;
        private bool _operadorAsignado;
        public double mostrarDigitoApoyo;
        private bool _operadorSumarBool;
        private bool _operadorRestarBool;
        private bool _operadorMultiplicarBool;
        private bool _operadorDividirBool;
        public string Operador;
        private bool _numeroSeleccionado;

         private double _contador;


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
        
        public double Auxiliar
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        public string OperadorSigno
        {
            get { return _operadorSigno; }
            set { SetValue(ref _operadorSigno, value); }
        } 
        public string MostrarSigno
        {
            get { return _mostrarSigno; }
            set { SetValue(ref _mostrarSigno, value); }
        }
        public bool Numero0
        {
            get { return _numero0; }
            set { SetValue(ref _numero0, value); }
        }
         public bool Numero1
        {
            get { return _numero1; }
            set { SetValue(ref _numero1, value); }
        }
        public bool Numero2
        {
            get { return _numero2; }
            set { SetValue(ref _numero2, value); }
        }
        public bool Numero3
        {
            get { return _numero3; }
            set { SetValue(ref _numero3, value); }
        }  
        public bool Numero4
        {
            get { return _numero4; }
            set { SetValue(ref _numero4, value); }
        }
        public double Numero5
        {
            get { return _numero5; }
            set { SetValue(ref _numero5, value); }
        } 
        public double Numero6
        {
            get { return _numero6; }
            set { SetValue(ref _numero6, value); }
        } 
        public double Numero7
        {
            get { return _numero7; }
            set { SetValue(ref _numero7, value); }
        }
        public double Numero8
        {
            get { return _numero8; }
            set { SetValue(ref _numero8, value); }
        }
        public double Numero9
        {
            get { return _numero9; }
            set { SetValue(ref _numero9, value); }
        } 
        public string MostrarDigito
        {
            get { return _mostrarDigito; }
            set { SetValue(ref _mostrarDigito, value); }
        }
        public bool OperadorAsignado
        {
            get { return _operadorAsignado; }
            set { SetValue(ref _operadorAsignado, value); }
        }
        public bool SignoSumar
        {
            get { return _signoSumar; }
            set { SetValue(ref _signoSumar, value); }
        }
        public bool OperadorSumarBool
        {
            get { return _operadorSumarBool; }
            set { SetValue(ref _operadorSumarBool, value); }
        }
        public bool OperadorRestarBool
        {
            get { return _operadorRestarBool; }
            set { SetValue(ref _operadorSumarBool, value); }
        }
         public bool OperadorMultiplicarBool
        {
            get { return _operadorMultiplicarBool; }
            set { SetValue(ref _operadorMultiplicarBool, value); }
        } 
        public bool OperadorDividirBool
        {
            get { return _operadorDividirBool; }
            set { SetValue(ref _operadorDividirBool, value); }
        } 
        public bool NumeroSeleccionado
        {
            get { return _numeroSeleccionado; }
            set { SetValue(ref _numeroSeleccionado, value); }
        }
        public double Contador
        {
            get { return _contador; }
            set { SetValue(ref _contador, value); }
        }


      

        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoSimple()
        {

        }

        //INTENTO DE BINEAR LOS NUMEROS
        public void OperadorNumero1()
        {

            MostrarDigito += "1";
            
            

        }
        public void OperadorNumero0()
        {

            MostrarDigito += "0";
            
            

        }
        public void OperadorNumero2()
        {
            MostrarDigito += "2";
            
        } 
        public void OperadorNumero3()
        {
            MostrarDigito += "3";
            
        } 
        public void OperadorNumero4()
        {
            MostrarDigito += "4";
            
        }
        public void OperadorNumero5()
        {
            MostrarDigito += "5";
            
        }
        public void OperadorNumero6()
        {
            MostrarDigito += "6";
           
        }
        public void OperadorNumero7()
        {
            MostrarDigito += "7";
           
        } 
        public void OperadorNumero8()
        {
            MostrarDigito += "8";
            
        }
        public void OperadorNumero9()
        {
            MostrarDigito += "9";
            
        }
        public void OperadorSumar()
        {
            OperadorAsignado = true;
            ObtenerNumeros();
            //MostrarSigno += " + ";
            OperadorSumarBool = true;
        }


        public void OperadorRestar()
        {
            OperadorAsignado = true;
            ObtenerNumeros();
            //MostrarSigno += " - ";
            OperadorRestarBool = true;
        }
        public void OperadorMultiplicar()
        {
           // MostrarSigno += " * ";
            OperadorAsignado = true;
            ObtenerNumeros();
            
            OperadorMultiplicarBool = true;

        }
        public void OperadorDividir()
        {
            OperadorAsignado = true;
            ObtenerNumeros();
            //MostrarSigno = "÷";
            OperadorDividirBool = true;
        }






        public void Limpiar()
        {
            MostrarDigito = "";
        }

        public void ObtenerNumeros()
        {

            if ( NumeroOperador1 == 0 )
            {
                NumeroOperador1 = Convert.ToDouble(MostrarDigito);
               



            }
           
            else if(MostrarDigito == Convert.ToString(Auxiliar))
            {
                MostrarDigito = string.Empty;
            }

            else
            {
                
                NumeroOperador2 = Convert.ToDouble(MostrarDigito);

                
            }
            
            
            
            
            
        }

      
        public void SumarNumeros()
        {
            ObtenerNumeros();
            if (OperadorAsignado == true)
            {
                mostrarDigitoApoyo = NumeroOperador1 + NumeroOperador2;
            }
        }
        public void RestarNumeros()
        {
            ObtenerNumeros();
            if (OperadorAsignado == true)
            {
                mostrarDigitoApoyo = NumeroOperador1 - NumeroOperador2;
            }
        }
        public void MultiplicarNumeros()
        {
        ObtenerNumeros();
            if (OperadorAsignado == true)
            {
                mostrarDigitoApoyo = NumeroOperador1 * NumeroOperador2;
                
            }
        }
        public void DividirNumeros()
        {
            ObtenerNumeros();
            if (OperadorAsignado == true)
            {
                mostrarDigitoApoyo = NumeroOperador2 / NumeroOperador1;
            }
        }

        public void MostrarNumeros()
        {
            if (OperadorSumarBool == true)
            {
                SumarNumeros();
               

            }
            else if (OperadorRestarBool == true)
            {
                RestarNumeros();

            }
            else if (OperadorMultiplicarBool == true)
            {
                MultiplicarNumeros();

            }
            else if (OperadorDividirBool == true)
            {
                DividirNumeros();

            }
            MostrarDigito = Convert.ToString(mostrarDigitoApoyo);
            
        }

        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand Limpiarcomand => new Command(Limpiar);
        public ICommand OperadorNumero0comand => new Command(OperadorNumero0);
        public ICommand OperadorNumero1comand => new Command(OperadorNumero1);
        public ICommand OperadorNumero2comand => new Command(OperadorNumero2);
        public ICommand OperadorNumero3comand => new Command(OperadorNumero3);
        public ICommand OperadorNumero4comand => new Command(OperadorNumero4);
        public ICommand OperadorNumero5comand => new Command(OperadorNumero5);
        public ICommand OperadorNumero6comand => new Command(OperadorNumero6);
        public ICommand OperadorNumero7comand => new Command(OperadorNumero7);
        public ICommand OperadorNumero8comand => new Command(OperadorNumero8);
        public ICommand OperadorNumero9comand => new Command(OperadorNumero9);
        public ICommand OperadorSumarcomand => new Command(OperadorSumar);
        public ICommand OperadorRestarcomand => new Command(OperadorRestar);
        public ICommand OperadorMultiplicarcomand => new Command(OperadorMultiplicar);
        public ICommand OperadorDividircomand => new Command(OperadorDividir);

        public ICommand ObtenerNumeroscomand => new Command(MostrarNumeros);
        #endregion

    }
}
