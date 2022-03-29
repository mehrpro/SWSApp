﻿using System;

namespace SWSApp.Models.Configure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SWSApp.Models.Entities;
    public class AcademicYearConfigure : IEntityTypeConfiguration<AcademicYear>
    {
        public void Configure(EntityTypeBuilder<AcademicYear> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.StartTime).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.EndTime).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.YearTilte).IsRequired().HasMaxLength(50);
            builder.HasMany(x => x.Receivers)
                .WithOne(x => x.AcademicYear)
                .HasForeignKey(x => x.AcademicID_FK)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasData(new AcademicYear
            {
                Id = 1,
                YearTilte = "1400-1401",
                StartTime = new DateTime(2021, 09, 23),
                EndTime = new DateTime(2022, 06, 21),
                IsDeleted = false
            });
        }
    }
}
