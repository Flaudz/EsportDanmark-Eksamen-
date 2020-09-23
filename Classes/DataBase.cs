using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EsportDanmark.Classes
{
    public class DataBase
    {
        private string connectionString = "Data Source=CV-BB-5992;Initial Catalog=EsportDanmark;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Executes the specified query.
        private DataSet Execute(string query)
        {
            DataSet resultSet = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(query, new SqlConnection(connectionString))))
            {
                adapter.Fill(resultSet);
            }
            return resultSet;
        }


        // Add methodes

        // Making a mothod where there will be added a new player in the database table Players
        public void AddNewPlayer(Player player)
        {
            string addNewPlayerQuery =
                $"INSERT INTO Players (Name, SummonerName, Rank, PhoneNumber, TournermentType) VALUES ('{player.Name}', '{player.Summonername}', {player.Rank}, {player.Phonenumber}, '{player.Tournermenttype}')";
            Execute(addNewPlayerQuery);
        }

        // Making a mothod where there will be added a new employee in the database table Employees
        public void AddNewEmployee(Employee employee)
        {
            string addNewEmploeeQuery =
                $"INSERT INTO Employees (Name, PhoneNumber, Salary, JobType, JudgeLevel) VALUES ('{employee.Name}', {employee.Phonenumber}, {employee.Salary}, '{employee.Jobtype}', {employee.Judgelevel})";
            Execute(addNewEmploeeQuery);
        }

        // Making a mothod where there will be added a new sponsor in the database table Sponsorers
        public void AddNewSponsor(Sponsor sponsor)
        {
            string addNewSponsorQuery =
                $"INSERT INTO Sponsorers (CompanyName, Branche, PlayerId, PlayerName, PlayerSalery) VALUES ('{sponsor.Companyname}', '{sponsor.Branche}', {sponsor.Playerid}, '{sponsor.Playername}, {sponsor.Playersalery}')";
            Execute(addNewSponsorQuery);
        }

        // Making a mothod where there will be added a new tournement in the database table Tournements
        public void AddNewTournement(Tournement tournement)
        {
            string addNewTournementQuery =
                $"INSERT INTO Tournements (TournermentName, PlayerId, PlayerName, PlayersPhoneNumber, RefId, RefName, RefPhoneNumber, RefLevel) VALUES ('{tournement.Tournermentname}', {tournement.Playerid}, '{tournement.Playername}', {tournement.Playerphonenumber}, {tournement.Refid}, '{tournement.Refname}', {tournement.Refphonenumber}, {tournement.Reflevel})";
            Execute(addNewTournementQuery);
        }
    }
}
