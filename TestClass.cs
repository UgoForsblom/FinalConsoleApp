using System;

public class Class1
{
    public Class1()
    {
    }

    public int Addition(int num1, int num2)
    {
        return num1 + num2;
    }
    

    public int Addition(int[] num)
    {
        int sum = 0;
       for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];
        }

        return sum;
    }

    public int Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Subtraction(int[] num)
    {
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum -= num[i];
        }

        return sum;
    }


    public int Division(int num1, int num2)
    {
        return num1 / num2;
    }
    public int Division(int[] num)
    { 
         int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum /= num[i];

        }

        return sum/1;
        
        
        
      
    }

    
}
