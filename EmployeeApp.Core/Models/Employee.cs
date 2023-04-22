using EmployeeApp.Core.Models.Base;

namespace EmployeeApp.Core.Models
{
    public class Employee:BaseModel
    {
        private static int _id;
        public string Name {get; set;}
        public string Surname { get; set;}
        public double Salary { get; set;}
        public string Position { get; set;}

        public Employee()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {Salary} {Position}";
        }
    }
}
