using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using static EsportDanmark.Classes.ApiProperties;

namespace EsportDanmark.Classes
{
    public class ApiCall
    {
        public Root GetPlayer(string summoner)
        {
            string json = new WebClient().DownloadString(@$"https://euw1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{summoner}?api_key=RGAPI-0669815a-beac-4a33-b695-de56d9e3c8a3");
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);
            return myDeserializedClass;
        }
    }
}
