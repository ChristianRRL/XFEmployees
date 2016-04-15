using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFEmployees
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();

			addButton.Clicked += AddButton_Clicked;
			dataListView.ItemSelected += DataListView_ItemSelected;

			dataListView.ItemTemplate = new DataTemplate(typeof(EmployeeCell));

			using(var data = new DataAccess()) 
			{
				dataListView.ItemsSource = data.GetEmployees();
			}
		}

		void DataListView_ItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			Navigation.PushAsync(new EditPage((Employees)e.SelectedItem));
		}

		public async void AddButton_Clicked (object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(firstNamesEntry.Text)) 
			{
				await DisplayAlert("Error", "Should enter/deposit first names", "Accept");
				firstNamesEntry.Focus();
				return;
			}

			if (string.IsNullOrEmpty(lastNamesEntry.Text)) 
			{
				await DisplayAlert("Error", "Should enter/deposit last names", "Accept");
				lastNamesEntry.Focus();
				return;
			}

			if (string.IsNullOrEmpty(salaryEntry.Text)) 
			{
				await DisplayAlert("Error", "Should enter/deposit salary", "Accept");
				salaryEntry.Focus();
				return;
			}

			Employees employee = new Employees
			{
				Active = activeSwitch.IsToggled,
				LastNames = lastNamesEntry.Text,
				ContractDate = contractDatePicker.Date,
				FirstNames = firstNamesEntry.Text,
				Salary = decimal.Parse(salaryEntry.Text)
			};

			using(var data = new DataAccess()) 
			{
				data.InsertEmployee(employee);
				dataListView.ItemsSource = data.GetEmployees();
			}

			lastNamesEntry.Text = string.Empty;
			contractDatePicker.Date = DateTime.Now;
			firstNamesEntry.Text = string.Empty;
			salaryEntry.Text = string.Empty;
			await DisplayAlert("Message", "Employee created correctly", "Accept");
		}
	}
}

