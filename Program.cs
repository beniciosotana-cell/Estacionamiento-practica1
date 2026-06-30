using System;

namespace Estacionamiento_practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- CAPTURA DE DATOS ---
            Console.WriteLine("=== SISTEMA DE CONTROL DE ESTACIONAMIENTO ===");

            Console.Write("Ingrese la hora de entrada (entero de 0 a 23): ");
            int horaEntrada = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la hora de salida (entero de 0 a 23): ");
            int horaSalida = int.Parse(Console.ReadLine());

            // --- VALIDACIÓN DE DATOS ---
            if (horaSalida <= horaEntrada)
            {
                Console.WriteLine("\n[ERROR] La hora de salida debe ser posterior a la de entrada.");
                Console.WriteLine("\nPresione cualquier tecla para salir...");
                Console.ReadKey();
                return; // Finaliza el programa si la validación falla
            }

            // --- CÁLCULO DEL TIEMPO ---
            int tiempoTotal = horaSalida - horaEntrada;
            Console.WriteLine($"\nTiempo total de estancia: {tiempoTotal} hora(s).");

            // --- APLICACIÓN DE REGLAS DE NEGOCIO ---
            int totalAPagar = 0;

            // Si permanece más de 8 horas, tarifa fija de $180
            if (tiempoTotal > 8)
            {
                totalAPagar = 180;
            }
            // Si el tiempo fue menor o igual a 1 hora, se cobra la hora completa ($30)
            else if (tiempoTotal <= 1)
            {
                totalAPagar = 30;
            }
            // Si está entre 2 y 8 horas: primera hora $30 + adicionales a $20 cada una
            else
            {
                int horasAdicionales = tiempoTotal - 1;
                totalAPagar = 30 + (horasAdicionales * 20);
            }

            // --- MOSTRAR RESULTADOS ---
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"TOTAL A PAGAR: ${totalAPagar}");
            Console.WriteLine("-------------------------------------------");

            // Pausa para ver el resultado
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}



