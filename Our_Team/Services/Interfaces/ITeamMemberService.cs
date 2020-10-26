using System;
using System.Linq;

namespace Our_Team.Services.Interfaces
{
    public interface ITeamMemberService
    {
        IQueryable<TeamMember> Get();

        TeamMember GetByKey(Guid? key);

        void Save(TeamMember entity);

        void Update(TeamMember entity);

        void Delete(TeamMember entity);
    }
}