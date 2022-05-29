using static System.Console;

WriteLine("Hello, World!");

//1) Array
//var miArray = new int[10];

//for (int i = 0; i < miArray.Length; i++)
//{
//    WriteLine(miArray[i]);
//}

//foreach (var item in miArray)
//{
//    WriteLine(item);
//}


//2) List
//var miLista = new List<string>();

//miLista.Add("Guillermo");
//miLista.Add("July");
//miLista.Add("Annabella");
//miLista.Add("Paola");
//miLista.Add("Shakira");

//foreach (var mi in miLista)
//{
//    WriteLine(mi);
//}


/*
 * Escribir un programa que permita al usuario confeccionar una lista de nombre. Se debe ofrecer las siguientes opciones:
 * Agregar un elemento al final de una posicion determinada
 * Quitar un elemento
 * Mostrar la posicion de un elemento especifico
 * Invertir la lista
 * Ver el contenido de la lista
*/

//PREGUNTA 1.QUE FUNCION CUMPLEN COUNT Y CAPACITY EN UNA LISTA <=====================
//PREGUNTA 2. QUE SON LAS ESTRUCTURAS DE DATOS LIFO Y FIFO Y DAR 1 EJEMPLO DE C/U

var listaNombre = new List<string>();
WriteLine("Bienvenido a la lista de MazzCode. Por favor seleccione una de las siguientes opciones:");

string entradaUsuario;
do
{
    WriteLine("1) Agregar un elemento al final de una posicion determinada");
    WriteLine("2) Quitar un elemento");
    WriteLine("3) Mostrar la posicion de un elemento especifico");
    WriteLine("4) Invertir la lista");
    WriteLine("5) Ver el contenido de la lista");
    WriteLine("0) Salir del programa");
    entradaUsuario = ReadLine();



    switch (entradaUsuario)
    {
        case "1":
            //Agregar un elemento al final de una posicion determinada
            WriteLine("Ingrese el elemento");
            var nuevoElemento = ReadLine();

            WriteLine("¿Donde desea agregar el elemento?");
            WriteLine("1) Al final");
            WriteLine("2) En una posicion especifica");
            var opcionParaIngresar = ReadLine();

            switch (opcionParaIngresar)
            {
                case "1":
                    //al final
                    listaNombre.Add(nuevoElemento);
                    break;

                case "2":
                    //En una posicion especifica
                    WriteLine("Ingrese la posicion deseada");
                    var posicionIngresar = int.Parse(ReadLine());
                    listaNombre.Insert(posicionIngresar, nuevoElemento);
                    break;
            }
            break;

        case "2":
            //Eliminar elemento
            WriteLine("Ingrese el elemnto que desea eliminar");
            var elementoEliminar = ReadLine();
            listaNombre.Remove(elementoEliminar);
            break;

        case "3":
            //Ubicar un elemento
            WriteLine("Ingrese el elemento que desea ubicar");
            var elementoUbicar = ReadLine();
            var posicionIndice = listaNombre.IndexOf(elementoUbicar);
            if (posicionIndice > -1)
            {
                WriteLine($"El elemento se encuentra en la posicion: {posicionIndice}");
            }
            else
            {
                WriteLine("El elemento no existe");
            }
            break;

        case "4":
            //invertir la lista
            listaNombre.Reverse();
            WriteLine("La lista se ha invertido");
            break;

        case "5":
            //Ver el contenido de la lista
            if (listaNombre.Count == 0)
            {
                WriteLine("La lista de nombres esta vacia");
            }

            else
            {
                foreach (var el in listaNombre)
                {
                    WriteLine(el);
                }

            }
            break;
    }

}
while (entradaUsuario != "0");




// ======================================= PILAS ===================================================//
// Last-In, First-Out (LIFO) //

var miPila = new Stack<int>();

miPila.Push(1);
miPila.Push(2);
miPila.Push(3);
miPila.Push(4);

WriteLine(miPila.Pop());
WriteLine(miPila.Pop());
WriteLine(miPila.Pop());
WriteLine(miPila.Pop());



// ======================================= COLAS ===================================================//
// First-IN, First-Out (FIFO) // 

var miCola = new Queue<int>();
miCola.Enqueue(1);
miCola.Enqueue(2);
miCola.Enqueue(3);
miCola.Enqueue(4);

WriteLine(miCola.Dequeue());
WriteLine(miCola.Dequeue());
WriteLine(miCola.Dequeue());
WriteLine(miCola.Dequeue());