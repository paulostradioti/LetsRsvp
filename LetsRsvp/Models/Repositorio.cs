using System.Collections.Generic;

namespace LetsRsvp.Models
{
    public static class Repositorio
    {
        private static List<Confirmacao> confirmacoes = new List<Confirmacao>()
        {
            new Confirmacao
            {
                Nome = "Paulo Ricardo Stradioti",
                Telefone = "11 960822400",
                Confirmado = true
            },

            new Confirmacao
            {
                Nome = "Luiz Augusto",
                Telefone = "11 123456789",
                Confirmado = true
            },

            new Confirmacao
            {
                Nome = "Betina Rudolph",
                Telefone = "11 123456789",
                Confirmado = true
            },

            new Confirmacao
            {
                Nome = "Sofia Bernardino",
                Telefone = "11 123456789",
                Confirmado = true
            },
        };

        public static IEnumerable<Confirmacao> Confirmacoes { get => confirmacoes; }

        public static void AdicionaConfirmacao(Confirmacao confirmacao)
        {
            confirmacoes.Add(confirmacao);
        }
    }
}