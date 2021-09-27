using System.Collections.Generic;

namespace LetsRsvp.Models
{
    public class Repositorio : IRepositorio
    {
        private readonly AppDbContext _context;

        public Repositorio(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Confirmacao> Confirmacoes { get => _context.Confirmacoes; }

        public void AdicionaConfirmacao(Confirmacao confirmacao)
        {

            _context.Confirmacoes.Add(confirmacao);

            if (string.IsNullOrEmpty(confirmacao.Acompanhante))
                confirmacao.Acompanhante = "Sem Acompanhantes";
            
            _context.SaveChanges();
        }
    }
}