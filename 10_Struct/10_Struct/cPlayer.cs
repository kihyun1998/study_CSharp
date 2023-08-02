using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Struct
{
    internal class cPlayer
    {
        public int CardSum(int iSun, int iMoon, int iStar)
        {
            return iSun + iMoon + iStar;
        }

        public string RstTxt(int iCnt, int iSun, int iMoon, int iStar, int iSum)
        {
            return string.Format("{0}회 진행 : 해: {1} 달: {2} 별: {3} ==>> 합계는 {4}입니다.",
                                  iCnt, iSun, iMoon, iStar, iSum);
        }

        public string PlayerPair(int iCnt, int iP1Sum, int iP2Sum)
        {
            int iCk = iP1Sum - iP2Sum;

            if (iCk > 0)
            {
                return string.Format("{0}회차 : Player1이 {1}만큼 더 큽니다.", iCnt, iCk);
            }
            else if (iCk < 0)
            {
                return string.Format("{0}회차 : Player2가 {1}만큼 더 큽니다.", iCnt, Math.Abs(iCk));
            }
            else
            {
                return string.Format("{0}회차 : 무승부", iCnt);
            }
        }

        public string PlayerRst(int iP1Sum, int iP2Sum)
        {
            string strRtn = string.Empty;
            if (iP1Sum > iP2Sum)
            {
                strRtn = "Player1 win";
            }
            else if (iP1Sum < iP2Sum)
            {
                strRtn = "Player2 win";
            }
            else
            {
                strRtn = "Draw";
            }
            return strRtn;
        }
    }
}
