internal class Program
{
    private static void Main(string[] args)
    {
       int[] myArray = {15,4,8,12,10};
       Console.WriteLine("Gia tri nho nhat la :" + MinValue(myArray));
    }

     public static int MinValue(int []min)
    {
        int s_min = min[0];

        for (int i = 1; i < min.Length;i++)
        {
            if (min[i] < s_min)
            {
                s_min = min[i];
               
            }
        }

        return s_min;

    }
}