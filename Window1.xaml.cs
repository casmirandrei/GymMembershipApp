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
using System.Windows.Shapes;

namespace Cv9Gym_ManagementApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public ObservableCollection<Person> People { get; set; }

        public Window1()
        {
            InitializeComponent();

            People = new ObservableCollection<Person> {
                new Person
                {
                    LastName = "Oprea",
                    FirstName = "Alin",
                    Nr = "24",
                    Address= new Address
                    {
                        StreetName="Ghindeni",
                        StreetNumber="65"
                    }
                },
                new Person
                {
                    LastName = "Matei",
                    FirstName = "Beatrice",
                    Nr = "23",
                    Address= new Address
                    {
                        StreetName="Balcescu",
                        StreetNumber="278"
                    }

                }
            };

            DataContext = this;





        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var newPerson = new Person
            {
                LastName = LastName_lbl.Text,
                FirstName = FirstName_lbl.Text,
                Nr = Nr_lbl.Text,
                Address = new Address
                {
                    StreetName = StreetName_lbl.Text,
                    StreetNumber = StreetNumber_lbl.Text
                }

            };

            People.Add(newPerson);

            btnAdd.Background = Brushes.LightGreen;
            MessageBox.Show("New person added");
        }
    }
}
