using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijver
{
    class Wall
    {
        private int leftWall = 0;
        private int upWall = 0;
        private int rightWall = 700;
        private int downWall = 300;

        public int LeftWall { get { return leftWall; } }
        public int UpWall { get { return upWall; } }
        public int RightWall { get { return rightWall; } }
        public int DownWall { get { return downWall; } }
    }
}
