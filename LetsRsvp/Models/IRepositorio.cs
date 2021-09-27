using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsRsvp.Models
{
    public interface IRepositorio
    {
        IEnumerable<Confirmacao> Confirmacoes { get; }
        void AdicionaConfirmacao(Confirmacao confirmacao);
    }
}
