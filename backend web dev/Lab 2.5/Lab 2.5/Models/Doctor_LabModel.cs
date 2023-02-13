namespace lab5.Models
{
    public class Doctor_LabModel
    {
        public int DoctorId { get; set; }
        public DoctorModel Doctor { get; set; }



        public int LabId { get; set; }
        public LabModel Lab { get; set; }   
    }
}
