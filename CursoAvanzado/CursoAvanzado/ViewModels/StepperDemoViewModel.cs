using CursoAvanzado.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CursoAvanzado.ViewModels
{
    public class StepperDemoViewModel
    {
        public Command StepChangedCommand { get; set; }
        public Counter CurrentCounter { get; set; }

        public StepperDemoViewModel()
        {
            CurrentCounter = new Counter()
            {
                CurrentValue=0.0d
            };

            StepChangedCommand = new Command((stepperValue) => UpdateCounter((double)stepperValue));
        }

        private void UpdateCounter(double stepperValue)
        {
            CurrentCounter.CurrentValue = stepperValue;
        }
    }
}
