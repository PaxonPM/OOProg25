using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoGame
{
    public class Lego
    {

        //felter
        private string _color;
        private int _legoSize;
        private int _xPos;
        private int _yPos;
        private bool _orientationHorizontal;


        public string Color { get { return _color; } }

        public int XPos { get { return _xPos; } }
        public int YPos { get { return _yPos; } }
        public bool OrientaionHorizontal { get { return _orientationHorizontal; } set { _orientationHorizontal = value; } }


        public Lego(string color, int legoSize, int xPos, int yPos, bool legoHorizontal)
        {
            _color = color;
            _legoSize = legoSize;
            _xPos = xPos;
            _yPos = yPos;
            _orientationHorizontal = legoHorizontal;

        }

        public void Up(int move)
        {
            _yPos += move;

            if (_yPos >=20)
            {
                int tempY = _yPos-20;
                _yPos = 0;
                _yPos += tempY;
            }
        }

        public void Down( int move)
        {
            _yPos -= move;

            if (_yPos <= 0)
            {
                int tempY = Math.Abs(_yPos);
                _yPos = 20;
                _yPos -= tempY;
            }
        
            
        }
        public void left(int move)
        {
            _xPos -= move;

            if (_xPos <= 0)
            {
                int tempX = Math.Abs(_xPos);
                _xPos = 20;
                _xPos -= tempX;
            }
        }
        public void Right(int move)
        {
            _xPos += move;

            if (_xPos >= 20)
            {
                int tempX = _xPos - 20;
                _xPos = 0;
                _xPos += tempX;
            }
        }

    }
}
