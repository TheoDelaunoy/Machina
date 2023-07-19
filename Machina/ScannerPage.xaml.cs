using System;
using System.Collections.Generic;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace Machina
{	
	public partial class ScannerPage : ContentPage
	{	
		public ScannerPage (MediaFile file)
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);

            faceImage.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStreamWithImageRotatedForExternalStorage();
                return stream;
            });
            
        }

        void ContinueButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}

