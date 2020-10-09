using System;

namespace Domain
{
    public class ArrayList1
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


        public (int, int, int) Exercise5(int[] listA)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5, então a aplicação deverá retornar 
            //um array A de 15 elementos e verificar quantos numeros estão acima, abaixo ou na média.
            
            int sum = 0;
            int onAverage = 0;
            int aboveAverage = 0;
            int underAverage = 0;

            for (int i = 0; i < listA.Length; i++)
            {
                sum += listA[i];
            }  
            int average = sum/listA.Length;

            foreach (var item in listA)
            {
                if (item > average)
                {
                    aboveAverage++;                        
                }
                else if (item == average)
                {
                    onAverage++;
                }
                else
                {
                    underAverage++;
                }
            }
            return (onAverage, aboveAverage, underAverage);
        }

        public (int[], int[], int[]) Exercise6(int[] listA, int[] listB)
        {
        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 6, então a aplicação deverá retornar um array A com 12 elementos e coloca-los em ordem 
        //crescente, um array B com 12 elementos e coloca-los em ordem decrescente, e construir um array C, onde cada elemento de C é a soma do elemento correspondente de A 
        //Com B. Colocar em ordem crescente a matriz C e apresentar os seus valores.
        var listC = new int[5];

        Array.Sort(listA);
        Array.Sort(listB);
        Array.Reverse(listB);

        for (int i = 0; i < listC.Length; i++)
        {
            listC[i] = listA[i] + listB[i];
        }
        Array.Sort(listC);

        return (listA, listB, listC);
        }
        

    }
}