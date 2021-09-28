using System.Collections.Generic;
using System.Linq;

namespace LetsRsvp.Models
{
    public class Repositorio : IRepositorio
    {
        private readonly AppDbContext _context;

        public Repositorio(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Confirmacao> Confirmacoes { get => _context.Confirmacoes; }

        public void AdicionaConfirmacao(Confirmacao confirmacao)
        {

            _context.Confirmacoes.Add(confirmacao);

            if (string.IsNullOrEmpty(confirmacao.Acompanhante))
                confirmacao.Acompanhante = "Sem Acompanhantes";
            
            _context.SaveChanges();
        }

        public void Update(Confirmacao confirmacao)
        {
            _context.Confirmacoes.Update(confirmacao);
            _context.SaveChanges();
        }

        public void Remove(Confirmacao confirmacao)
        {
            _context.Confirmacoes.Remove(confirmacao);
            _context.SaveChanges();
        }
    }
}