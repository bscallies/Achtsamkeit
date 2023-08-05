using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//FormFunctions.cs
namespace Achtsamkeit
{
    public static class FormFunctions
    {
        public static void SetTodayDate(Form form, Label label)
        {
            DateTime today = DateTime.Today;
            string formattedDate = today.ToString("MMMM d, yyyy");            
            label.Text = "Today's Date: " + formattedDate;
        }

        public static void Timer_Tick(object sender, EventArgs e, Label labelTimerDisplay)
        {           
            GUI.ElapsedTimeInSeconds++;
            //labelTimerDisplay.Text = GUI.ElapsedTimeInSeconds.ToString();
            string formattedTime = FormatElapsedTime(GUI.ElapsedTimeInSeconds);
            labelTimerDisplay.Text = formattedTime;
        }
        private static string FormatElapsedTime(int elapsedTimeInSeconds)
        {
            int hours = elapsedTimeInSeconds / 3600;
            int minutes = (elapsedTimeInSeconds % 3600) / 60;
            int seconds = elapsedTimeInSeconds % 60;

            return $"{hours:D2}h {minutes:D2}m {seconds:D2}s";
        }
        public static string FormatTimespanIntoDigitalClock(TimeSpan timespan)
        {
            return timespan.ToString(@"hh\:mm\:ss");
        }
    }
}
