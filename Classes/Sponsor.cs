using System;
using System.Collections.Generic;
using System.Text;

namespace EsportDanmark.Classes
{
    public class Sponsor
    {
        // Fields
        private int id;
        private string companyname;
        private string branche;
        private int playerid;
        private string playername;
        private int playersalery;


        // Properties
        public int Id { get => id; }
        public string Companyname { get => companyname; set => companyname = value; }
        public string Branche { get => branche; set => branche = value; }
        public int Playerid { get => playerid; set => playerid = value; }
        public string Playername { get => playername; set => playername = value; }
        public int Playersalery { get => playersalery; set => playersalery = value; }


        // Constructor
        public Sponsor(string companyname, string branche, int playerid, string playername, int playersalery)
        {
            Companyname = companyname;
            Branche = branche;
            Playerid = playerid;
            Playername = playername;
            Playersalery = playersalery;
        }

        public Sponsor()
        {

        }
    }
}
