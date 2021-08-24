using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proba
{
	public partial class MainWindow : Window
	{
		public List<Tim> Timovi { get; set; } = new();

		public MainWindow()
		{
			InitializeComponent();
			//Timovi.Add(new Tim { Ime = "asdasd" });
			//Timovi.Add(new Tim { Ime = "drgrdg" });
			//Timovi.Add(new Tim { Ime = "asdv" });
			Tabela.ItemsSource = Timovi;

		}

		private void NovaUtakmica(object sender, RoutedEventArgs e)
		{
			Utakmica ut = new(Timovi);
			ut.Owner = this;
			ut.ShowDialog();
		}
	}

	public class Tim
	{
		public string Ime { get; set; }

		public int Pobede { get; set; }
		public int Nereseno { get; set; }
		public int Izgubljeno { get; set; }

		public int Bodovi { get; set; }
	}
}
