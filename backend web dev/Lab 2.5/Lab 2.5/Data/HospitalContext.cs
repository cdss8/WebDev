using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab5.Models;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace lab5.Data
{
    public class HospitalContext : DbContext
    {
        public DbSet<HospitalModel> Hospitals { get; set; }
        public DbSet<LabModel> Labs { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<PatientModel> Patients { get; set; }



        //new join tables
        public DbSet<Doctor_LabModel> Doctor_Lab { get; set; }
        public DbSet<Doctor_PatientModel> Doctor_Patients { get; set; }



        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
            Database.EnsureCreated(); 
        }

        //building the many to many relationships 
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //doctor labs
            modelBuilder.Entity<Doctor_LabModel>().HasKey( dl => new
            {
                dl.LabId,
                dl.DoctorId
            });
            modelBuilder.Entity<Doctor_LabModel>().HasOne(d => d.Doctor).WithMany(dl => dl.Doctor_Lab).HasForeignKey(d => d.DoctorId);
            modelBuilder.Entity<Doctor_LabModel>().HasOne(l => l.Lab).WithMany(dl => dl.Dortor_Lab).HasForeignKey(l => l.LabId);

            //doctor patients
            modelBuilder.Entity<Doctor_PatientModel>().HasKey(dp => new
            {
                dp.PatientId,
                dp.DoctorId
            });
            modelBuilder.Entity<Doctor_PatientModel>().HasOne(d=> d.Doctor).WithMany(dp=> dp.Doctor_Patient).HasForeignKey(d => d.DoctorId);
            modelBuilder.Entity<Doctor_PatientModel>().HasOne(p => p.Patient).WithMany(dp => dp.Doctor_Patient).HasForeignKey(p => p.PatientId);

            base.OnModelCreating(modelBuilder);
        }


        public HospitalContext()
        {

        }

       
    }
}
