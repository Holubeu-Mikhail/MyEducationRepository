using System.Drawing;
using System.Windows.Forms;

namespace ExampleSQLApp.Helpers
{
    public static class Utilities
    {
        public static void MoveWindow(MouseEventArgs e, Point downPoint, Form form)
        {
            if (downPoint != Point.Empty)
            {
                form.Location = new Point(form.Left + e.X - downPoint.X, form.Top + e.Y - downPoint.Y);
            }
        }

        public static Point GetDownPoint(MouseEventArgs e, bool isUp)
        {
            var result = Point.Empty;

            if (e.Button == MouseButtons.Left)
            {
                if (!isUp)
                {
                    result = new Point(e.X, e.Y);
                }
            }

            return result;
        }
    }
}
