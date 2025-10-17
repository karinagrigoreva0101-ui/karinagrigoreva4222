using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net.NetworkInformation;

using Grigorevakarina4222.Database.Helpers;
using Grigorevakarina4222.Database.Models;

namespace Grigorevakarina4222.Database.Configurations
{
    public class AcademicDegreeConfiguration: IEntityTypeConfiguration<AcademicDegree>
    {
        private const string TableName = "cd_academic_degree";
        public void Configure(EntityTypeBuilder<AcademicDegree> builder)
        {
            //Задаем первичный ключ
            builder
            .HasKey(p => p.AcademicDegreeId)
                .HasName($"pk_{TableName}_academic_degree_id");

            //Для целочисленного первичного ключа задаем автогенерацию
            builder.Property(p => p.AcademicDegreeId)
                .ValueGeneratedOnAdd();

            //Расписываем, как будут называться колонки в БД, а также их обязательность
            builder.Property(p => p.AcademicDegreeId)
                .HasColumnName("academic_degree_id")
                .HasComment("Идентификатор записи ученой степени");

            builder.Property(p => p.Name)
            .IsRequired()
            .HasColumnName("c_academic_degree_name")
            .HasColumnType(ColumnType.String).HasMaxLength(100)
            .HasComment("Наименование ученой степени");
        }
    }
}
