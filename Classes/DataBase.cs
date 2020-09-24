using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Permissions;
using System.Text;
using System.Windows;

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
            try
            {
                Execute(addNewPlayerQuery);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Making a mothod where there will be added a new employee in the database table Employees
        public void AddNewEmployee(Employee employee)
        {
            string addNewEmploeeQuery =
                $"INSERT INTO Employees (Name, PhoneNumber, Salary, JobType, JudgeLevel) VALUES ('{employee.Name}', {employee.Phonenumber}, {employee.Salary}, '{employee.Jobtype}', {employee.Judgelevel})";
            try
            {
                Execute(addNewEmploeeQuery);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Making a mothod where there will be added a new sponsor in the database table Sponsorers
        public void AddNewSponsor(Sponsor sponsor)
        {
            string addNewSponsorQuery =
                $"INSERT INTO Sponsorers (CompanyName, Branche, PlayerId, PlayerName, PlayerSalery) VALUES ('{sponsor.Companyname}', '{sponsor.Branche}', {sponsor.Playerid}, '{sponsor.Playername}', {sponsor.Playersalery})";
            try
            {
                Execute(addNewSponsorQuery);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Making a mothod where there will be added a new tournement in the database table Tournements
        public void AddNewTournement(Tournement tournement)
        {
            string addNewTournementQuery =
                $"INSERT INTO Tournements (TournermentName, PlayerId, PlayerName, PlayersPhoneNumber, RefId, RefName, RefPhoneNumber, RefLevel) VALUES ('{tournement.Tournermentname}', {tournement.Playerid}, '{tournement.Playername}', {tournement.Playerphonenumber}, {tournement.Refid}, '{tournement.Refname}', {tournement.Refphonenumber}, {tournement.Reflevel})";
            try
            {
                Execute(addNewTournementQuery);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        // Get information from database

        // Getting all players information from database
        public List<Player> GetPlayers()
        {
            List<Player> playersList = new List<Player>();
            string allPlayersQuery = "SELECT * FROM Players";

            // Eksikver query og gemmer i en variabel
            DataSet resultSet = Execute(allPlayersQuery);

            // Får første table af data sættet og gemmer i en variabel
            DataTable playerTable = resultSet.Tables[0];



            foreach (DataRow playerRow in playerTable.Rows)
            {
                string name = (string)playerRow["Name"];
                string summonername = (string)playerRow["SummonerName"];
                int rank = (int)playerRow["Rank"];
                int phonenumber = (int)playerRow["PhoneNumber"];
                string tournementtype = (string)playerRow["TournermentType"];
                Player player = new Player(name, summonername, rank, phonenumber, tournementtype);
                playersList.Add(player);
            }
            return playersList;
        }

        // Getting Sponsor information from database
        public List<Sponsor> GetSponsors()
        {
            List<Sponsor> sponsorsList = new List<Sponsor>();
            string allSponsorsQuery = "SELECT * FROM Sponsorers";

            // Eksikver query og gemmer i en variabel
            DataSet resultSet = Execute(allSponsorsQuery);

            // Får første table af data sættet og gemmer i en variabel
            DataTable sponsorTabel = resultSet.Tables[0];


            foreach (DataRow sponsorRow in sponsorTabel.Rows)
            {
                string companyname = (string)sponsorRow["CompanyName"];
                string branche = (string)sponsorRow["Branche"];
                int playerid = (int)sponsorRow["PlayerId"];
                string playername = (string)sponsorRow["PlayerName"];
                int playersalery = (int)sponsorRow["PlayerSalery"];
                Sponsor sponsor = new Sponsor(companyname, branche, playerid, playername, playersalery);
                sponsorsList.Add(sponsor);
            }
            return sponsorsList;
        }

        // Getting Tournements information from database
        public List<Tournement> GetTournements()
        {
            List<Tournement> TournementsList = new List<Tournement>();
            string allTournementsQuery = "SELECT * FROM Tournements";

            // Eksikver query og gemmer i en variabel
            DataSet resultSet = Execute(allTournementsQuery);

            // Får første table af data sættet og gemmer i en variabel
            DataTable tournementTable = resultSet.Tables[0];


            foreach (DataRow tournementRow in tournementTable.Rows)
            {
                string tournementname = (string)tournementRow["TournermentName"];
                int playerid = (int)tournementRow["PlayerId"];
                string playername = (string)tournementRow["PlayersName"];
                int playerphonenumber = (int)tournementRow["PlayersPhoneNumber"];
                int refif = (int)tournementRow["RefId"];
                string refname = (string)tournementRow["RefName"];
                int refphonenumber = (int)tournementRow["RefPhoneNumber"];
                int reflevel = (int)tournementRow["RefLevel"];
                Tournement tournement = new Tournement(tournementname, playerid, playername, playerphonenumber, refif, refname, refphonenumber, reflevel);
                TournementsList.Add(tournement);
            }
            return TournementsList;
        }

        // Får ansatte information fra databasen
        public List<Employee> GetEmployees()
        {
            List<Employee> employeesList = new List<Employee>();
            string allEmployeesQuery = "SELECT * FROM Employees";


            // Eksikver query og gemmer i en variabel
            DataSet resultSet = Execute(allEmployeesQuery);

            // Får første table af data sættet og gemmer i en variabel
            DataTable employeeTable = resultSet.Tables[0];


            foreach (DataRow employeeRow in employeeTable.Rows)
            {
                string name = (string)employeeRow["Name"];
                int phonenumber = (int)employeeRow["PhoneNumber"];
                int salary = (int)employeeRow["Salary"];
                string jobtype = (string)employeeRow["JobType"];
                int judgelevel = (int)employeeRow["JodgeLevel"];
                Employee employee = new Employee(name, phonenumber, salary, jobtype, judgelevel);
                employeesList.Add(employee);
            }
            return employeesList;
        }


        // Slette fra DataBasen

        // Slette spiller fra databasen
        public void deletePlayer(int phonenumber)
        {
            string deletePlayerQuery =
                $"DELETE FROM Players WHERE PhoneNumber = {phonenumber}";
            Execute(deletePlayerQuery);
        }

        // Slette Sponsor fra databasen
        public void deleteSponsor(string comapanyname)
        {
            string deleteSponsorQuery =
                $"DELETE FROM Sponsorers WHERE CompanyName = '{comapanyname}'";
            Execute(deleteSponsorQuery);
        }


        // Opdater fra databasen

        // Opdatere player fra databasen
        public void updatePlayer(string name, string summonername, int rank, int phonenumber, string tournementtype, int beforephonenumber)
        {
            string updatePlayerQuery =
                $"UPDATE Players SET Name = '{name}', SummonerName = '{summonername}', Rank = {rank}, PhoneNumber = {phonenumber}, TournermentType = '{tournementtype}' WHERE PhoneNumber = {beforephonenumber}";
            Execute(updatePlayerQuery);
        }


        // Opdater sponsor i databasen
        public void updateSponsor(Sponsor sponsor, string beforecompanyname)
        {
            string updateSponsorQuery =
                $"UPDATE Sponsorers SET CompanyName = '{sponsor.Companyname}', Branche = '{sponsor.Branche}', PlayerId = {sponsor.Playerid}, PlayerName = '{sponsor.Playername}', PlayerSalery = {sponsor.Playersalery} WHERE CompanyName = '{beforecompanyname}'";
            Execute(updateSponsorQuery);
        }
    }
}
