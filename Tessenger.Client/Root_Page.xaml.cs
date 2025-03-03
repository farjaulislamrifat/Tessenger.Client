using DevExpress.Maui.Core.Internal;
using Tessenger.Client.Custom.Algorithms;
using Tessenger.Client.ViewModels.Root_PageViewModel;

namespace Tessenger.Client;

public partial class Root_Page : ContentPage
{
	public static  readonly IAlgorithms algorithms = DependencyService.Get<IAlgorithms>();

    public Root_Page(IAlgorithms algorithms_)
	{
		InitializeComponent();

      

    }
   
    private void ContentPage_Loaded(object sender, EventArgs e)
    {
	   this.BindingContext = new Root_PageViewModel(this); 
    }
}