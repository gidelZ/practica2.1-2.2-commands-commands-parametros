using MVVM_bbhdzp.MVVM.Views_Models;

namespace MVVM_bbhdzp.MVVM.Views;

public partial class GenteView : ContentPage
{
	public GenteView()
	{
		InitializeComponent();

		BindingContext = new GenteViewModel();
	}
}