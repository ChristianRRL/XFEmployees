using System;
using Xamarin.Forms;

using System.Linq;
using System.Text;
using System.Threading;

namespace XFEmployees
{
	public class EmployeeCell: ViewCell
	{
		public EmployeeCell()
		{
			var EmployeeIDLabel = new Label {
				TextColor = Color.White,
				Font = Font.BoldSystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Start
			};
			EmployeeIDLabel.SetBinding(Label.TextProperty, new Binding("EmployeeID"));

			var FirstNamesLabel = new Label {
				TextColor = Color.White,
				Font = Font.BoldSystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Fill
			};
			FirstNamesLabel.SetBinding(Label.TextProperty, new Binding("FirstNames"));

			var LastNamesLabel = new Label {
				TextColor = Color.White,
				Font = Font.BoldSystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			LastNamesLabel.SetBinding(Label.TextProperty, new Binding("LastNames"));

			var SalaryLabel = new Label {
				TextColor = Color.White,
				Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			SalaryLabel.SetBinding(Label.TextProperty, new Binding("Salary"));

			var ContractDateLabel = new Label {
				TextColor = Color.White,
				Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
				HorizontalOptions = LayoutOptions.Fill
			};
			ContractDateLabel.SetBinding(Label.TextProperty, new Binding("ContractDate"));

			var ActiveSwitch = new Switch {
				HorizontalOptions = LayoutOptions.End,
				IsEnabled = false
			};
			ActiveSwitch.SetBinding(Switch.IsToggledProperty, new Binding("Active"));


			var panel1 = new StackLayout 
			{
				Children = { EmployeeIDLabel, FirstNamesLabel, LastNamesLabel }, 
				Orientation = StackOrientation.Horizontal
			};
			var panel2 = new StackLayout 
			{
				Children = { SalaryLabel, ContractDateLabel, ActiveSwitch }, 
				Orientation = StackOrientation.Horizontal
			};


			View = new StackLayout {
				Children = { panel1, panel2}, 
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
		}
	}

}