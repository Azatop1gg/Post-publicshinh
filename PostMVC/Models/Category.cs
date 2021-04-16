using System.Collections.Generic;

namespace PostMVC.Models
{
    public class Category
    {
        /// <summary>
        /// Идентификатор тематики
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название тематики
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Посты
        /// </summary>
        public ICollection<Post>Post { get; set; }
    }
}