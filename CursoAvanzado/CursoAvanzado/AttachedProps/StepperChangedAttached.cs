using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CursoAvanzado.Attached
{
    public class StepperChangedAttached
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.CreateAttached
            (
                "Command",
                typeof(ICommand),
                typeof(StepperChangedAttached),
                null,
                propertyChanged: OnStepperChanged
            );

        private static void OnStepperChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as Stepper;
            if (control!=null)
            {
                control.ValueChanged += Control_ValueChanged;
            }
        }

        private static void Control_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var control = sender as Stepper;
            var command = GetCommand(control);
            if (command!=null && command.CanExecute(e.NewValue))
            {
                command.Execute(e.NewValue);
            }
        }

        public static ICommand GetCommand (BindableObject view)
        {
            return (ICommand)view.GetValue(CommandProperty);
        }

        public static void SetCommand(BindableObject view, ICommand value)
        {
            view.SetValue(CommandProperty, value);
        }
    }
}
