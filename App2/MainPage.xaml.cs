using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            float p= float.Parse(principal.Text);
            float r = float.Parse(rate.Text);
            int y = int.Parse(year.Text);
            amount.Text =Convert.ToString((p * r * y) / 100);

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            principal.Text = "";
            rate.Text = "";
            year.Text = "";
            amount.Text = "";

        }
    }
}
