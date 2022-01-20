using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiAspNetCoreServer.DataModel.Entities
{
    public class GroupDto
    {

        /// <summary>
        /// Id
        /// </summary> 
        public int? Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>    
        [Required]
        public string GroupName { get; set; }

        /// <summary>
        /// Кол-во студентов
        /// </summary> 
        public int? NumberOfStudents { get; set; }
        
    }
}
