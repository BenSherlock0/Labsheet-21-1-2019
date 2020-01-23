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

namespace Labsheet1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Band> bands= new ObservableCollection<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CreateBand();
        }
        public void CreateBand()
        {
            Band b1 = new Band("BigB", 1990, "Tom Smith, Brad Duggan");
            Band b2 = new Band("Duck Kingdom", 1990, "Tommy C, Susie C");
            Band b3 = new Band("Wack", 1990, "Tim, Alex");
            Band b4 = new Band("Cars", 1990, "Evil Tim, Slighty Annoyed Cat");
            Band b5 = new Band("There", 1990, "Evilest Tim, Mega Jerk");
            Band b6 = new Band("Hello", 1990, "Nice Tim");

            bands.Add(b1);
            bands.Add(b2);
            bands.Add(b3);
            bands.Add(b4);
            bands.Add(b5);
            bands.Add(b6);

            List<Band> sorted = bands.ToList();
            sorted.Sort();
            bands = new ObservableCollection<Band>(sorted);

            lbxBands.ItemsSource = bands;
        }
    }
}
