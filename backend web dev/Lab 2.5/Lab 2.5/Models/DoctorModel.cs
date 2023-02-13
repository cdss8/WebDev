using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab5.Models
{
    public class DoctorModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, fill up the doctor's name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, fill up the doctor's specialitation")]
        [Display(Name = "Speciality")]
        public string Speciality { get; set; }



        // Relationships 
        public ICollection<Doctor_LabModel> Doctor_Lab { get; set; }
        public ICollection<Doctor_PatientModel> Doctor_Patient { get; set; }

        //Doctor-Hospital 
        public int HospitalId { get; set; }
        [ForeignKey("HospitalId")]
        public HospitalModel Hospital { get; set; }

    }
}
