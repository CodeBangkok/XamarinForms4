using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinForms4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listviewButton.Clicked += ListviewButton_Clicked;
            collectionviewButton.Clicked += CollectionviewButton_Clicked;
        }

        void ListviewButton_Clicked(object sender, EventArgs e)
        {
            var shell = Application.Current.MainPage as AppShell;
            shell.GoToAsync("app://codebangkok.com/bond/home/a/listview");
        }

        void CollectionviewButton_Clicked(object sender, EventArgs e)
        {
            var shell = Application.Current.MainPage as AppShell;
            shell.GoToAsync("app://codebangkok.com/bond/home/b/collectionview?msg=HelloWorld");
        }

    }
}
