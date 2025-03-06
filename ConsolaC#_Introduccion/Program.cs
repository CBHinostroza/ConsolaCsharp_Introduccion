// 1. Escriba un programa en C# que imprima Hola en la primera linea y tu nombre en la siguiente linea.
Console.WriteLine("Hello World! ");
Console.WriteLine("Mi nombre es: Bryan Hinostroza");

/*
2. Escribe un programa en C# que pregunte al usuario ¿Cuál es tu animal favorito?. 
Después detén la ejecución del programa utilizando la instrucción Console.Read. 
Cuando el usuario pulse Intro el programa responderá ¡El mio también! en la segunda linea.
*/

Console.WriteLine("\n");
Console.WriteLine("¿Cuál es tu animal favorito?");
int valor = Console.Read(); // Lee la entrada del usuario
char dato = Convert.ToChar(valor); // Convierte el valor a char
Console.WriteLine("¡El mio también!" + dato); // Imprime el valor
Console.ReadLine();

Console.WriteLine("\n");
Console.WriteLine("¿Cual tu apellido paterno?");
string apellido = Console.ReadLine() + "";
Console.WriteLine("Tu apellido paterno es: " + apellido);


/*
3. Crea un programa en C# que pregunte al usuario en la primera linea ¿Cómo te llamas? 
y guarde el nombre en la variable x.
El programa debe responder en la segunda linea con Encantado de conocerte, x.
*/

Console.WriteLine("\n");
Console.WriteLine("¿Cómo te llamas?");
string nombre = Console.ReadLine() + ""; // Lee la entrada del usuario
Console.WriteLine("Encantado de conocerte, " + nombre);

/*
4. Crea un programa en C# que no haga nada. Lo único que deberás hacer será escribir un comentario 
//TODO en el Main del programa y añadir un comentario de varias lineas con tu nombre y 
la fecha de creación en la primera linea del programa.
*/

/*
 Carlos Bryan Hinostroza Araujo
 22/09/2021
*/
public class Comentarios
{
    public static void Main(string[] args)
    {
        // TODO: Implementar funcionalidad principal
    }
}
