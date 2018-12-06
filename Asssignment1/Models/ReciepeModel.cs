using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asssignment1.Models
{
    public class ReciepeModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string reciepeName { get; set; }
        [Required]
        public string reciepeIngredients { get; set; }
        [Required]
        public string reciepeProcedure { get; set; }
    }
}
