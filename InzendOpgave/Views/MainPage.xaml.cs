using System;

using InzendOpgave.ViewModels;

using Windows.UI.Xaml.Controls;


namespace InzendOpgave.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();



        public MainPage()
        {
            InitializeComponent();

            DataContext = Teams.GetTeams();


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Navigate to AddTeamMember page
            this.Frame.Navigate(typeof(AddTeammember)); 
        }

        private void TextBlock_SelectionChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
