using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Classes
{
    internal class Rectangle
    {
        private string name { get; set; }
        private double Width { get; set; }
        private double Height { get; set; }

        private string Color { get; set; }


        public Rectangle(double width, double height, string color)
        {

            Check(width, height);
            Color = color;
        }
        public Rectangle() { }
 
        private void Check(double width, double height)
        {
            if (width > 0.0 & height > 0.0)
            {
                Width = width;
                Height = height;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом", width), "width");
            }
        }
        public string[] answRec()
        {
            string[] answ = { name, Width.ToString(), Height.ToString(), Color };
            return answ;
        }
        public void Chenge(double width, double height, string color)
        {
            Check(width, height);
            Color = color;

        }
        public int getWith()
        {

            return (int)Width;
        }
    }
}
