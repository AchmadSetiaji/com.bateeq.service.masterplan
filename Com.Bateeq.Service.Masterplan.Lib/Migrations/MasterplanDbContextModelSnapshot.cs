﻿// <auto-generated />
using Com.Bateeq.Service.Masterplan.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.Bateeq.Service.Masterplan.Lib.Migrations
{
    [DbContext(typeof(MasterplanDbContext))]
    partial class MasterplanDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Bateeq.Service.Masterplan.Lib.Models.BlockingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("BookingOrderId");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("BlockingPlans");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Masterplan.Lib.Models.BlockingPlanWorkSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Article");

                    b.Property<int>("BlockingPlanId");

                    b.Property<string>("Counter");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<DateTimeOffset>("DeliveryDate");

                    b.Property<double>("EH_Booking");

                    b.Property<double>("EH_Remaining");

                    b.Property<int>("Efficiency");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("RO");

                    b.Property<int>("RemainingEh");

                    b.Property<string>("Remark");

                    b.Property<double>("SMV_Sewing");

                    b.Property<string>("Style");

                    b.Property<int>("TotalOrder");

                    b.Property<string>("UnitId");

                    b.Property<string>("UnitText");

                    b.Property<int>("WeekId");

                    b.Property<string>("WeekText");

                    b.Property<int>("YearId");

                    b.Property<string>("YearText")
                        .HasMaxLength(100);

                    b.Property<bool>("isConfirmed");

                    b.HasKey("Id");

                    b.HasIndex("BlockingPlanId");

                    b.ToTable("BlockingPlanWorkSchedules");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Masterplan.Lib.Models.BookingOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int?>("BlockingPlanId");

                    b.Property<DateTimeOffset>("BookingDate");

                    b.Property<int>("BuyerId");

                    b.Property<string>("BuyerName")
                        .HasMaxLength(300);

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<DateTimeOffset>("DeliveryDate");

                    b.Property<int?>("InitialOrderQuantity");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<int>("OrderQuantity");

                    b.Property<string>("Remark");

                    b.Property<int>("SectionId");

                    b.Property<string>("SectionName")
                        .HasMaxLength(300);

                    b.Property<int>("SerialNumber");

                    b.HasKey("Id");

                    b.HasIndex("BlockingPlanId")
                        .IsUnique()
                        .HasFilter("[BlockingPlanId] IS NOT NULL");

                    b.ToTable("BookingOrders");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Masterplan.Lib.Models.BookingOrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Article")
                        .HasMaxLength(500);

                    b.Property<int>("BookingOrderId");

                    b.Property<DateTimeOffset>("ConfirmDate");

                    b.Property<string>("Counter")
                        .HasMaxLength(500);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<DateTimeOffset>("DeliveryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("RO")
                        .HasMaxLength(100);

                    b.Property<string>("Remark");

                    b.Property<string>("Style")
                        .HasMaxLength(500);

                    b.Property<int>("Total");

                    b.HasKey("Id");

                    b.HasIndex("BookingOrderId");

                    b.ToTable("BookingOrderDetails");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Masterplan.Lib.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("Remark")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Masterplan.Lib.Models.WeeklyPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("UnitCode");

                    b.Property<string>("UnitId");

                    b.Property<string>("UnitName");

                    b.Property<string>("Year")
                        .HasMaxLength(4);

                    b.HasKey("Id");

                    b.ToTable("WeeklyPlans");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Masterplan.Lib.Models.WeeklyPlanItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("AhTotal");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<int>("Efficiency");

                    b.Property<int>("EhTotal");

                    b.Property<DateTimeOffset>("EndDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<int>("Month");

                    b.Property<int>("Operator");

                    b.Property<int>("RemainingEh");

                    b.Property<DateTimeOffset>("StartDate");

                    b.Property<int>("UsedEh");

                    b.Property<string>("WeekNumber");

                    b.Property<int>("WeeklyPlanId");

                    b.Property<int>("WorkingHours");

                    b.HasKey("Id");

                    b.HasIndex("WeeklyPlanId");

                    b.ToTable("WeeklyPlanItems");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Masterplan.Lib.Models.BlockingPlanWorkSchedule", b =>
                {
                    b.HasOne("Com.Bateeq.Service.Masterplan.Lib.Models.BlockingPlan", "BlockingPlan")
                        .WithMany("WorkSchedules")
                        .HasForeignKey("BlockingPlanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Bateeq.Service.Masterplan.Lib.Models.BookingOrder", b =>
                {
                    b.HasOne("Com.Bateeq.Service.Masterplan.Lib.Models.BlockingPlan", "BlockingPlan")
                        .WithOne()
                        .HasForeignKey("Com.Bateeq.Service.Masterplan.Lib.Models.BookingOrder", "BlockingPlanId");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Masterplan.Lib.Models.BookingOrderDetail", b =>
                {
                    b.HasOne("Com.Bateeq.Service.Masterplan.Lib.Models.BookingOrder", "BookingOrder")
                        .WithMany("DetailConfirms")
                        .HasForeignKey("BookingOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Bateeq.Service.Masterplan.Lib.Models.WeeklyPlanItem", b =>
                {
                    b.HasOne("Com.Bateeq.Service.Masterplan.Lib.Models.WeeklyPlan", "WeeklyPlan")
                        .WithMany("Items")
                        .HasForeignKey("WeeklyPlanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
