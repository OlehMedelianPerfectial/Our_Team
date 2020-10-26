using System;
using System.Linq;
using Our_Team.Interfaces;
using Our_Team.Services.Interfaces;

namespace Our_Team.Services
{
    public class TeamMemberService : ITeamMemberService
    {
        private readonly IRepository<TeamMember> _repoTeamMember;

        public TeamMemberService(IRepository<TeamMember> repoTeamMember)
        {
            _repoTeamMember = repoTeamMember;
        }

        public IQueryable<TeamMember> Get()
        {
            return _repoTeamMember.Get<TeamMember>();
        }

        public TeamMember GetByKey(Guid? key)
        {
            var teamMember = _repoTeamMember.GetById<TeamMember>(key);
            return teamMember;
        }

        public void Save(TeamMember entity)
        {
            if (_repoTeamMember.Get<TeamMember>().Any(t => t.Id == entity.Id))
            {
                _repoTeamMember.Update(entity);
            }
            else
            {
                _repoTeamMember.Insert(entity);
            }

            _repoTeamMember.SaveChanges();
        }

        public void Update(TeamMember entity)
        {
            _repoTeamMember.Update(entity);
            _repoTeamMember.SaveChanges();
        }

        public void Delete(TeamMember entity)
        {
            _repoTeamMember.Delete(entity);

            _repoTeamMember.SaveChanges();
        }
    }
}