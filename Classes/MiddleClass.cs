using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;
using System.Windows;
using static EsportDanmark.Classes.ApiProperties;

namespace EsportDanmark.Classes
{
    public class MiddleClass
    {
        DataBase db = new DataBase();
        List<Player> players = new List<Player>();

        public DataBase Db { get => db; }
        public List<Player> Players { get => players; set => players = value; }

        // Creating a player
        public void CreatePlayer(string playername)
        {
            ApiCall apiCall = new ApiCall();
            try
            {
                Root playerinfo = apiCall.GetPlayer(playername);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Getting player information
        public string GetPlayerInfo()
        {
            string playersInfoString = "";
            Players = db.GetPlayers();
            foreach (Player player in Players)
            {
                playersInfoString += $"Name: {player.Name} - Summonername: {player.Summonername} - Rank: {player.Rank}";
            }
        }
    }
}
