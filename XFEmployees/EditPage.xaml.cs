using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFEmployees
{

	public partial class EditPage : ContentPage
	{
		private Employees employee;

		public EditPage(Employees employee)
		{
			InitializeComponent();
			this.employee = employee;

//			updateButton.Clicked += UpdateButton_Clicked;
//			deleteButton.Clicked += DeleteButton_Clicked;

			firstNamesEntry.Text = employee.FirstNames;
			lastNamesEntry.Text = employee.LastNames;
			salaryEntry.Text = employee.Salary.ToString();
			contractDatePicker.Date = employee.ContractDate;
			activeSwitch.IsToggled = employee.Active;
		}

//		public async void DeleteButton_Clicked (object sender, EventArgs e)
//		{
//			var rta = await DisplayAlert("Confirm", "Are you sure you want to delete this employee? They have a wife and kids", "Yes", "No");
//			if (!rta)
//				return;
//
//			using (var data = new DataAccess())
//			{
//				data.DeleteEmployee();
//			}
//
//			await DisplayAlert("Confirm", "Employee has been deleted correctly... You're a monster", "Accept");
//			await Navigation.PushAsync(new HomePage());
//		}
//
//		public async void UpdateButton_Clicked (object sender, EventArgs e)
//		{
//			if (string.IsNullOrEmpty(firstNamesEntry.Text)) 
//			{
//				await DisplayAlert("Error", "Should enter/deposit first names", "Accept");
//				firstNamesEntry.Focus();
//				return;
//			}
//
//			if (string.IsNullOrEmpty(lastNamesEntry.Text)) 
//			{
//				await DisplayAlert("Error", "Should enter/deposit last names", "Accept");
//				lastNamesEntry.Focus();
//				return;
//			}
//
//			if (string.IsNullOrEmpty(salaryEntry.Text)) 
//			{
//				await DisplayAlert("Error", "Should enter/deposit salary", "Accept");
//				salaryEntry.Focus();
//				return;
//			}
//
//			Employees employee = new Employees
//			{
//				Active = activeSwitch.IsToggled,
//				LastNames = lastNamesEntry.Text,
//				ContractDate = contractDatePicker.Date,
//				FirstNames = firstNamesEntry.Text,
//				Salary = decimal.Parse(salaryEntry.Text)
//			};
//
//			using(var data = new DataAccess()) 
//			{
//				data.UpdateEmployee(employee);
//			}
//
//			await DisplayAlert("Confirm", "Employee has been updated correctly", "Accept");
//			await Navigation.PushAsync(new HomePage());
//
//		}
	}
}

