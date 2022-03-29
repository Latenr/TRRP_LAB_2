using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRRP_LAB_2
{
    public class Record
    {
        public Record(int id_appointment,string doctor,string department,string hospital,string patient,int age,string reason)
        {
            Id_appointment = id_appointment;
            Doctor = doctor;
            Department = department;  
            Hospital = hospital;
            Patient = patient;
            Age = age;
            Reason = reason;
        }
        public int Id_appointment { get; set; }
        public string Doctor { get; set; }
        public string Department { get; set; }
        public string Hospital { get; set; }
        public string Patient { get; set; }
        public int Age { get; set; }    
        public string Reason { get; set; }


    }
    
}
