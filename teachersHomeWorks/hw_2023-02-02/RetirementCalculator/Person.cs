using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementCalculator
{
    public class Person
    {
        public static int retirementAgeMan = 65;
        public static int retirementAgeWoman = 60;
        public static int comingOfAge = 18;

        public enum GendersEnum 
        {
            Man = 1
            ,Woman
        }

        public enum AgeGroupsEnum 
        {
            child
            ,working
            ,retired
        }


        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public GendersEnum Gender { get; set; }

        private DateOnly _retirementDate;
        public DateOnly RetirementDate { get { return _retirementDate; } }

        public Person (string name, DateOnly birthDate, GendersEnum gender) 
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            InitRetirementDate();
        }

        public int GetAgeYears()
        {
            DateOnly dateNow = DateOnly.FromDateTime(DateTime.Now);
            int age = dateNow.Year - BirthDate.Year;

            if (BirthDate.Month < dateNow.Month)
            {
                return age;
            }
            else if (BirthDate.Month > dateNow.Month)
            {
                return age - 1;
            }
            else if (BirthDate.Day > dateNow.Day)
            {
                return age - 1;
            }
            else
            {
                return age;
            }
        }

        public AgeGroupsEnum GetAgeGroup()
        {
            if (GetAgeYears() > comingOfAge) 
            {
                if (Gender == GendersEnum.Man)
                {
                    return GetAgeYears() > retirementAgeMan ? AgeGroupsEnum.retired : AgeGroupsEnum.working;
                }
                if (Gender == GendersEnum.Woman)
                {
                    return GetAgeYears() > retirementAgeWoman ? AgeGroupsEnum.retired : AgeGroupsEnum.working;
                }
            }
            return AgeGroupsEnum.child;
        }

        private void InitRetirementDate()
        {
            _retirementDate = (Gender == GendersEnum.Man) ?
                (BirthDate.AddYears(retirementAgeMan)) : (BirthDate.AddYears(retirementAgeWoman));
        }

        public override string ToString()
        {
            return $"Name: {Name}; \tBirth Date: {BirthDate}; \tAge:{GetAgeYears()}; \tGender: {Gender}; " +
                $"\tAge group: {GetAgeGroup()}; \tRetirement Date: {RetirementDate}";
        }
    }
}
