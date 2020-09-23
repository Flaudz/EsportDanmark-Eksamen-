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
            string json = new WebClient().DownloadString(@$"https://euw1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{summoner}?api_key=RGAPI-f12f2fcf-e636-499c-932f-bf5099b62c6c");
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);
            return myDeserializedClass;
        }
    }
}
