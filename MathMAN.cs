using System;
using CodeManager;
namespace CodeManager//using忘れずに
{
   public class MathMAN
    {
        public int GetDigitsCount(int num)//桁数を数える関数 //0桁から数える（123　＝＝　2）
        {
            return (num == 0) ? 1 : ((int)Math.Log10(num));
        }

        public int GetDigitsNum(int num, int digit)//指定した桁の数値を得る関数　//0桁から数える（123　, ２　＝＝　1）
        {
            int Return = (int)(num / Math.Pow(10, digit)) % 10;
            return Return;
        }
        public int Rounding(int num, int enddigit = 1, int waste = 5) //四捨五入（waste捨waste+1入）する関数　//enddigitは何桁まで演算するか
        {            
            MathMAN mathMAN = new MathMAN();
            int digits = mathMAN.GetDigitsCount(num) + 1;
            int numdigit = mathMAN.GetDigitsNum(num,0);
            int inc = 0, end = 0;
            while (inc < digits && end < enddigit) 
            {
                if (numdigit >= waste)
                {
                    num = num + (int)Math.Pow(10, inc+1);
                    num = num - (numdigit * (int)Math.Pow(10, inc));
                }
                else if (numdigit < waste)
                {
                    num = num - (numdigit * (int)Math.Pow(10, inc));
                }              
                end++;inc++;
                numdigit = mathMAN.GetDigitsNum(num, inc);
            }
            return num;    
        }
    }
}