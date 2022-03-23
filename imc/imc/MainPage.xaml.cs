using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
           InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double alt = Convert.ToDouble(Altura.Text);
            double pe = Convert.ToDouble(Peso.Text);
            double imc;

            imc = pe / (alt * alt);
            string res;
            if (imc < 18.5)
            {
                res = "ABAIXO DO PESO";
            } else if (imc < 24.9)
            {
                res = "PESO NORMAL";
            } else if (imc < 29.9)
            {
                res = "OBESIDADE GRAU I";
            } else if (imc < 39.9) 
            {
                res = "OBESIDADE GRAU II";
            } else
            {
                res = "MÓRBIDA";
            }
            DisplayAlert("Calculo", res, "ok");
        }
    }
}
