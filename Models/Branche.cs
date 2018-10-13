using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QualificationWork.Models
{
    public class Branche
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Код")]
        public string Code { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Директор")]
        public string Director { get; set; }

        [Display(Name = "Адрес")]
        public string Adress { get; set; }

        [Display(Name = "Дата создания")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Дата изменения")]
        public DateTime UpdateDate { get; set; }

        public bool IsActive { get; set; }
    }
}
