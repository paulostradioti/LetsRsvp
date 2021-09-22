using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsRsvp.Models
{
    public static class Repositorio
    {
        private static List<Confirmacao> confirmacoes = new List<Confirmacao>();
        public static IEnumerable<Confirmacao> Confirmacoes { get => confirmacoes; }

        public static void AdicionaConfirmacao(Confirmacao confirmacao)
        {
            confirmacoes.Add(confirmacao);
        }
    }
}
