﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalTeme.API.Mappers;
using PortalTeme.API.Models.Courses;
using PortalTeme.Common.Authorization;
using PortalTeme.Data;
using PortalTeme.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalTeme.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CoursesController : ControllerBase {
        private readonly PortalTemeContext _context;
        private readonly IAuthorizationService authorizationService;
        private readonly ICourseMapper courseMapper;

        public CoursesController(PortalTemeContext context, IAuthorizationService authorizationService, ICourseMapper courseMapper) {
            _context = context;
            this.authorizationService = authorizationService;
            this.courseMapper = courseMapper;
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseViewDTO>>> GetCourses() {

            var courses = await _context.Courses
                .Include(c => c.Professor)
                .Include(c => c.Assistants)
                .Include(c => c.CourseInfo)
                .Include(c => c.Groups)
                .Include(c => c.Students)
                .Include(c => c.Assignments)
                .ToListAsync();
            var results = new List<CourseViewDTO>();
            foreach (var course in courses) {
                if ((await authorizationService.AuthorizeAsync(User, course, AuthorizationConstants.CanViewCoursePolicy)).Succeeded)
                    results.Add(courseMapper.MapCourseView(course));
            }

            return results;
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseViewDTO>> GetCourse(Guid id) {
            var course = await _context.Courses.FindAsync(id);

            var authorization = await authorizationService.AuthorizeAsync(User, course, AuthorizationConstants.CanViewCoursePolicy);
            if (!authorization.Succeeded)
                return Forbid();

            if (course is null)
                return NotFound();

            return courseMapper.MapCourseView(course);
        }

        // PUT: api/Courses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(Guid id, CourseEditDTO course) {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != course.Id)
                return BadRequest("The request id parameter did not match the course id in the request body.");

            var dbCourse = courseMapper.MapCourseEditDTO(course);

            var authorization = await authorizationService.AuthorizeAsync(User, dbCourse, AuthorizationConstants.CanUpdateCoursePolicy);
            if (!authorization.Succeeded)
                return Forbid();

            _context.Entry(dbCourse).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!CourseExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // POST: api/Courses
        [HttpPost]
        public async Task<ActionResult<CourseEditDTO>> PostCourse(CourseEditDTO course) {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var dbCourse = courseMapper.MapCourseEditDTO(course);

            var authorization = await authorizationService.AuthorizeAsync(User, dbCourse, AuthorizationConstants.CanCreateCoursePolicy);
            if (!authorization.Succeeded)
                return Forbid();

            _context.Courses.Add(dbCourse);
            await _context.SaveChangesAsync();

            dbCourse = await _context.Courses
                .Include(c => c.CourseInfo)
                .Include(c => c.Professor)
                .FirstOrDefaultAsync(c => c.Id == dbCourse.Id);

            return CreatedAtAction("GetCourse", new { id = dbCourse.Id }, courseMapper.MapCourseEdit(dbCourse));
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CourseViewDTO>> DeleteCourse(Guid id) {
            var course = await _context.Courses
                .Include(c => c.Professor)
                .Include(c => c.CourseInfo)
                .Include(c => c.Assistants)
                .Include(c => c.Groups)
                .Include(c => c.Students)
                .Include(c => c.Assignments)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (course is null)
                return NotFound();

            var authorization = await authorizationService.AuthorizeAsync(User, course, AuthorizationConstants.CanDeleteCoursePolicy);
            if (!authorization.Succeeded)
                return Forbid();

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            return courseMapper.MapCourseView(course);
        }

        private bool CourseExists(Guid id) {
            return _context.Courses.Any(e => e.Id == id);
        }
    }
}
