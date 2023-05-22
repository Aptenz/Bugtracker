using BugTracker.Models;
using Npgsql.PostgresTypes;

namespace BugTracker.Services.Interfaces
{
    public interface IProjectService
    {
        Task AddUserToProjectAsync(int AppUserID, int ProjectID);
        Task<bool> IsUserInProject(int AppUserID, int ProjectID);
        Task<IEnumerable<Project>> GetUserProjectsAsync(string UserID);
        Task<ICollection<int>> GetUserProjectIdsAsync(int AppUserID);
        Task RemoveUserFromProjectAsync(int AppUserID, int ProjectID);
        IEnumerable<Project> SearchForProjects(string searchString, string AppUserID);

    }
}
