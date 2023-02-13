using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab5.Models
{
    public class LabModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, fill up the lab department")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, fill up its adress")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please, fill the phone number")]
        [Display(Name = "Phones")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{5})$", ErrorMessage = "Недопустимый формат")]
        public string Phones { get; set; }


        // Relationships
        public List<PatientModel> SickPatients { get; set; }   
        public List<Doctor_LabModel> Dortor_Lab { get; set; } 

        //Lab-Hospital 
        public int HospitalId { get; set; }
        [ForeignKey("HospitalId")]
        public HospitalModel Hospital { get; set; } 

    }
}
