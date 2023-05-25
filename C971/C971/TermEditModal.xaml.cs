using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace C971
{
    public partial class TermEditModal : ContentPage
    {
        public TermEditModal()
        {
            InitializeComponent();
            HeaderLabel.Text = "New Term";

        }

        void SubmitTermButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("submitting new term");
        }
    }
}

