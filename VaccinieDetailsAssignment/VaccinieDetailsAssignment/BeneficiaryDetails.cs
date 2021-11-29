using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinieDetailsAssignment
{
    public class BeneficiaryDetails
    {
        public int RegisterId { get; set; }
        public string BeneficiaryName { get; set; }

        public long BeneficiaryPhoneNumber { get; set; }
        public string BenficiaryCity{ get; set; }
        public int BeneficiaryAge { get; set; }

        public GENDER  BeneficiaryGender { get; set; }

        private static  int AutoIncrementID = 1001;

        public List<Vaccination> VaccinationObject = new List<Vaccination>();

        public List<Vaccination> VaccinationProcess
        {
            get; set;
        }


        
        public BeneficiaryDetails(string beneficiaryName, long beneficiaryPhoneNumber, string beneficiaryCity, int beneficiaryAge, int beneficiaryGender)
        {

            this.BeneficiaryName = beneficiaryName;
            this.BeneficiaryPhoneNumber = beneficiaryPhoneNumber;
            this.BenficiaryCity = beneficiaryCity;
            this.BeneficiaryAge = beneficiaryAge;
            this.BeneficiaryGender = (GENDER)BeneficiaryGender;

            this.RegisterId = AutoIncrementID++;
            

        }

        public void Vaccination_Select(int vaccineType, DateTime vaccineDate)
        {
            if (VaccinationObject.Count == 0)
            {

                var details = new Vaccination(vaccineType, vaccineDate, 1);
                VaccinationObject.Add(details);

                Console.WriteLine($"Your next due date is{details.VaccineDate.AddDays(30).ToString("dd/MM/yyyy")}");
            }
            else if (VaccinationObject.Count == 1)
            {
                var details = new Vaccination(vaccineType, vaccineDate, 2);
                VaccinationObject.Add(details);

                Console.WriteLine("You have completed the vaccination course. " +
                                "Thanks for your participation in the vaccination drive.");

            }
            else if (VaccinationObject.Count >= 2)
            {
                Console.WriteLine("You had 2 doses already.");
            }
        }

      /// <summary>
      /// enum for Gender
      /// </summary>

        public enum GENDER
        {
          FEMALE=1,
          MALE=2,
          TRANSGENDER=3
        };
    }
}
