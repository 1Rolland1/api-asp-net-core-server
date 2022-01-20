using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiAspNetCoreServer.DataModel.Entities
{
    public class Discipline
    {
        /// <summary>
        /// Id
        /// </summary> 
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>    
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Цель дисциплины
        /// </summary>    
        [Required]
        public string DisciplineGoal { get; set; }

        /// <summary>
        /// Задачи дисциплины
        /// </summary>    
        [Required]
        public string DisciplineObjectives { get; set; }

        /// <summary>
        /// Основные разделы
        /// </summary>    
        [Required]
        public string MainSections { get; set; }

        /// <summary>
        /// Предметы
        /// </summary> 
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}