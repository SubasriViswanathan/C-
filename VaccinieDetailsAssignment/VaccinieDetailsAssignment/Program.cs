using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinieDetailsAssignment
{
    class VaccineProgram
    {
        VaccineProgram VaccinieObject = new VaccineProgram();

        private static List<BeneficiaryDetails> BeneficiaryDetailsObject = new List<BeneficiaryDetails>();
        public static List<Vaccination> VaccinationObject = new List<Vaccination>();

        static void Main(string[] args)
        {
            
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
            Console.WriteLine("::::::::::::VACCINATION MANAGEMENT SYSTEM\n");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");

            var Detail1 = new BeneficiaryDetails("Subha", 356599874, "Thanjai", 23, 1);
            var Detail2 = new BeneficiaryDetails("Abi", 7897899890, "Chennai", 23, 1);
            var Detail3 = new BeneficiaryDetails("Krishna", 987378479, "Brindhavan", 19, 2);
            var Detail5 = new BeneficiaryDetails("radha", 87897479, "Brindhavan", 20, 2);
            BeneficiaryDetailsObject.Add(Detail1);
            BeneficiaryDetailsObject.Add(Detail2);
            BeneficiaryDetailsObject.Add(Detail3);
            BeneficiaryDetailsObject.Add(Detail5);

            string Beneficiaryshow = Choice.No.ToString();
            do
            {
                int firstAction;
                bool firstActionFlag = true;

                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("1 => Beneficiary Registration  \n2 => Vaccination \n3 =>Exit ");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Enter input");
                firstAction = int.Parse(Console.ReadLine());
                if (firstActionFlag)
                {
                    switch (firstAction)
                    {
                        case 1:
                            VaccineRegistration();
                            Beneficiaryshow = Choice.No.ToString();
                            break;
                        case 2:
                            VaccinationShow();
                            Beneficiaryshow = Choice.No.ToString();
                            break;
                        case 3:
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Application Closed");
                            Console.WriteLine("-------------------------------------");
                            Beneficiaryshow = Choice.YES.ToString();
                            break;
                        default:
                            Console.WriteLine("Enter valid Input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter Valid Number");
                    break;
                }
            } while (Beneficiaryshow == Choice.No.ToString());

            Console.ReadLine();
        }


        /// <summary>
        /// This method is used to Register of Vaccination
        /// </summary>
        public static void VaccineRegistration()
        {
            string vaccineregshow = Choice.YES.ToString();
            bool vaccineregshowFlag = true;
            if (vaccineregshowFlag)
            {
                Console.WriteLine("Enter Your Name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Your PhoneNumber");
                long phn_Number = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your City");
                string city = Console.ReadLine();

                Console.WriteLine("Enter Your Age");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your Gender 1 => FEMALE 2 => MALE 3 => TRANSGENDER ");
                int gen = int.Parse(Console.ReadLine());

                Console.WriteLine("Vaccine Type 1 => COVAXIN 2=> COVIDSHIELD 3=> SPUTNIX");
                string vaccineType = Console.ReadLine();

                string id = string.Empty;
                foreach (var a in BeneficiaryDetailsObject)
                {
                    a.BeneficiaryName = name;
                    a.BeneficiaryPhoneNumber = phn_Number;
                    a.BenficiaryCity = city;
                    a.BeneficiaryAge = age;
                }
                var Detail4 = new BeneficiaryDetails(name, phn_Number, city, age, gen);


                Console.WriteLine($"\n Hello !!{name}\nYour city is {city}");
                Console.WriteLine($"You are vaccinated and Your registration id is {Detail4.RegisterId }");
                BeneficiaryDetailsObject.Add(Detail4);

            }

        }

       /// <summary>
       /// This method is used to know the beneficiary Details
       /// </summary>       
       
        public static void VaccinationShow()
        {
            Console.WriteLine("Enter Id to Know Information");
            int Regid = int.Parse(Console.ReadLine());

            BeneficiaryDetails newbeneficiary = null;
            foreach (BeneficiaryDetails a in BeneficiaryDetailsObject)
            {
                if (Regid == a.RegisterId)
                {
                    newbeneficiary = a;
                }
            }
            if (newbeneficiary != null)
            {
                Console.WriteLine("1 => TakeVaccination 2=> VccinationHistory 3=> Due Date");
                int SencondAction = int.Parse(Console.ReadLine());

                switch (SencondAction)
                {
                    case 1:
                        TakeVaccination();
                        break;
                    case 2:
                       VaccinationHistory(newbeneficiary);

                        break;
                    case 3:
                        VaccinationDetails();
                        ShowDetails();
                        Console.WriteLine();
                        break;
                    default:
                        break;

                }

            }
            else
            {
                Console.WriteLine("Invalid Id");
            }

        }

        public static void VaccinationDetails()
        {
            bool RegisterNumberFlag = false;

            string RegisterNumber = string.Empty, GetRegisterNumber = Choice.YES.ToString();

            Console.WriteLine("Enter Your Id");
            int Regid = int.Parse(Console.ReadLine());

            string name = string.Empty;


            foreach (BeneficiaryDetails c in BeneficiaryDetailsObject)
            {
                if (Regid == c.RegisterId)
                {
                    if (c.VaccinationObject != null)
                    {
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine($"Registratuion Number:{ c.RegisterId} \n BeneficiaryName:{c.BeneficiaryName}\n Vaccinated Dose: {2}");
                        Console.WriteLine("---------------------------------------------------------------");
                    }

                }

            }

        }

        /// <summary>
        /// This method is used to take Vaccination
        /// </summary>
        public static void TakeVaccination()
        {

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Select your Vaccine:\n1.Covaxin\n2.Covishield\n3.Sputnic");
            int _VaccineType = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Register Number");
            int regiterNumber = int.Parse(Console.ReadLine());

            DateTime date = DateTime.Now;



            foreach (BeneficiaryDetails d in BeneficiaryDetailsObject)
            {
                if (d.RegisterId == regiterNumber)
                {
                    Vaccination vaccinedetail = new Vaccination(_VaccineType, date, 2);     
                }
            }
            Console.WriteLine(".............Vaccinated Successfully your 2nd dosage.....................");
        }
        /// <summary>
        /// Adding Existing Users
        /// </summary>
        public static void ShowDetails()
        {
            var Detail1 = new BeneficiaryDetails("Subha", 356599874, "Thanjai", 23, 1);
            var Detail2 = new BeneficiaryDetails("Abi", 7897899890, "Chennai", 23, 1);
            var Detail3 = new BeneficiaryDetails("Krishna", 987378479, "Brindhavan", 19, 2);
            var Detail5 = new BeneficiaryDetails("radha", 87897479, "Brindhavan", 20, 2);

            Detail1.Vaccination_Select(1, DateTime.Now);
            Detail2.Vaccination_Select(2, DateTime.Now);
            Detail3.Vaccination_Select(1, DateTime.Now);
            Detail5.Vaccination_Select(1, DateTime.Now);

        }

        /// <summary>
        /// This method display the Vaccination History
        /// </summary>
        /// 
        public static void VaccinationHistory(BeneficiaryDetails newBeneficiary)
        {

            Console.WriteLine("Again Enter Your ID");
            int Regid = int.Parse(Console.ReadLine());

            foreach (BeneficiaryDetails c in BeneficiaryDetailsObject)
            {
                if(Regid==c.RegisterId)
                {
                    Console.WriteLine($"ID:{c.RegisterId}\nDosage  :{c.VaccinationProcess}\nPhoneNumber :{c.BeneficiaryPhoneNumber}");
                }
                

            }

        }

        /// <summary>
        /// enum for Userchoice
        /// </summary>
        public enum Choice
        {
            YES,
            No
        };


        /// <summary>
        /// enum for Selection Of Vaccine
        /// </summary>
        public enum Vaccine
        {
            COVIDSHIELD,
            COVAXIN,
            SPUTNIC
        };
    }
}