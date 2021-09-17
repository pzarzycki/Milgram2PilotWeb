﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Milgram2PilotWeb;

namespace Milgram2PilotWeb.Migrations
{
    [DbContext(typeof(SurveyDbContext))]
    [Migration("20210917180816_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Milgram2PilotWeb.SurveyResponse", b =>
                {
                    b.Property<int>("SurveyResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ResponseJson")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ResponseTime")
                        .HasColumnType("TEXT");

                    b.HasKey("SurveyResponseId");

                    b.ToTable("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}