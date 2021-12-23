using DAL.WoWW.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.WoWW.Handlers
{
    public static class Mapper
    {
        public static Team ConvertTeam(IDataRecord reader)
        {
            return new Team
            {
                Id = (int)reader["Id"],
                Name = reader["name"] is DBNull ? null : reader["name"].ToString(),
                Score = (int)reader["Score"]
            };
        }

        public static Player ConvertPlayer(IDataRecord reader)
        {
            return new Player
            {
                Id = (int)reader["Id"],
                Name = reader["name"] is DBNull ? null : reader["name"].ToString(),
                Email = (string)reader["email"],
                FK_Team = reader["FK_Team"] is DBNull ? 0 : (int)reader["FK_Team"]
            };
        }
    }
   
}

