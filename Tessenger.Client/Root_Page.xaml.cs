using Tessenger.Client.Custom.Algorithms;
using Tessenger.Client.ViewModels.Root_PageViewModel;

namespace Tessenger.Client;

public partial class Root_Page : ContentPage
{
	public Root_Page()
	{
		InitializeComponent();	
	
	}

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
	   this.BindingContext = new Root_PageViewModel(this); 
    }
}