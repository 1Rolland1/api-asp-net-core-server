using ApiAspNetCoreServer.DataModel;
using ApiAspNetCoreServer.DataModel.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAspNetCoreServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LessonsController : ControllerBase
    {
        private readonly ILogger<LessonsController> _logger;
        private readonly TimetableContext _timetableContext;

        public LessonsController(ILogger<LessonsController> logger, 
            TimetableContext timetableContext)
        {
            _logger = logger;
            _timetableContext = timetableContext;
        }

        [HttpGet]
        public IEnumerable<LessonDto> Get()
        {
            return _timetableContext.Lessons
                .Include(x=> x.Groups)                
                .Select(x=> new LessonDto() { 
                Id = x.Id,
                Number = x.Number,
                Groups = x.Groups.Select(y=> new GroupDto() { 
                    Id = y.Id,
                    GroupName = y.GroupName,
                    NumberOfStudents = y.NumberOfStudents,                                      
                }).ToList(),
                Teacher = x.Teacher.Name,
                Discipline = x.Discipline.Name       
                });
        }

        [HttpPost]
        public int Post(LessonDto dto)
        {           

            var teacher = _timetableContext.Teachers.FirstOrDefault(x => x.Name == dto.Teacher);
            if (teacher == null)
                throw new Exception("Teacher not found");
            var discipline = _timetableContext.Disciplines.FirstOrDefault(x => x.Name == dto.Discipline);
            if (teacher == null)
                throw new Exception("Discipline not found");

            //var groupNames = dto.Groups.Where(x => !x.Id.HasValue).Select(x => x.GroupName).ToList();
            //var groups = _timetableContext.Groups.Where(x => groupNames.Contains(x.GroupName)).ToList();


            var groups = new List<Group>();

            foreach (var groupDto in dto.Groups)
            {
                var group = _timetableContext.Groups.FirstOrDefault(x=> x.GroupName == groupDto.GroupName);
                if (group == null)
                    throw new Exception("Group not found");

                groups.Add(group);
            }

            var lesson = new Lesson() { 
                Number = dto.Number,                
                Discipline = discipline,
                DisciplineId = discipline.Id,
                Teacher = teacher,
                TeacherId = teacher.Id,                               
                Groups = groups
            };

            _timetableContext.Add(lesson);
            _timetableContext.SaveChanges();

            return lesson.Id;
        }

        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public void Delete(int id)
        {
            var lesson = _timetableContext.Lessons.FirstOrDefault(x => x.Id == id);
            if (lesson == null)
                throw new Exception("Lesson not found");          

            _timetableContext.Remove(lesson);
            _timetableContext.SaveChanges();
        }
    }
}
