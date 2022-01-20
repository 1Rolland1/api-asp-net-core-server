using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiAspNetCoreServer.DataModel.Entities
{
    public class Lesson
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
        /// Группа(ы), у которой будет пара
        /// </summary> 
        public virtual ICollection<Group> Groups { get; set; }

        /// <summary>
        /// Преподаватель
        /// </summary> 
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        /// <summary>
        /// Дисциплина
        /// </summary> 
        public int DisciplineId { get; set; }
        public virtual Discipline Discipline { get; set; }

    }
}