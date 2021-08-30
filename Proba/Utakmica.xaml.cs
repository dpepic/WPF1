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
		public string Tim2 { get; set; }
		public uint Golovi1 { get; set; }
		public uint Golovi2 { get; set; }

		public Utakmica(List<Tim> t)
		{
			lista = t;
			InitializeComponent();
			DataContext = this;
		}

		private void Izlaz(object sender, RoutedEventArgs e) => Close();


		private void Unos(object sender, RoutedEventArgs e)
		{
			if (Tim1.ToLower() != Tim2.ToLower() &&
				lista.Where(tim => tim.Ime.ToLower() == Tim1.ToLower()).Any() &&
				lista.Where(tim => tim.Ime.ToLower() == Tim2.ToLower()).Any())
			{
				var t1 = lista.Find(t => t.Ime.ToLower() == Tim1.ToLower());
				var t2 = lista.Find(t => t.Ime.ToLower() == Tim2.ToLower());
				if (Golovi1 > Golovi2)
				{
					t1.Pobede++;
					t2.Izgubljeno++;
					t1.Bodovi += 3;
				} else if (Golovi2 > Golovi1)
				{
					t2.Pobede++;
					t1.Izgubljeno++;
					t2.Bodovi += 3;
				} else
				{
					t1.Nereseno++;
					t2.Nereseno++;
					t1.Bodovi++;
					t2.Bodovi++;
				}
				Close();
			} else
			{
				MessageBox.Show("Jock:/");
			}
		}
	}
}
