using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPrototype1Screens
{
	/// <summary>
	/// Interaction logic for Screen_1.xaml
	/// </summary>
	public partial class Screen_1 : UserControl
	{
		public Screen_1()
		{
			this.InitializeComponent();
			countryBox.Items.Add("Україна");
				countryBox.Items.Add("Німеччина");
		}

		private void ShowInform_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

		

		private void countryBox_LayoutUpdated(object sender, System.EventArgs e)
		{
			if(countryBox.Text == "Україна")
			{
			name.Text = "Україна";
				capital.Text = "Київ";
				language.Text = "Українська";
				area.Text = " 603 628 км²";
				population.Text = " 41 953 020";
				
			}
			if(countryBox.Text == "Німеччина")
			{
			name.Text = "Німеччина";
				capital.Text = "Берлін";
				language.Text = "НІмецька";
				area.Text = " 357 578 км²";
				population.Text = " 82,887,000";
				
			}
			// TODO: Add event handler implementation here.
		}
		
		
	}
}