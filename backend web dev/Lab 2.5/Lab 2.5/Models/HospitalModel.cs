using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab5.Models
{
    public class HospitalModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, fill up the hospital name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, fill up the hospital's direction")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please, fill up the hospital's phone number")]
        [Display(Name = "Phones")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{5})$", ErrorMessage = "Incorrect simbols, please enter numbers")]
        public string Phones { get; set; }

        // Relationships 
        public List<LabModel> Accommodation { get; set; }
        public List<PatientModel> Patients { get; set; }
        public List<DoctorModel> Doctors { get; set; }


    }
}
