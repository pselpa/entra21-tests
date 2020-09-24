using System;
using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    class ArrayList1
    {
        public int[] Exercise1(int[] listA, int[] listB)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1, então a aplicação deverá retornar 
            //um array C, onde cada elemento de C é a subtração de um elemento de um array A com um array B.
            
            var listC = new int[5];
 
            for (int i = 0; i < 5; i++) 
            {
                listC[i] = listA[i] - listB[i];
            }
            
            return listC;
        }


        public (int[], int[]) Exercise2(int[] array)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício , então a aplicação deverá retornar 
            //10 inteiros e mostrar os números em ordem direta e inversa a que foram lidos
            
            int[] reversedArray = (int[])array.Clone();
            Array.Reverse(reversedArray);

            var result = (array, reversedArray);
            
            return result;
        }


        public bool Exercise3(int[] listA, int searchNumber)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício , então a aplicação deverá retornar 
            //um array A de 10 elementos e informar se um número qualquer existe no array.

            bool searchResult = false;
           
            foreach (int termo in listA)
            {
                if (termo == searchNumber)
                {
                    searchResult = true;
                    break;
                }
            }
            return searchResult;
        }


        public bool Exercise4(int[] listA, int[] listB)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício , então a aplicação deverá retornar 
            //dois arrays A e B de 10 elementos e verificar se os mesmos são iguais ou diferentes.

            bool areEquals = true;

            Array.Sort(listA);
            Array.Sort(listB);
            for(int i = 0; i < listA.Length; i++)
            {
                if (listA[i] != listB[i])
                {
                    areEquals = false;
                    break;
                }
            }
            return areEquals;
        }

    }
}