namespace lab5.Models
{
    public class Doctor_PatientModel
    {
        public int DoctorId { get; set; }
        public DoctorModel Doctor { get; set; } 



        public int PatientId { get; set; }
        public PatientModel Patient { get; set; }   
    }
}
