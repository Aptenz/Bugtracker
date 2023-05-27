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

        public async Task AddUserToProjectAsync(string AppUserID, int ProjectID)
        {
            try
            {
                //check to see if category is in contact already
                if (!await IsUserInProject(AppUserID,ProjectID))
                {
                    var appUserId = await _userManager.FindByIdAsync(AppUserID);
                    Project? project = await _context.Projects.FindAsync(ProjectID);

                    if (project != null && appUserId != null) // check to see if no bad data can be passed
                    {
                        project.AppUsers.Add(appUserId);
                        await _context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<ICollection<int>> GetUserProjectIdsAsync(int AppUserID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetUserProjectsAsync(string UserID)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsUserInProject(string AppUserID, int ProjectID)
        {
            var appUserId = await _userManager.FindByIdAsync(AppUserID);

            return await _context.Projects
                                 .Include(c => c.AppUsers)
                                 .Where(c => c.Id == ProjectID && c.AppUsers.Contains(appUserId))
                                 .AnyAsync(); //returns true false statement
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
