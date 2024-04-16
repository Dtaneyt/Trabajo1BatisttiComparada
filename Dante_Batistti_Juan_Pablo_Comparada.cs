using System;

class Program {
    static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";

    static void Main() {
        Console.WriteLine("Ingrese la distancia del cifrado:");
        int distancia = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la frase a cifrar:");
        string mensajeOriginal = Console.ReadLine();

        while (string.IsNullOrEmpty(mensajeOriginal)) {
            Console.WriteLine("Ingrese un mensaje no vacío:");
            mensajeOriginal = Console.ReadLine();
        }

        string mensajeCifrado = Cifrar(mensajeOriginal, distancia);
        Console.WriteLine("Mensaje cifrado: " + mensajeCifrado);

        Console.WriteLine("\nIngrese el mensaje cifrado para descifrar:");
        string mensajeCifradoInput = Console.ReadLine();

        string mensajeDescifrado = Descifrar(mensajeCifradoInput, distancia);
        Console.WriteLine("Mensaje descifrado: " + mensajeDescifrado);
    }

    static string Cifrar(string mensaje, int distancia) {
        string mensajeCifrado = "";

        foreach (char caracter in mensaje) {
            int indice = alfabeto.IndexOf(caracter);
            if (indice == -1) {
                mensajeCifrado += caracter;
            } else {
                int indiceCifrado = (indice + distancia) % alfabeto.Length;
                mensajeCifrado += alfabeto[indiceCifrado];
            }
        }

        return mensajeCifrado;
    }

    static string Descifrar(string mensajeCifrado, int distancia) {
        string mensajeDescifrado = "";

        foreach (char caracter in mensajeCifrado) {
            int indice = alfabeto.IndexOf(caracter);
            if (indice == -1) {
                mensajeDescifrado += caracter;
            } else {
                int indiceDescifrado = (indice - distancia + alfabeto.Length) % alfabeto.Length;
                mensajeDescifrado += alfabeto[indiceDescifrado];
            }
        }

        return mensajeDescifrado;
    }
}
