using MVVM_bbhdzp.MVVM.Views_Models;

namespace MVVM_bbhdzp.MVVM.Views;

public partial class personview : ContentPage
{
	public personview()
	{
		InitializeComponent();

		BindingContext = new PersonViewModel();
	}
}