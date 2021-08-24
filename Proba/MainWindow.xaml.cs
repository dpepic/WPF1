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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proba
{
	public partial class MainWindow : Window
	{
		public Tim asd { get; set; } = new();

		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = asd;
		}
	}

	public class Tim
	{
		public string Ime { get; set; } = "asdasd";

		public int Pobede { get; set; }
		public int Nereseno { get; set; }
		public int Izgubljeno { get; set; }

		public int Bodovi { get; set; }
	}
}
