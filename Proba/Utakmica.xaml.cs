using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Proba
{
	/// <summary>
	/// Interaction logic for Utakmica.xaml
	/// </summary>
	public partial class Utakmica : Window
	{
		public List<Tim> lista;

		public string Tim1 { get; set; }

		public Utakmica(List<Tim> t)
		{
			lista = t;
			InitializeComponent();
			DataContext = this;
		}

		private void Unos(object sender, RoutedEventArgs e)
		{
			if (lista.Where(tim => tim.Ime.ToLower() == Tim1.ToLower()).Any())
			{
				MessageBox.Show("Potoji!");
			} else
			{
				MessageBox.Show("Jock:/");
			}
		}
	}
}
