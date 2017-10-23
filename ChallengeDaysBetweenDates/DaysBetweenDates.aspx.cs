using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class DaysBetweenDates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //firstDateCalendar.SelectedDate 
            //secondDateCalendar.SelectedDate

            TimeSpan daysBetweenDates = secondDateCalendar
                .SelectedDate.Subtract(firstDateCalendar.SelectedDate);

            if (firstDateCalendar.SelectedDate > secondDateCalendar.SelectedDate)
                daysBetweenDates = firstDateCalendar
                    .SelectedDate.Subtract(secondDateCalendar.SelectedDate);

            timeSpanLabel.Text = "There are " + daysBetweenDates.TotalDays.ToString() + " days between those dates.";
        }
    }
}