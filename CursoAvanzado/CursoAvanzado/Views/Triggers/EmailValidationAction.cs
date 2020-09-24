using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace CursoAvanzado.Views.Triggers
{
    public class EmailValidationAction : TriggerAction<Entry>
    {
        public const string MatchEmailPattern =
                @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                 + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                            [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                 + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                            [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                 + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

        public static bool IsEmail(string email)
        {
            if (email != null)
            {
                return Regex.IsMatch(email, MatchEmailPattern);
            }
            else return false;
        }

        protected override void Invoke(Entry sender)
        {
            bool IsValid = IsEmail(sender.Text);
            sender.TextColor = IsValid?Color.Default : Color.DarkRed;
            sender.BackgroundColor = IsValid?Color.Default:Color.IndianRed;
        }
    }
}
