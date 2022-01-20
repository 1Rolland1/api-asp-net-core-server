using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiAspNetCoreServer.DataModel.Entities
{
    public class LessonDto
    {
        /// <summary>
        /// Id
        /// </summary> 
        public int Id { get; set; }

        /// <summary>
        /// Номер пары в расписании
        /// </summary>    
        [Required]
        public int Number { get; set; }

        /// <summary>
        /// Группа(ы)
        /// </summary> 
        public List<GroupDto> Groups { get; set; }

        /// <summary>
        /// Преподаватель
        /// </summary> 
        public string Teacher { get; set; }

        /// <summary>
        /// Дисциплина
        /// </summary> 
        [Required]
        public string Discipline { get; set; }                 
                
    }
}