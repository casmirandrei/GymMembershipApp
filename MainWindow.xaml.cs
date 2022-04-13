using Cv9Gym_ManagementApp.Helpers;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;



namespace Cv9Gym_ManagementApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public ObservableCollection<Person> People { get; set; }



        public MainWindow()
        {
            InitializeComponent();
            SwitchLanguage("en");

            People = new ObservableCollection<Person> {
               

            new Person
                {


                    LastName = "Oprea",
                    FirstName = "Alin",
                    Nr = "24",
                    Subscription="30",
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
                    Subscription="74",
                    Address= new Address
                    {
                        StreetName="Balcescu",
                        StreetNumber="278"
                    }

                }
            };
            DataContext = this;
        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(Subscription_lbl.Text, out var result);
            var membershipText = "";
            if (result > 0)
            {
                membershipText = Utils.CalculateMembership(result).ToString();

                var newPerson = new Person()
                {
                    LastName = LastName_lbl.Text,
                    FirstName = FirstName_lbl.Text,
                    Nr = Nr_lbl.Text,
                    Subscription = membershipText,
                    Address = new Address
                    {
                        StreetName = StreetName_lbl.Text,
                        StreetNumber = StreetNumber_lbl.Text
                    }

                };


                People.Add(newPerson);

                BtnClick.Background = Brushes.LightGreen;
                MessageBox.Show("New person added");
                BtnClick.Background = Brushes.Transparent;
                Nr_lbl.Text = " ";
                LastName_lbl.Text = " ";
                FirstName_lbl.Text = " ";
                StreetName_lbl.Text = " ";
                StreetNumber_lbl.Text = " ";
                Subscription_lbl.Text = " ";

            }
            else if (result < 0)
            {
                membershipText = MessageBox.Show("You need to introduce a positive number").ToString();
                
            }


           

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("en");
        }
        private void SwitchLanguage(string languageCode)
        {
            ResourceDictionary dictionary = new ResourceDictionary();
            switch (languageCode)
            {
                case "en":
                    dictionary.Source = new System.Uri("..\\StringResources.en.xaml", System.UriKind.Relative);
                    break;
                case "ro":
                    dictionary.Source = new System.Uri("..\\StringResources.ro.xaml", System.UriKind.Relative);
                    break;
                default:
                    dictionary.Source = new System.Uri("..\\StringResources.en.xaml", System.UriKind.Relative);
                    break;

            }
            this.Resources.MergedDictionaries.Add(dictionary);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("ro");
        }
    }



}
