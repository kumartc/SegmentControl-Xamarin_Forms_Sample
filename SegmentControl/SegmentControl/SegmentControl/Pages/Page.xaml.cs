using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SegmentControl.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page : ContentPage
	{
		public Page ()
		{
			InitializeComponent ();
            var vehicleTypes = new List<string>() { "C", "C++", "Java", "C#", "Xamarin Forms"};
            segment.Children = vehicleTypes;
        }

        private void SegmentControl_SelectedItemChanged(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem.ToString() == "C")
            {
                ImageSource.Source = "C.png";
                LabelText.Text= $"{e.SelectedItem}";
            }
            else if(e.SelectedItem.ToString() == "C++")
            {
                ImageSource.Source = "Cplusplus.png";
                LabelText.Text = $"{e.SelectedItem}";
            }
            else if(e.SelectedItem.ToString() == "Java")
            {
                ImageSource.Source = "java.png";
                LabelText.Text = $"{e.SelectedItem}";
            }
            else if(e.SelectedItem.ToString() == "C#")
            {
                ImageSource.Source = "Csharp.png";
                LabelText.Text = $"{e.SelectedItem}";
            }
            else if(e.SelectedItem.ToString() == "Xamarin Forms")
            {
                ImageSource.Source = "xamarin.png";
                LabelText.Text = $"{e.SelectedItem}";
            }

        }
    }
}