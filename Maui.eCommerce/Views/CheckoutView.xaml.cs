using Spring2025_Samples.Models;
using Maui.eCommerce.ViewModels;
using System.ComponentModel;
namespace Maui.eCommerce.Views;

//[QueryProperty(nameof(TotalPrice), "PriceKey")]

public partial class CheckoutView : ContentPage
{
//	public int TotalPrice { get; set; }
    public CheckoutView()
	{
		InitializeComponent();
        BindingContext = new TotalCostViewModel();

    }

    public void GoHome(object sender, EventArgs e)
    {
        (BindingContext as TotalCostViewModel).RefreshUI();
        Shell.Current.GoToAsync($"//MainPage");        
    }
}