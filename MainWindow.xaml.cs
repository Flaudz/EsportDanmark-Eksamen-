using EsportDanmark.Classes;
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

namespace EsportDanmark
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MiddleClass middleClass = new MiddleClass();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lookPlayersBtn_Click(object sender, RoutedEventArgs e)
        {
            lookCanvasMenu.Visibility = Visibility.Hidden;



            lookCanvasPlayers.Visibility = Visibility.Visible;
        }
    }
}
