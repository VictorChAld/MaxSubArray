using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSumElements
    {
    public static int MaxSubArray(int[] nums)
    {
        //Algoritmo Kadane(Sliding window)
        //Este problema se trata de encontrar la combinación de elementos que sume el mayor número dentro del array.
        //El chiste consiste en que, en el array puede haber números negativos que resten a la suma, por lo que no se puede simplemente sumar todos los números del array, si no que hay que recorrer
        //todo el array buscando la mejor combinación de números.
        if (nums.Length == 0)
        {
            return 0;
        }
        if (nums.Length == 1)
        {
            return nums[0];
        }

        int currTotal = 0;
        int localTotal = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            
            localTotal = localTotal + nums[i]; //Esta variable guarda el acumulado de la suma                                              

            if (localTotal < nums[i]) //Sí el número del array es mayor que el acumulado de la suma, simplemente toma su valor -como reiniciando el acumulado-
            {
                localTotal = nums[i];
            }

            if (currTotal < localTotal) //Sí el acumulado es mayor que el total máximo, entonces el acumulado será el nuevo total máximo.
            {
                currTotal = localTotal;
            }           
        }

        return currTotal; //Al final de cuentas, el problema sólo pide el resultado, pero no qué elementos se tuvieron qué sumar para dar con ese resultado, así que así se termina el problema.
    }
}
