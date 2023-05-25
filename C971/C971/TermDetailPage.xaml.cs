using System;
using System.Collections.Generic;
using C971.Models;
using Xamarin.Forms;

namespace C971
{
    public partial class TermDetailPage : ContentPage
    {
        public Term CurrentTerm;

        public TermDetailPage(Term term)
        {
            InitializeComponent();
            this.CurrentTerm = term;

            this.HeaderLabel.Text = String.Format("{0} \n {1}-{2}", CurrentTerm.Title, CurrentTerm.StartDate.ToShortDateString(), CurrentTerm.EndDate.ToShortDateString());

            //TODO put in for each
            Button button = new Button();
            button.Text = "+ \n Add New Course";
            button.SetValue(Grid.RowProperty, 0);
            button.SetValue(Grid.ColumnProperty, 0);


            CourseGrid.Children.Add(button);


        }

        void EditTermButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("edit term button clicked");
        }

        void DropTermButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("drop term button clicked");
        }
    }
}

