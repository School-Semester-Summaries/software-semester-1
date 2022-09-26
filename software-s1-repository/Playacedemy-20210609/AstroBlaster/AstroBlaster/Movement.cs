using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroBlaster
{
    public class Movement
    {
        public bool DOWN = true;
        public int Speed = 1;
        public Point MoveMeteor(int X, int Y)
        {
            Point point = new Point(X, Y);

            point = new Point(X - Speed, Y);
            return point;
        }
        public int SetSpeed(int SPEED)
        {
            Speed = SPEED;
            if (Speed < 1)
            {
                Speed = 1;
            }
            return Speed;
        }

        public Point MoveShip(int X, int Y)
        {
            Point point = new Point(X, Y);
            if (DOWN)
            {
                if (Y < 212)
                {
                    point = new Point(X, Y + Speed);
                    return point;
                }
                else if (Y >= 212)
                {
                    DOWN = false;
                }
            }
            else
            {
                if (Y > 12)
                {
                    point = new Point(X, Y - Speed);
                    return point;
                }
                else if (Y < 13)
                {
                    DOWN = true;
                }
            }

            return point;

        }

        

        public bool CheckColision(Point SpaceShip, Point Meteor, Size SpaceShipSize, Size MeteorSize)
        {
            int MeteorX = Meteor.X;

            int SpaceWidth = SpaceShipSize.Width;
            int SpaceX = SpaceShip.X + SpaceWidth;

            return (MeteorX >= (SpaceX - 30) && MeteorX <= (SpaceX + 10)) ? true : false;
        
        }

        public Point SetMeteor(Point SpaceShip)
        {
            int Y = 0;
            int X = SpaceShip.Y;

           

            if (DOWN)
            {
                Y = ((X >= 12) && (X < 37)) ? 100 : //0
                ((X >= 37) && (X < 62)) ? 75 :      //25
                ((X >= 62) && (X < 87)) ? 50 :      //50
                ((X >= 87) && (X < 112)) ? 25 :     //75
                ((X >= 112) && (X < 137)) ? 0 :     //100
                ((X >= 137) && (X < 162)) ? 25 :    //125
                ((X >= 162) && (X < 187)) ? 50 :    //150
                ((X >= 187) && (X < 213)) ? 75 : 0; //175
            }
            if (!DOWN)
            {
                Y = ((X >= 12) && (X < 37)) ? 100 : //200
                ((X >= 37) && (X < 62)) ? 125 :     //25
                ((X >= 62) && (X < 87)) ? 150 :     //50
                ((X >= 87) && (X < 112)) ? 175 :    //75
                ((X >= 112) && (X < 137)) ? 200 :   //100
                ((X >= 137) && (X < 162)) ? 175 :   //125
                ((X >= 162) && (X < 187)) ? 150 :   //150
                ((X >= 187) && (X < 213)) ? 125 : 0;//175
            }



            Point point = new Point(823,Y+12);
            return point;
        }
        
        public Point ToHitSpaceShip(Point SpaceShipLocation, int SpaceShipWidth, int SpaceShipHeight)
        {
            Point point = new Point(0, 0);
            int FrontOfSpaceShipY = SpaceShipLocation.Y + (SpaceShipHeight / 2);
            int FrontOfSpaceShipX = SpaceShipLocation.X + SpaceShipWidth;
            point = new Point(FrontOfSpaceShipX, FrontOfSpaceShipY);
            return point;
        }
        


        public Point ToHitMeteor(Point MeteorLocation, int MeteorWidth, int MeteorHeight)
        {
            Point point = new Point(0, 0);//Paint
            int FrontOfMeteor = MeteorLocation.Y + (MeteorHeight / 2);
            point = new Point(MeteorLocation.X, FrontOfMeteor);
            return point;
        }


    }
}