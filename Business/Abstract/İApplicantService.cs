using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface İApplicantService
    {
        void ApplyForMask(Person person);
       
        List<Person> GetList();


        bool CheckPerson(Person person);
       
    }
}
