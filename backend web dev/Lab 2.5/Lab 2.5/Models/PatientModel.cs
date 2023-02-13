using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab5.Models
{
    public class PatientModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, fill up the patient's name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, fill up the diagnostic of the patient")]
        [Display(Name = "Disease")]
        public string Disease { get; set; }

        //Relationships
        public List<Doctor_PatientModel> Doctor_Patient { get; set; }


        //Patient-Lab 
        public int LabId { get; set; }
        [ForeignKey("LabId")]
        public LabModel Lab { get; set; }


        //Patient-Hospital 
        public int HospitalId { get; set; }
        [ForeignKey("HospitalId")]
        public HospitalModel Hospital { get; set; }





    }
}
