using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudEf.Models
{
    public class Aluno
    {
        [Key()]
        public int AlunoId { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
    }
}
