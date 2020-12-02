using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AnnotationDemo
{
    class AnnotationTest
    {
        public  void Display()
        {
            Console.WriteLine("Emp validation");
            Console.WriteLine("--------------\n");

            Employee objectEmployee = new Employee();

            objectEmployee.name = "harry";
            objectEmployee.age = 34;
            objectEmployee.phoneNumber = "9090909090";
            objectEmployee.email = "tejasvinirpk@gmail.com";

            ValidationContext context = new ValidationContext(objectEmployee,null,null);
            List<ValidationResult> result = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objectEmployee, context, result, true);

            if (!valid)
            {
                foreach (ValidationResult Totalresult in result)
                {
                    Console.WriteLine("member name : {0}", Totalresult.MemberNames.First(),Environment.NewLine);
                    Console.WriteLine("Error : {0}{1}", Totalresult.ErrorMessage, Environment. NewLine);
                }
            }
            else
            {
                Console.WriteLine("name : " +objectEmployee.name+ "\nAge : " + objectEmployee.age+ "\nno : " +objectEmployee.phoneNumber + "\nemail : " +objectEmployee.email);
            }
            Console.WriteLine("press key");



        }
    }
}
