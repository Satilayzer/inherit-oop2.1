using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleAndSquare.Models
{
    abstract class Figure
    {
        public double X { get; set; }

        public double Y { get; set; }

        public abstract void DrawBlack();

        public abstract void HideDrawingBackGround();

        public void MoveRight()
        {
            for (int i = 0; i <= 50; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(100);
                HideDrawingBackGround();
                X++;
            }
        }
    }
}
