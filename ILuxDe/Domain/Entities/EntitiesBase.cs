using System;
using System.ComponentModel.DataAnnotations;

namespace ILuxDe.Domain.Entities
{
    public class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Название(Заголовок)")]
        public virtual string Title { get; set; }
        
        [Display(Name = "Краткое описание")]
        public virtual string Subtitle { get; set; }
        
        [Display(Name = "Полное описание")]
        public virtual string Text { get; set; }
        
        [Display(Name = "Титульная картинка")]
        public virtual string TitleImagePath { get; set; }
        
        [Display(Name = "Seo метатег Title")]
        public string MetaTitle { get; set; }
        
        [Display(Name = "Seo метатег Description")]
        public string MetaDescription { get; set; }
        
        [Display(Name = "Seo метатег Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }

    }
}
