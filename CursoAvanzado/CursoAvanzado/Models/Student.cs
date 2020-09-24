using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAvanzado.Models
{
    public class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public bool IsApproved 
        { 
            get
            {
                if (Score >= 6)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
