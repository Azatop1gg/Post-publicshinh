using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostMVC.Models
{
    public class Author
    {
        /// <summary>
        /// Идентификатор автора
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя автора
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Профессия
        /// </summary>
        public string Profession { get; set; }

        /// <summary>
        /// Посты
        /// </summary>
        public ICollection<Post> Post { get; set; }
    }
}