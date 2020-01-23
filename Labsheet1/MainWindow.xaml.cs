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
        ObservableCollection<Band> filteredBands= new ObservableCollection<Band>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbxGenre.ItemsSource = new string[] { "All", "Rock", "Pop","Indie" };
            //cbxGenre.SelectedItem = "All";

            CreateBand();
        }
        public void CreateBand()
        {
            

            Rock b1 = new Rock("BigB", 1990, "Tom Smith, Brad Duggan");
            Band b2 = new Rock("Duck Kingdom", 1990, "Tommy C, Susie C");
            Band b3 = new Pop("Wack", 1990, "Tim, Alex");
            Band b4 = new Pop("Cars", 1990, "Evil Tim, Slighty Annoyed Cat");
            Band b5 = new Indie("There", 1990, "Evilest Tim, Mega Jerk");
            Band b6 = new Indie("Hello", 1990, "Nice Tim");

            Album a1 = new Album() { Name = "Abbey Road" };

            b1.Albums.Add(a1);

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

        private void LbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedband = lbxBands.SelectedItem as Band;



            txtblkInformation.Text = $"Formed: {selectedband.Year}\nMembers: {selectedband.Members}";

            lbxAlblums.ItemsSource = selectedband.Albums;

        }

        private void CbxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            filteredBands.Clear();

            try
            {

                if (cbxGenre.SelectedItem == "Rock")
                {
                    foreach (Band rockband in bands)
                    {
                        if (rockband.GetType().Name == "Rock")
                        {
                            filteredBands.Add(rockband);
                        }
                    }
                }
                if (cbxGenre.SelectedItem == "Pop")
                {
                    foreach (Band popband in bands)
                    {
                        if (popband.GetType().Name == "Pop")
                        {
                            filteredBands.Add(popband);
                        }
                    }
                }
                if (cbxGenre.SelectedItem == "Indie")
                {
                    foreach (Band indieband in bands)
                    {
                        if (indieband.GetType().Name == "Indie")
                        {
                            filteredBands.Add(indieband);
                        }
                    }
                }

                lbxBands.ItemsSource = filteredBands;
            }
            catch
            {

            }
        }
    }
}
