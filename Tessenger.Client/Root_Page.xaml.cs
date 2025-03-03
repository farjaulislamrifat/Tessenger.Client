using DevExpress.Maui.Core.Internal;
using Tessenger.Client.Custom.Algorithms;
using Tessenger.Client.Data_Db_Contexts;
using Tessenger.Client.Services.Api_Services;
using Tessenger.Client.ViewModels.Root_PageViewModel;

namespace Tessenger.Client;

public partial class Root_Page : ContentPage
{
    public static IAlgorithms algorithms;
    public static IApi_Services api_Services;
    public static Data_Db_Contexts.Data_Db_Contexts data_Db_Context;

    public Root_Page(IAlgorithms algorithms_, IApi_Services api_Services_ , Data_Db_Contexts.Data_Db_Contexts data_ )
    {
        InitializeComponent();

        algorithms = algorithms_;
        api_Services = api_Services_;
        data_Db_Context = data_;
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        algorithms.StatusBarCustomizetion(this, Colors.White, Colors.Black);
        this.BindingContext = new Root_PageViewModel(this);
    }
}