using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.Models;

namespace SystemUI
{
    public interface ITeamRequestor
    {
        void TeamComplete(TeamModel model);
    }
}
