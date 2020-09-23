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

        // Menu Canvas

        // Look Canvases
        private void lookMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            lookCanvas.Visibility = Visibility.Visible;
            lookCanvasMenu.Visibility = Visibility.Visible;
            lookCanvasPlayers.Visibility = Visibility.Hidden;
            lookCanvasTournement.Visibility = Visibility.Hidden;
            lookCanvasEmployee.Visibility = Visibility.Hidden;
            lookCanvasSponsor.Visibility = Visibility.Hidden;


            addCanvas.Visibility = Visibility.Hidden;
            addCanvasMenu.Visibility = Visibility.Visible;
            addCanvasPlayer.Visibility = Visibility.Hidden;


            deleteCanvas.Visibility = Visibility.Hidden;
            deleteCanvasMenu.Visibility = Visibility.Visible;
            deleteCanvasPlayer.Visibility = Visibility.Hidden;


            updateCanvas.Visibility = Visibility.Hidden;
            updateCanvasMenu.Visibility = Visibility.Visible;
            updateCanvasPlayer.Visibility = Visibility.Hidden;
        }

        private void lookPlayersBtn_Click(object sender, RoutedEventArgs e)
        {
            lookCanvasMenu.Visibility = Visibility.Hidden;

            lookPlayersTextBlock.Text = middleClass.GetPlayerInfo();

            lookCanvasPlayers.Visibility = Visibility.Visible;
        }

        private void lookSponsorersBtn_Click(object sender, RoutedEventArgs e)
        {
            lookCanvasMenu.Visibility = Visibility.Hidden;

            lookSponsorsTextBlock.Text = middleClass.GetSponsorInfo();

            lookCanvasSponsor.Visibility = Visibility.Visible;
        }

        private void lookTournementsBtn_Click(object sender, RoutedEventArgs e)
        {
            lookCanvasMenu.Visibility = Visibility.Hidden;

            lookTournementTextBlock.Text = middleClass.GetTournementInfo();

            lookCanvasTournement.Visibility = Visibility.Visible;
        }

        private void lookEmployeesBtn_Click(object sender, RoutedEventArgs e)
        {
            lookCanvasMenu.Visibility = Visibility.Hidden;

            lookEmployeeTextBlock.Text = middleClass.GetEmployeeInfo();

            lookCanvasEmployee.Visibility = Visibility.Visible;
        }


        // Add Canvases
        private void addMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            lookCanvas.Visibility = Visibility.Hidden;
            lookCanvasMenu.Visibility = Visibility.Visible;
            lookCanvasPlayers.Visibility = Visibility.Hidden;
            lookCanvasTournement.Visibility = Visibility.Hidden;
            lookCanvasEmployee.Visibility = Visibility.Hidden;
            lookCanvasSponsor.Visibility = Visibility.Hidden;


            addCanvas.Visibility = Visibility.Visible;
            addCanvasMenu.Visibility = Visibility.Visible;
            addCanvasPlayer.Visibility = Visibility.Hidden;


            deleteCanvas.Visibility = Visibility.Hidden;
            deleteCanvasMenu.Visibility = Visibility.Visible;
            deleteCanvasPlayer.Visibility = Visibility.Hidden;


            updateCanvas.Visibility = Visibility.Hidden;
            updateCanvasMenu.Visibility = Visibility.Visible;
            updateCanvasPlayer.Visibility = Visibility.Hidden;
        }
        private void addPlayersBtn_Click(object sender, RoutedEventArgs e)
        {
            addCanvasMenu.Visibility = Visibility.Hidden;
            addCanvasPlayer.Visibility = Visibility.Visible;
        }
        private void addPlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            middleClass.CreatePlayer(addPlayerNameInput.Text, addPlayerSummonerNameInput.Text, int.Parse(addPlayerRankInput.Text), int.Parse(addPlayerPhoneNumberInput.Text), addPlayerTournementTypeInput.Text);
            addCanvasPlayer.Visibility = Visibility.Hidden;
            addCanvasMenu.Visibility = Visibility.Visible;
            addCanvas.Visibility = Visibility.Hidden;
        }


        // Delete Section
        private void deleteMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            lookCanvas.Visibility = Visibility.Hidden;
            lookCanvasMenu.Visibility = Visibility.Visible;
            lookCanvasPlayers.Visibility = Visibility.Hidden;
            lookCanvasTournement.Visibility = Visibility.Hidden;
            lookCanvasEmployee.Visibility = Visibility.Hidden;
            lookCanvasSponsor.Visibility = Visibility.Hidden;


            addCanvas.Visibility = Visibility.Hidden;
            addCanvasMenu.Visibility = Visibility.Visible;
            addCanvasPlayer.Visibility = Visibility.Hidden;


            deleteCanvas.Visibility = Visibility.Visible;
            deleteCanvasMenu.Visibility = Visibility.Visible;
            deleteCanvasPlayer.Visibility = Visibility.Hidden;

            updateCanvas.Visibility = Visibility.Hidden;
            updateCanvasMenu.Visibility = Visibility.Visible;
            updateCanvasPlayer.Visibility = Visibility.Hidden;
        }

        private void deletePlayersBtn_Click(object sender, RoutedEventArgs e)
        {
            deleteCanvasMenu.Visibility = Visibility.Hidden;

            deleteCanvasPlayer.Visibility = Visibility.Visible;
        }

        private void deletePlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            middleClass.DeletePlayer(int.Parse(deletePlayerPhoneNumberInput.Text));
            deleteCanvasPlayer.Visibility = Visibility.Hidden;
            deleteCanvasMenu.Visibility = Visibility.Visible;
            deleteCanvas.Visibility = Visibility.Hidden;
        }

        private void updateMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            lookCanvas.Visibility = Visibility.Hidden;
            lookCanvasMenu.Visibility = Visibility.Visible;
            lookCanvasPlayers.Visibility = Visibility.Hidden;
            lookCanvasTournement.Visibility = Visibility.Hidden;
            lookCanvasEmployee.Visibility = Visibility.Hidden;
            lookCanvasSponsor.Visibility = Visibility.Hidden;


            addCanvas.Visibility = Visibility.Hidden;
            addCanvasMenu.Visibility = Visibility.Visible;
            addCanvasPlayer.Visibility = Visibility.Hidden;


            deleteCanvas.Visibility = Visibility.Hidden;
            deleteCanvasMenu.Visibility = Visibility.Visible;
            deleteCanvasPlayer.Visibility = Visibility.Hidden;

            updateCanvas.Visibility = Visibility.Visible;
            updateCanvasMenu.Visibility = Visibility.Visible;
            updateCanvasPlayer.Visibility = Visibility.Hidden;
        }

        private void updatePlayersBtn_Click(object sender, RoutedEventArgs e)
        {
            updateCanvasMenu.Visibility = Visibility.Hidden;
            updateCanvasPlayer.Visibility = Visibility.Visible;
        }

        private void updatePlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            middleClass.updatePlayer(updatePlayerNameInput.Text, updatePlayerSummonerNameInput.Text, int.Parse(updatePlayerRankInput.Text), int.Parse(updatePlayerPhoneNumberInput.Text), updatePlayerTournementTypeInput.Text, int.Parse(choosePlayerPhoneNumberInput.Text));
            updateCanvasMenu.Visibility = Visibility.Visible;
            updateCanvas.Visibility = Visibility.Hidden;
            updateCanvasPlayer.Visibility = Visibility.Hidden;
        }


        // Update from database

    }
}
