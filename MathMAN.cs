using System;
using CodeManager;
namespace CodeManager//using�Y�ꂸ��
{
   public class MathMAN
    {
        public int GetDigitsCount(int num)//�����𐔂���֐� //0�����琔����i123�@�����@2�j
        {
            return (num == 0) ? 1 : ((int)Math.Log10(num));
        }

        public int GetDigitsNum(int num, int digit)//�w�肵�����̐��l�𓾂�֐��@//0�����琔����i123�@, �Q�@�����@1�j
        {
            int Return = (int)(num / Math.Pow(10, digit)) % 10;
            return Return;
        }
        public int Rounding(int num, int enddigit = 1, int waste = 5) //�l�̌ܓ��iwaste��waste+1���j����֐��@//enddigit�͉����܂ŉ��Z���邩
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