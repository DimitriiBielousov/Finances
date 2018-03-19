using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Finances
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Accounts_Button_Clicked(object sender, EventArgs e)
        {
            NavigationPage.PushAsync(new Accounts());
        }
        private void Income_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Incomes());
        }
        private void Expenses_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Expenses());
        }
        private void Transfers_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Transfers());
        }
        private void Debt_management_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Debt_management());
        }
        private void Reports_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Reports());
        }
        private void Settings_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Settings());
        }
        private void About_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }
}
