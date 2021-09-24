using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsRsvp.Models
{
    public class Confirmacao
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "A confirmação é obrigatória")]
        public bool? Confirmado { get; set; }
    }
}
