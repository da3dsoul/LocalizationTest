using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using Res = LocalizationTest.Resources;

namespace LocalizationTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ObservableCollection<string> LocalizedStrings { get; set; } =
            new ObservableCollection<string>(new List<string>());
        
        public MainWindow()
        {
            InitializeComponent();
            LocalizationView.ItemsSource = LocalizedStrings;
            Res.Culture = new CultureInfo("en-us");
            LocalizedStrings.Add(Res.Something);
            LocalizedStrings.Add(Res.ThatThing);
            Res.Culture = new CultureInfo("nl");
            LocalizedStrings.Add(Res.Something);
            LocalizedStrings.Add(Res.ThatThing);
            Res.Culture = new CultureInfo("ja");
            LocalizedStrings.Add(Res.Something);
            LocalizedStrings.Add(Res.ThatThing);
            Res.Culture = new CultureInfo("es");
            LocalizedStrings.Add(Res.Something);
            LocalizedStrings.Add(Res.ThatThing);
            Res.Culture = new CultureInfo("en-us");
        }
    }
}