using System.Globalization;

namespace Kalender_Uebung_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalenderWeekOfToday_Click(object sender, EventArgs e)
        {
            LblCalenderWeek.Text = "Heute ist "+(DateTime.Now).ToString()+" in Kalenderwoche "+KW(DateTime.Now).ToString();
        }

        public static int KW(DateTime Datum)
        {
            CultureInfo CUI = CultureInfo.CurrentCulture;
            return CUI.Calendar.GetWeekOfYear(Datum, CUI.DateTimeFormat.CalendarWeekRule, CUI.DateTimeFormat.FirstDayOfWeek);
        }
    }
}