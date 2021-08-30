using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
		
		private void Kraj(object sender, RoutedEventArgs e)
		{
			if (Timovi.Count() >= 3)
			{
				var sortirano = Timovi.OrderByDescending(tim => tim.Bodovi).ToList();
				Panel.Children.Add(new Label { Content = "1. " + sortirano[0].Ime, Foreground = (Brush)new BrushConverter().ConvertFrom("#FFAF9500"), HorizontalAlignment = HorizontalAlignment.Center, FontSize = 24 });
				Panel.Children.Add(new Label { Content = "2. " + sortirano[1].Ime, Foreground = (Brush)new BrushConverter().ConvertFrom("#FFD7D7D7"), HorizontalAlignment = HorizontalAlignment.Center, FontSize = 24 });
				Panel.Children.Add(new Label { Content = "3. " + sortirano[2].Ime, Foreground = (Brush)new BrushConverter().ConvertFrom("#FF6A3805"), HorizontalAlignment = HorizontalAlignment.Center, FontSize = 24 });
			} else
			{
				MessageBox.Show("Nemate dovoljno timova!");
			}
		}
	}

		public class Tim : INotifyPropertyChanged
	{
		public string Ime { get; set; }

		private int _pobede;
		public int Pobede 
		{ 
			get => _pobede; 
			set
			{
				_pobede = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pobede"));
			}
		}
		
		
		public int Nereseno { get; set; }
		public int Izgubljeno { get; set; }

		public int Bodovi { get; set; }

		public event PropertyChangedEventHandler PropertyChanged; 
	}
}
