using ApiAspNetCoreServer.DataModel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiAspNetCoreServer.DataModel.Entities
{
    public class Teacher
    {
        /// <summary>
        /// Id
        /// </summary> 
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>    
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Фото
        /// </summary> 
        public virtual TeacherImage TeacherImage { get; set; }

        /// <summary>
        /// Пол
        /// </summary> 
        public Sex Sex { get; set; }

        /// <summary>
        /// Должность
        /// </summary> 
        public Position Position { get; set; }

        /// <summary>
        /// Предметы
        /// </summary> 
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}