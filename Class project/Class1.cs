using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Class_project
{
    internal class Connect4chips{ }



}


namespace Connect4
{
    public enum DiscType
    {
        Empty,
        Red,
        Yellow
    }

    public class Disc : UserControl
    {
        private DiscType type;

        public DiscType Type
        {
            get { return type; }
            set
            {
                type = value;
                UpdateColor();
            }
        }

        public Disc()
        {
            Width = 75;
            Height = 75;
            Background = Brushes.White;
            BorderThickness = new System.Windows.Thickness(2);
            BorderBrush = Brushes.Black;
        }

        private void UpdateColor()
        {
            switch (type)
            {
                case DiscType.Red:
                    Background = Brushes.Red;
                    break;
                case DiscType.Yellow:
                    Background = Brushes.Yellow;
                    break;
                default:
                    Background = Brushes.White;
                    break;
            }
        }
    }
}




