using System;
using System.Collections.Generic;


namespace UnitedConsole
{
    public class TeamManager : IManager
    {
        private List<Player> playerList = new List<Player>();
        private List<Coach> coachList = new List<Coach>();
        public void AddPlayer(Player player)
        {   
            
            playerList.Add(player);

            Console.WriteLine($"Player added: Code: {player.Code} | Name: {player.Name} | Address: {player.Address} | Shirt Number: {player.ShirtNumber} | Position: {player.Position} | Salary: {player.Salary}");
        }

        public void AddCoach(Coach coach)
        {
            coachList.Add(coach);

            Console.WriteLine($"Coach added: Code: {coach.Code} | Name: {coach.Name} | Address: {coach.Address} | Position: {coach.Position} | Salary: {coach.Salary} | Years of Experience: {coach.YearOfExperience}");
        }

        public void ShowPlayer()
        {
            foreach (Player p in playerList)
            {
                Console.WriteLine($" Code: {p.Code} | Name: {p.Name} | Address: {p.Address} | Shirt Number: {p.ShirtNumber} | Position: {p.Position} | Salary: {p.Salary}");
            }
        }

        public void ShowCoach()
        {

            foreach (Coach c in coachList)
            {
                Console.WriteLine($" Code: {c.Code} | Name: {c.Name} | Address: {c.Address} | Position: {c.Position} | Salary: {c.Salary} | Year Of Experienc: {c.YearOfExperience}");
            }
        }
    }
}