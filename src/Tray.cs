using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Seb.NET.WeekTray
{
    public partial class Tray : Form
    {
        private string currentWeek;
        private Color textcolor = Color.White;

        public Tray(string[] args)
        {
            InitializeComponent();

            if (args?.Length == 1)
            {
                SetTextColor(args[0]);
            }

            UpdateIcon();
            timer.Start();
        }


        private void UpdateIcon()
        {
            currentWeek = GetCurrentWeekOfYear();
            trayIcon.Icon = GetIconFromText(currentWeek);
        }


        private Icon GetIconFromText(string text)
        {
            Bitmap bitmap = new Bitmap(16, 16);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.Transparent);
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            graphics.DrawString(text, new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Pixel), new SolidBrush(textcolor), -2, 0);

            return Icon.FromHandle(bitmap.GetHicon());
        }


        private static string GetCurrentWeekOfYear()
        {
            DateTime time = DateTime.Now;
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);

            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday).ToString("D2");
        }


        private void OnTimerTick(object sender, EventArgs e)
        {
            if (!currentWeek.Equals(GetCurrentWeekOfYear()))
            {
                UpdateIcon();
            }
        }


        private void SetTextColor(string hex)
        {
            try
            {
                hex = hex.TrimStart('#');
                int r = Convert.ToInt32(hex.Substring(0, 2), 16);
                int g = Convert.ToInt32(hex.Substring(2, 2), 16);
                int b = Convert.ToInt32(hex.Substring(4, 2), 16);
                textcolor = Color.FromArgb(r, g, b);
            }
            catch
            {
                // not a valid hex code
            }
        }


        private void OnMenuItemCloseClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}