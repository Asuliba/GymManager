using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager
{
    public class Member
    {
        //_name (string), _age (int), _isStudent (bool), _visits (int)
        private string _name;
        private int _age;
        private bool _isStudent;
        private int _visits;    

        //Name, Age, IsStudent, Visits.
        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        public bool IsStudent { get { return _isStudent; } }
        public int Visits { get { return _visits; } }

         public Member(string name, int age, bool isStudent)
         {
            _name = name;
            _age = age;
            _isStudent = isStudent;
            _visits = 0;
         }

        public void CheckIn()
        {
            _visits++;
        }

        public string Describe()
        {
            // Kiss Anna (17 éves,diák) -3 látogatás.
            if (_isStudent)
            {
                return $"{_name} ({_age} éves, diák) - {_visits} látogatás.";
            }
            else
            {
                return $"{_name} ({_age} éves, normál) - {_visits} látogatás.";
            }
        }
    }
}
