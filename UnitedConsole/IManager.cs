using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UnitedConsole
{
    public interface IManager 
    {
        void AddPlayer(Player player);
        void AddCoach(Coach coach);
        void ShowPlayer();
        void ShowCoach();
      
    }
}


