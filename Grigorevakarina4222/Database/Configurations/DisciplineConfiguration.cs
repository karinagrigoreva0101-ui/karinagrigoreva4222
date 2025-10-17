using Grigorevakarina4222.Database.Helpers;
using Grigorevakarina4222.Database.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grigorevakarina4222.Database.Configurations
{
    public class DisciplineConfiguration: IEntityTypeConfiguration<Discipline>
    {
        private const string TableName = "cd_discipline";
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            //Задаем первичный ключ
            builder
            .HasKey(p => p.DisciplineId)
                .HasName($"pk_{TableName}_disciplinep_id");

            //Для целочисленного первичного ключа задаем автогенерацию
            builder.Property(p => p.DisciplineId)
                .ValueGeneratedOnAdd();

            //Расписываем, как будут называться колонки в БД, а также их обязательность
            builder.Property(p => p.DisciplineId)
                .HasColumnName("discipline_id")
                .HasComment("Идентификатор записи дисциплины");

            builder.Property(p => p.Name)
            .IsRequired()
            .HasColumnName("c_вiscipline_name")
            .HasColumnType(ColumnType.String).HasMaxLength(100)
            .HasComment("Наименование дисциплины");
        }
    }
}
