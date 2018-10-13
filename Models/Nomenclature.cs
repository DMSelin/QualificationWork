using System;
using System.ComponentModel.DataAnnotations;

namespace QualificationWork.Models
{
    public class Nomenclature
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Код")]
        public string Code { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Display(Name = "Дата создания")]
        public DateTime CreatedDate { get; set; }

        public Guid CreateUserId { get; set; }

        [Display(Name = "Дата изменения")]
        public DateTime UpdateDate { get; set; }

        public Guid UpdateUserId { get; set; }

        [Display(Name = "Цена")]
        public string Price { get; set; }


        public bool IsActive { get; set; }
    }
}
