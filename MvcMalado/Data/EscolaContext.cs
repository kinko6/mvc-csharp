using Microsoft.EntityFrameworkCore;
using MvcMalado.Models; // Namespace para o seu modelo

namespace MvcMalado.Data
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options)
            : base(options)
        { }

        // Definindo DbSet para a entidade Aluno
        public DbSet<Aluno> Alunos { get; set; }

        // Definindo DbSet para a entidade Professor
        public DbSet<Professor> Professores { get; set; }

        // Configuração adicional de modelos (se necessário)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Qualquer configuração adicional que você precise pode ser colocada aqui
        }
    }
}
