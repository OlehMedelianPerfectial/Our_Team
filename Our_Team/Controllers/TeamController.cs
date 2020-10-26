using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Our_Team.Services.Interfaces;

namespace Our_Team.Controllers
{
    [ApiController]
    [Route("api/teamMembers")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamMemberService _teamMemberService;
        public TeamController(ITeamMemberService teamMemberService)
        {
            _teamMemberService = teamMemberService;
        }

        [HttpGet]
        public IEnumerable<TeamMember> Get()
        {
            try
            {
                var teamMember = _teamMemberService.Get();
                return teamMember.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //[HttpGet("{id}")]
        //public TeamMember Get(Guid id)
        //{
        //    try
        //    {
        //        var teamMember = _teamMemberService.GetByKey(id);

        //        if (teamMember == null)
        //        {
        //            return null;
        //        }

        //        //add viewModel if there will be time

        //        return teamMember;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}

        //[HttpGet]
        //public IActionResult Edit(Guid Id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var teamMemberInfo = _teamMemberService.GetByKey(Id);

        //            if (teamMemberInfo != null)
        //            {

        //                //add viewModel if there will be time

        //                return Ok(teamMemberInfo);
        //            }

        //            var newTeamMemberInfo =
        //                new TeamMember
        //                {
        //                    Id = Guid.NewGuid()
        //                };

        //            return Ok(newTeamMemberInfo);

        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //            throw;
        //        }

        //    }
        //    return BadRequest(ModelState);
        //}

        //[HttpPost]
        //public IActionResult Edit(TeamMember teamMember)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _teamMemberService.Save(teamMember);
        //            return Ok(teamMember);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //            throw;
        //        }
        //    }
        //    return BadRequest(ModelState);
        //}

        //[HttpPost("{id}")]
        //public IActionResult Delete(Guid id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var teamMemberInfo = _teamMemberService.GetByKey(id);
        //            _teamMemberService.Delete(teamMemberInfo);
        //            return Ok(teamMemberInfo);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //            throw;
        //        }
        //    }
        //    return BadRequest(ModelState);
        //}
    }
}
