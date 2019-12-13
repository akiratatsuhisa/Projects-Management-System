﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Authorize(Roles = "Student")]
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProjectsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var studentId = _userManager.GetUserId(User);
            ViewBag.Student = _context.Students.Include(s => s.ApplicationUser).First(s => s.StudentId == studentId);
            return View(_context.Projects
                            .Include(p => p.ProjectMembers)
                            .Where(p => p.ProjectMembers.Where(pm => pm.StudentId == studentId).Count() == 1)
                            .Include(p => p.Lecturer).ThenInclude(l => l.ApplicationUser)
                            .Include(p => p.ProjectType));
        }

        public async Task<IActionResult> Details(int id)
        {
            var studentId = _userManager.GetUserId(User);
            var result = await _context.ProjectMembers.FirstOrDefaultAsync(pm => pm.StudentId == studentId && pm.ProjectId == id);
            if (result == null)
            {
                return NotFound();
            }
            var projectId = result.ProjectId;
            ViewBag.ProjectMembers = _context.ProjectMembers.Where(pm => pm.ProjectId == projectId).Include(pm => pm.Student).ThenInclude(s => s.ApplicationUser);

            //Test
            if (_context.ProjectSchedules.Where(ps => ps.ProjectId == projectId).Count() == 0)
            {
                var dateTimeNow = DateTime.Now.AddMonths(-1);
                for (var i = 1; i < 11; i++)
                {
                    dateTimeNow = dateTimeNow.AddDays(7);
                    _context.ProjectSchedules.Add(new ProjectSchedule { ProjectId = projectId, Name = $"Nhiệm vụ tuần {i}", ExpiredDate = dateTimeNow });
                }
                await _context.SaveChangesAsync();
            }

            ViewBag.ProjectSchedules = _context.ProjectSchedules.Where(ps => ps.ProjectId == projectId).OrderBy(ps => ps.ExpiredDate).ToList();
            return View(await _context.Projects
                    .Include(p => p.Lecturer).ThenInclude(l => l.ApplicationUser)
                    .Include(p => p.ProjectType)
                    .FirstAsync(p => p.Id == projectId));
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewReport(ProjectScheduleReport projectScheduleReport, int projectId)
        {
            var studentId = _userManager.GetUserId(User);
            if (IsValidReport(projectScheduleReport, studentId))
            {
                projectScheduleReport.StudentId = studentId;
                projectScheduleReport.CreatedDate = DateTime.Now;
                _context.ProjectScheduleReports.Add(projectScheduleReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { id = projectId });
            }
            return BadRequest();
        }

        private bool IsValidReport(ProjectScheduleReport projectScheduleReport, string studentId)
        {
            var projectSchedule = _context.ProjectSchedules.Find(projectScheduleReport.ProjectScheduleId);
            if(projectSchedule == null)
            {
                return false;
            }
            if( projectSchedule.ExpiredDate.Date < DateTime.Now.Date)
            {
                return false;
            }
            var isValidStudent = _context.ProjectMembers.Any(pm => pm.ProjectId == projectSchedule.ProjectId && pm.StudentId == studentId);
            if (!isValidStudent)
            {
                return false;
            }
            return true;
        }
    }
}