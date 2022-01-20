using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiAspNetCoreServer.DataModel.Entities
{
    public class Group
    {
        /// <summary>
        /// Id
        /// </summary> 
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>    
        [Required]
        public string GroupName { get; set; }

        /// <summary>
        /// Кол-во студентов
        /// </summary> 
        public int? NumberOfStudents { get; set; }               

        /// <summary>
        /// Предметы
        /// </summary> 
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}