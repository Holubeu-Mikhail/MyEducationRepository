using System;
using System.Drawing;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;
using Point = System.Windows.Point;

namespace SimplePaint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Bitmap _bitmap;
        private Graphics _graphics;
        Point _pointX, _pointY;
        private Pen _pen = new Pen(Color.Black, 1);

        private bool _isDrawing = false;
        private bool _isErasing = false;

        public MainWindow()
        {
            InitializeComponent();
            _bitmap = new Bitmap((int)Picture.Width, (int)Picture.Height);
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.White);
        }

        private void Canvas_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }
    }
}
