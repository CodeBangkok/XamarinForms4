using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms4
{
    [QueryProperty("Message", "msg")]
    public partial class CollectionViewPage : ContentPage
    {
        public string Message { get; set; }

        public CollectionViewPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Title = Message;
        }
    }
}
