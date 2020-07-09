using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Usuario.Models;

namespace ODataWebApiIssue2213ReproNonEdm.Data
{
    internal class RecursoRecursoConfiguration : IEntityTypeConfiguration<RecursoRecurso>
    {
        public void Configure(EntityTypeBuilder<RecursoRecurso> builder)
        {
            builder
                .HasOne(fa => fa.Pai)
                .WithMany(f => f.Filhos);
            builder
                .HasOne(fa => fa.Filho)
                .WithMany(f => f.Pais);
        }
    }
}