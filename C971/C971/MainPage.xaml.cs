using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C971.Models;
using Xamarin.Forms;

namespace C971
{
    public partial class MainPage : ContentPage
    {
        public Term[] Terms = { new Term("Term1", DateTime.Today, DateTime.Today.AddMonths(2)) };

        public MainPage()
        {
            InitializeComponent();

            foreach (Term term in this.Terms)
            {
                Button newButton = new Button();
                newButton.Text = String.Format("{0} \n {1}-{2}", term.Title, term.StartDate.ToShortDateString(), term.EndDate.ToShortDateString());
                newButton.Clicked += ExistingTermButton_Clicked;
                newButton.BindingContext = term;

                this.CurrentTermsLayout.Children.Add(newButton);
            }
        }

        private void ExistingTermButton_Clicked(object sender, EventArgs e)
        {
            var senderButton = (Button)sender;
            Term currentTerm = (Term)senderButton.BindingContext;
            Navigation.PushAsync(new TermDetailPage(currentTerm));

        }

        void NewTermButton_Clicked(object sender, EventArgs e)
        {
            var senderButton = (Button)sender;
            Navigation.PushModalAsync(new TermEditModal());
        }
    }
}

