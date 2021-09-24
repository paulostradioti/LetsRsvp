using LetsRsvp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LetsRsvp.ViewModels
{
    public class ConfirmadosViewModel
    {
        [DisplayName("Digite o Nome para Busca")]
        public string Search { get; set; }

        public IEnumerable<Confirmacao> Confirmados { get; set; }

    }
}
