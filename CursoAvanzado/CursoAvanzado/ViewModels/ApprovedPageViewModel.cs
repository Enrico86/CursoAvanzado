using CursoAvanzado.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAvanzado.ViewModels
{
    public class ApprovedPageViewModel
    {
        public List<Student> Students { get; set; }
        public ApprovedPageViewModel()
        {
            Students = new List<Student>
            {
                new Student
                {
                    Name="Enrico",
                    Score=9.5
                },
                new Student
                {
                    Name="Anais",
                    Score=10
                },
                new Student
                {
                    Name="Mario",
                    Score=4.5
                },
                new Student
                {
                    Name="Ermenegildo",
                    Score=3
                },
                new Student
                {
                    Name="Marcel",
                    Score=6
                }
            };

        }
    }
}
