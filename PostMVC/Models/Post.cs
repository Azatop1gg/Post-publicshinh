using System.Collections.Generic;

namespace PostMVC.Models
{
    public class Post
    {
        /// <summary>
        /// Идентификатор поста
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название поста
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Содержание
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Автор поста
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Ссылка на автора
        /// </summary>
        public Author Auhtor { get; set; }

        /// <summary>
        /// Тематики
        /// </summary>
        public ICollection<Category> Categories { get; set; }
    }
}