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
        public string _resultado;
        public string _operadorSigno;
        public string _mostrarPantalla;
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
        public string MostrarPantalla
        {
            get { return _mostrarPantalla; }
            set { SetValue(ref _mostrarPantalla, value); }
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
            Numero1 = true;
            

        }
        public void OperadorNumero2()
        {
            MostrarDigito += "2";
            Numero2 = true;
        } 
        public void OperadorNumero3()
        {
            MostrarDigito += "3";
            Numero3 = true;
        } 
        public void OperadorNumero4()
        {
            MostrarDigito += "4";
            Numero4 = true;
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
        //public void OperadorSumar()
        //{
        //    OperadorAsignado = true;
        //    ObtenerNumeros();
        //    MostrarDigito = "+";
        //    OperadorSumarBool = true;
        //}


        //public void OperadorRestar()
        //{
        //    OperadorAsignado = true;
        //    ObtenerNumeros();
        //    MostrarDigito = "-";
        //    OperadorRestarBool = true;
        //} 
        //public void OperadorMultiplicar()
        //{
        //    OperadorAsignado = true;
        //    ObtenerNumeros();
        //    MostrarDigito = "*";
        //    OperadorMultiplicarBool = true;

        //} 
        // public void OperadorDividir()
        //{
        //    OperadorAsignado = true;
        //    ObtenerNumeros();
        //    MostrarDigito = "÷";
        //    OperadorDividirBool = true;
        //} 

        




        public void Limpiar()
        {
            MostrarDigito = "";
        }

        //public void ObtenerNumeros()
        //{
        //    if (OperadorAsignado == true) //AQUI DEBE DE IR EL OPERADOR 
        //    {
        //        NumeroOperador1 = Convert.ToDouble(MostrarDigito);
        //    }
        //    else
        //    {
        //        NumeroOperador2 = Convert.ToDouble(MostrarDigito);
        //    }
        //}
        //public void ObtenerNumeros()
        //{
        //    if (!OperadorAsignado) // Si no se ha asignado un operador, entonces el número es el primer operando
        //    {
        //        NumeroOperador1 = Convert.ToDouble(MostrarDigito);
        //        OperadorAsignado = true;
        //    }
        //    else
        //    {
        //        NumeroOperador2 = Convert.ToDouble(MostrarDigito);
        //    }
        //}


        //public void SumarNumeros()
        //{
        //    if (OperadorAsignado == true)
        //    {
        //        NumeroOperador2 = Convert.ToDouble(MostrarDigito); // Asignar el segundo número antes de sumar
        //        mostrarDigitoApoyo = NumeroOperador1 + NumeroOperador2;
        //    }
        //}
        //public void RestarNumeros()
        //{
        //    if (OperadorAsignado == true)
        //    {
        //        NumeroOperador2 = Convert.ToDouble(MostrarDigito); // Asignar el segundo número antes de sumar
        //        mostrarDigitoApoyo = NumeroOperador1 - NumeroOperador2;
        //    }
        //} 
        //public void MultiplicarNumeros()
        //{
        //    if (OperadorAsignado == true)
        //    {
        //        NumeroOperador2 = Convert.ToDouble(MostrarDigito); 
        //        mostrarDigitoApoyo = NumeroOperador1 * NumeroOperador2;
        //    }
        //}
        //public void DividirNumeros()
        //{
        //    if (OperadorAsignado == true)
        //    {
        //        NumeroOperador2 = Convert.ToDouble(MostrarDigito); // Asignar el segundo número antes de sumar
        //        mostrarDigitoApoyo = NumeroOperador2 / NumeroOperador1;
        //    }
        //}

        //public void MostrarNumeros()
        //{
        //    if (OperadorSumarBool == true)
        //    {
        //        SumarNumeros();

        //    }
        //    else if(OperadorRestarBool == true)
        //    {
        //        RestarNumeros();

        //    }
        //    else if(OperadorMultiplicarBool == true)
        //    {
        //        MultiplicarNumeros();

        //    }
        //    else if(OperadorDividirBool == true)
        //    {
        //        DividirNumeros();

        //    }
        //    MostrarDigito = Convert.ToString(mostrarDigitoApoyo);
        //}


        //AAAAA
        public void OperadorSumar()
        {
            ObtenerNumeros();
            MostrarDigito = "+";
            OperadorSumarBool = true;
        }

        public void OperadorRestar()
        {
            ObtenerNumeros();
            MostrarDigito = "-";
            OperadorRestarBool = true;
        }

        public void OperadorMultiplicar()
        {
            ObtenerNumeros();
            MostrarDigito = "*";
            OperadorMultiplicarBool = true;
        }

        public void OperadorDividir()
        {
            ObtenerNumeros();
            MostrarDigito = "/";
            OperadorDividirBool = true;
        }

        public void ObtenerNumeros()
        {
            if (!OperadorAsignado) // Si no se ha asignado un operador, entonces el número es el primer operando
            {
                NumeroOperador1 = Convert.ToDouble(MostrarDigito);
                OperadorAsignado = true;
            }
            else
            {
                NumeroOperador2 = Convert.ToDouble(MostrarDigito);
            }
        }

        public void SumarNumeros()
        {
            mostrarDigitoApoyo = NumeroOperador1 + NumeroOperador2;
        }

        public void RestarNumeros()
        {
            mostrarDigitoApoyo = NumeroOperador1 - NumeroOperador2;
        }

        public void MultiplicarNumeros()
        {
            mostrarDigitoApoyo = NumeroOperador1 * NumeroOperador2;
        }

        public void DividirNumeros()
        {
            mostrarDigitoApoyo = NumeroOperador1 / NumeroOperador2;
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
