using System.Collections.Generic;

namespace lesson4
{
    public static class Calculation
    {
        
        public static List<double> tab (double x0, double xn, double hx)
        {
            List<double> y = new List<double>();
            
            for (var x = x0; x <= xn; x += hx)
            {
              y.Add(2 * x + 5);
            }
            return y;
        }
        

        public static double min(double[] array)
        {
            double temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }                   
                }            
            }

            return array[0];
        }
        
        public static double max(double[] array)
        {
            double temp;
            int size = array.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }                   
                }            
            }

            return array[size - 1];
        }

        public static double average(double[] array)
        {
            double sum = 0;
            int size = array.Length;
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }

            return sum / size;
        }





    }
}