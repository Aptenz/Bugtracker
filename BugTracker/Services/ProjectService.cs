using BugTracker.Data;
using BugTracker.Models;
using BugTracker.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ProjectService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task AddUserToProjectAsync(int AppUserID, int ProjectID)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<int>> GetUserProjectIdsAsync(int AppUserID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetUserProjectsAsync(string UserID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserInProject(int AppUserID, int ProjectID)
        {
            throw new NotImplementedException();
        }

        public Task RemoveUserFromProjectAsync(int AppUserID, int ProjectID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> SearchForProjects(string searchString, string AppUserID)
        {
            throw new NotImplementedException();
        }
    }
}
