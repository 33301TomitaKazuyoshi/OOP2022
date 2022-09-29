using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework.Models {
    public class Book {
        public int Id { get; set; } //主キー

        [Required]
        [MaxLength(16)]
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int PublishedYear { get; set; }
        public virtual Author Author { get; set; }
    }
}
