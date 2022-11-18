
namespace Answer
{
    public class LCMGCD
    {
          static int  GCD(List<int> arr)
          {
                    var ans = DivideHCF(arr[0], arr[1]);
                    for(int i = 2; i < arr.Count; i++)
                    {
                    ans = DivideHCF(Math.Max(ans, arr[i]), Math.Min(ans, arr[i]));
                    }
                    return (ans);
          }
        static int LCM(List<int> arr)
        {
            var ans = LCMFor2(arr[0], arr[1], arr[0]);
            for(int i = 2; i < arr.Count; i++)
            {
                ans = LCMFor2(ans, arr[i], ans);
            }
            return (ans);
            
        }
        static int DivideHCF(int num1, int num2)
        {
            if(num2 == 0)
            {
                return num1;
            }
            return DivideHCF(num2, num1 % num2);
        }
        static int LCMFor2(int num1, int num2, int num)
        {
            if(num1 % num2 == 0)
            {
                return num1;
            }
            return LCMFor2(num + num1, num2, num);
        }
    }
}