using IT3045C_Final_Project.Models;

namespace IT3045C_Final_Project.Data
{
    public interface ITeamMembersContextDAO

    {
        //Team Members
        int? AddInfo(TeamMember i);
        List<TeamMember> GetAllInfo();
        TeamMember GetInfoById(int Id);
        int? RemoveInfoById(int Id);
        int? UpdateInfo(TeamMember i);

    }
}