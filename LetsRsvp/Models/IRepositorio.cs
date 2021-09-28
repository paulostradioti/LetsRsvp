using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsRsvp.Models
{
    public interface IRepositorio
    {
        IQueryable<Confirmacao> Confirmacoes { get; }
        void AdicionaConfirmacao(Confirmacao confirmacao);
        void Update(Confirmacao confirmacao);
        void Remove(Confirmacao confirmacao);
    }
}
