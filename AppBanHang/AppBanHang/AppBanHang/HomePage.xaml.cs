﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBanHang
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
       

        public HomePage (string username)
		{
			InitializeComponent ();
            Appusername.Text = "Hello " + username;
        }

        private void sk1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new test());
        }

        private void sk2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }














        //private void sk1(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new test());
        //}


    }
}