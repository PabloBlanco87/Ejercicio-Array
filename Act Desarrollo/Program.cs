using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Desarrollo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Realiza un programa que tenga un array de 100 números aleatorios, entre los valores -100 y 100, 
             * y mediante una criba, cree dos arrays. Uno de ellos tendrá únicamente los números positivos, 
             * y el otro, los números negativos.*/

            //Esto es como si tuviese una bolsa llena de canicas rojas y azules, y las quiero meter en dos bolsas, la bolsa de rojas y la bolsa de azules. 
              
            
           // Lo primero es declarar el array de números aleatorios con 100 números enteros, al que en mi caso, he llamado arrayAleatorios

           int[] arrayAleatorios = new int[100];


            /* Declaro dos variables de tipo entero y las inicializo en 0. 
             * Éstas me van a servir como contador de número de veces que al recorrer el array de aleatorios, 
             * cuántos salen positivos, y cuántos negativos. Esto también me sirve para saber el número de valores 
             * que van a tener los arrays que crearé más tarde, el array de números positivos y el array de números negativos*/

            int contadorPositivo = 0;
            int contadorNegativo = 0;

            // Genero la clase Random que me va a dar números aleatorios            

            Random numAleatorios = new Random();

            // Inicio el bucle for de inicio a fin para recorrer el array de números aleatorios

            for (int i = 0; i < arrayAleatorios.Length; i++)
            {
                // Instancio el array de números aleatorio y le asigno valores comprendidos entre -100 y 100
                arrayAleatorios[i] = numAleatorios.Next(-100, 100);


                /* Aquí utilizo el if y el else para que cumplan dos condiciones; cada vez que sea un número positivo, sume una más a mis contador de positivos,
                 * mientras que si es negativo, sumará una más a mi contador negativo, 
                 * de este modo podré saber cuántos valores aleatorios son positivos y cuántos negativos*/ 
                 

                if (arrayAleatorios[i] >= 0)
                {
                    
                    contadorPositivo++;
                }


                else
                {
                    contadorNegativo++;
                }

                //Lo que he hecho en el if y else anterior ha sido averiguar cuántas rojas y cuántas azules hay, pero aún no las he separado en sus dos bolsas correspondientes.*/
            }

            /* Como ya he terminado de recorrer el array de números aleatorios y ya se cuántos valores tendrán los array positivo y array negativo respectivamente
             * declaro e instancio dichos arrays con el índice siendo igual al contador (contadorPositivo en el Array positivo y contadorNegativo en el Array negativo) */ 

            int[] arrayPositivos = new int[contadorPositivo];
            int[] arrayNegativos = new int[contadorNegativo];

            /* Vuelvo a poner los contadores con valor =0, puesto que voy a volver a utilizar estos contadores 
             * para meter el número del array de números aleatorios en su array correspondiente (positivos o negativos).*/
            
                    
            contadorPositivo = 0;
            contadorNegativo = 0;

            /* Lo que hago para separarlas en dos bolsas es sacarlas al azar, y voy sabiendo, que la primera que saco es roja, la segunda es roja también, la tercera es azul... 
             * Con lo que hago con estas variables es saber que la primera que he sacado, va a la bolsa1, la segunda también, la tercera a la bolsa2, etc, hasta que termine con la bolsa*/

            // Vuelvo a recorrer el Array de aleatorios. (Voy sacando las canicas) 

            for (int i=0; i<arrayAleatorios.Length; i++)
            {
                /* Declaro la condición: si el valor aleatorio que nos da el array de números aleatorios es igual o mayor que 0, 
                 * entonces lo igualo al array de positivos. el elemento i-ésimo del array de aleatorios que es igual o superior a 0. 
                 * Si no cumple esta condición, entonces lo igualo al array de negativos, con i-esimas posiciones*/

                if (arrayAleatorios[i] >=0)
                {
                    arrayPositivos[contadorPositivo] = arrayAleatorios[i];
                    contadorPositivo++;

                }

                else
                {
                    arrayNegativos[contadorNegativo] = arrayAleatorios[i];
                    contadorNegativo++;
                }


            }
            // Ya tengo todos los valores repartidos en sus dos arrays correspondientes (positivos y negativos). Ya he metido todas las canicas en sus bolsas correspondientes

            //Muestro en pantalla el siguiente mensaje: 

            Console.WriteLine("Estos son los números 100 números ALEATORIOS comprendidos desde el -100 al 100:");
            Console.WriteLine("");

            /* Quiero mostrar todos los valores del array de números aleatorios. Para ello me ayudo de foreach, que es utilizada para recorrer colecciones de datos (por ejemplo vectores/ o arrays), 
             * también podemos utilizar de forma tradicional las otras estructuras repetitivas, pero utilizar foreach hacen más natural el acceso a los elementos*/

            foreach (int num in arrayAleatorios)
            {
                //Además de escribir por pantalla el número, nos va a separar cada valor con una barra entre medias, para verlo mucho más claro, concatenando después de la variable num + " | " 

                Console.Write(num + " | ");
            }

            // Lo indicado en los dos comentarios anteriores volveré a hacerlo en cada array (positivos y negativos)

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Estos son los números positivos:");

            foreach (int num in arrayPositivos)
            {
                Console.Write(num + " | " );
            }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Estos son los números negativos:");
            foreach (int num in arrayNegativos)
            {
                Console.Write(num + " | ");
            }

            
            Console.ReadKey();

            //Fin del programa


        }

    }
}

