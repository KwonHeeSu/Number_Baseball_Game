using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Snack_winform
{
    internal class RandNum
    {
        private Random rand;
        private int _num;
        private int _innum;
        private int strike = 0;
        private int ball = 0;

        public RandNum()
        {
            rand = new Random();
            _num = rand.Next(1000, 10000);
        }
        
        public int CreateNum()
        {
            _num = rand.Next(1000, 10000);
            return _num;
        }
        
        public int SetNum
        {
            get
            {
                return _num;
            }

            set
            {
                _innum = value;
            }
        }

        public int GetStrike
        {
            get
            {
                return strike;
            }
        }

        public int GetBall
        {
            get
            {
                return ball;
            }
        }

        public void CompareResult()
        {
            strike = 0;
            ball = 0;
            int[] num = { _num / 1000, _num % 1000 / 100, _num % 100 / 10, _num % 10 };
            int[] innum = { _innum / 1000, _innum % 1000 / 100, _innum % 100 / 10, _innum % 10 };
            if (num[0] == innum[0] && num[1] == innum[1] && num[2] == innum[2] && num[3] == innum[3])
            {
                strike = 4;
            }
            else if (num[0] == innum[0] || num[1] == innum[1] || num[2] == innum[2] || num[3] == innum[3])
            {
                if (num[0] == innum[0]) strike++;
                if (num[1] == innum[1]) strike++;
                if (num[2] == innum[2]) strike++;
                if (num[3] == innum[3]) strike++;
                if (num[0] == innum[1]) ball++;
                if (num[0] == innum[2]) ball++;
                if (num[0] == innum[3]) ball++;
                if (num[1] == innum[0]) ball++;
                if (num[1] == innum[2]) ball++;
                if (num[1] == innum[3]) ball++;
                if (num[2] == innum[0]) ball++;
                if (num[2] == innum[1]) ball++;
                if (num[2] == innum[3]) ball++;
                if (num[3] == innum[0]) ball++;
                if (num[3] == innum[1]) ball++;
                if (num[3] == innum[2]) ball++;
            }
            else
            {
                if (num[0] == innum[1]) ball++;
                if (num[0] == innum[2]) ball++;
                if (num[0] == innum[3]) ball++;
                if (num[1] == innum[0]) ball++;
                if (num[1] == innum[2]) ball++;
                if (num[1] == innum[3]) ball++;
                if (num[2] == innum[0]) ball++;
                if (num[2] == innum[1]) ball++;
                if (num[2] == innum[3]) ball++;
                if (num[3] == innum[0]) ball++;
                if (num[3] == innum[1]) ball++;
                if (num[3] == innum[2]) ball++;
            }
        }
    }

    public class CalcClass
    {
        public static bool GetCalcResult(int userNum, int comNum)
        {
            return comNum == userNum;
        }
    }
}
