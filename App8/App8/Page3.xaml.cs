using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        double var1 = 0, var2 = 0;
        string opcion;
        public Page3()
        {
            InitializeComponent();
        }
        public void resultados()
        {
            var2 = Convert.ToDouble(resul.Text);
            if (opcion == "suma")
            {
                resul.Text = var1 + var2 + "";
            }
            else
            if (opcion == "resta")
            {
                resul.Text = var1 - var2 + "";
            }
            else
            if (opcion == "multi")
            {
                resul.Text = var1 * var2 + "";
            }
            else
            if (opcion == "div")
            {
                resul.Text = var1 / var2 + "";
            }
            else
            if (opcion == "porciento")
            {
                resul.Text = var1 % var2 + "";
            }

        }

        private void Borrar_Clicked(object sender, EventArgs e)
        {
            resul.Text = "";
        }

        private void masmenos_Clicked(object sender, EventArgs e)
        {
            double comprobacion = Convert.ToDouble(resul.Text);
            if (comprobacion >= 0)
            {
                resul.Text = "-" + comprobacion;
            }
            else if (comprobacion <= 0)
            {
                resul.Text = -1 * comprobacion + "";
            }

        }

        private void porciento_Clicked(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(resul.Text);
            opcion = "porciento";
            resul.Text = "";
        }

        private void division_Clicked(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(resul.Text);
            opcion = "div";
            resul.Text = "";
        }

        private void siete_Clicked(object sender, EventArgs e)
        {
            resul.Text = resul.Text + 7;

        }

        private void ocho_Clicked(object sender, EventArgs e)
        {
            resul.Text = resul.Text + 8;
        }

        private void nueve_Clicked(object sender, EventArgs e)
        {
            resul.Text = resul.Text + 9;
        }

        private void multi_Clicked(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(resul.Text);
            opcion = "multi";
            resul.Text = "";

        }

        private void cuatro_Clicked(object sender, EventArgs e)
        {
            resul.Text = resul.Text + 4;
        }

        private void cinco_Clicked(object sender, EventArgs e)
        {
            resul.Text = resul.Text + 5;
        }

        private void seis_Clicked(object sender, EventArgs e)
        {
            resul.Text = resul.Text + 6;
        }

        private void menos_Clicked(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(resul.Text);
            opcion = "resta";
            resul.Text = "";
        }

        private void uno_Clicked(object sender, EventArgs e)
        {
            resul.Text = resul.Text + 1;
        }

        private void dos_Clicked(object sender, EventArgs e)
        {
            resul.Text = resul.Text + 2;
        }

        private void tres_Clicked(object sender, EventArgs e)
        {
            resul.Text = resul.Text + 3;
        }

        private void mas_Clicked(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(resul.Text);
            opcion = "suma";
            resul.Text = "";

        }

        private void cero_Clicked(object sender, EventArgs e)
        {
            resul.Text = resul.Text + 0;
        }

        private void punto_Clicked(object sender, EventArgs e)
        {
            if (resul.Text.Contains("."))
            {
                resul.Text = resul.Text;

            }
            else
            {
                resul.Text = resul.Text + ".";
            }
        }

        async void Regresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        private void igual_Clicked(object sender, EventArgs e)
        {

            resultados();
        }
    }
}
