using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinieDetailsAssignment
{
   public class Vaccination
    {
        public Vaccine _VaccineType { get; set; }
        public int Dosage{ get; }
        public DateTime VaccineDate { get; set; }
        
       
        public Vaccination(int vaccinetype,DateTime vaccineDate,int dosage)
        {
            this._VaccineType = (Vaccine)vaccinetype;
            
            this.VaccineDate = vaccineDate;

            this.Dosage = dosage;
         
        }

        public enum Vaccine
        {
            COVIDSHIELD,
            COVAXIN,
            SPUTNIC
        };
    }
}
