﻿using BugTracker.Data;
using BugTracker.Models;
using BugTracker.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ApplicationDbContext _context;

        public ProjectService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddUserToProjectAsync(int AppUserID, int ProjectID)
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
