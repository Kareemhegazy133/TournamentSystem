using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.Models;

namespace SystemLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PlayerModel CreatePlayer(PlayerModel model);
        TeamModel CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        List<TeamModel> GetTeams_All();
        List<PlayerModel> GetPlayers_All();
        List<TournamentModel> GetTournaments_All();
    }
}
