using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q7
{
    class Schools
    {
        //School Name Property
        public string SchoolName { get; set; }

        //Number of students property
        public int NumOfStudents { get; set; }

        //Display Schhol name and number of Students enrolled
        public void Display(int students)
        {
            NumOfStudents += students;

        }
    }
}
