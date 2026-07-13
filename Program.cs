using System;

namespace Estacionamiento_practical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- CAPTURA DE DATOS ---
            Console.WriteLine("=== SISTEMA DE CONTROL DE ESTACIONAMIENTO ===");

            Console.Write("Ingrese la hora de entrada (entero de 0 a 23): ");
            int horaEntrada = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la hora de salida (entero de 0 a 23): ");
            int horaSalida = Convert.ToInt32(Console.ReadLine());

            // --- VALIDACIÓN DE DATOS ---
            int tiempoTotal;
            if (horaSalida < horaEntrada)
            {
                tiempoTotal = (horaSalida + 24) - horaEntrada;
            }
            else
            {
                tiempoTotal = horaSalida - horaEntrada;
            }

            // --- CÁLCULO DEL TIEMPO ---
            Console.WriteLine($"\nTiempo total de estancia: {tiempoTotal} hora(s).");

            // --- APLICACIÓN DE REGLAS DE NEGOCIO ---
            int totalAPagar = 0;

            if (tiempoTotal <= 0)
            {
                Console.WriteLine("\n[ERROR] El tiempo de estancia debe ser mayor a 0 horas.");
                Console.WriteLine("\nPresione cualquier tecla para salir...");
                Console.ReadKey();
                return;
            }

            if (tiempoTotal > 8)
            {
                totalAPagar = 180;
            }
            else if (tiempoTotal <= 1)
            {
                totalAPagar = 30;
            }
            else
            {
                int horasAdicionales = tiempoTotal - 1;
                totalAPagar = 30 + (horasAdicionales * 20);
            }

            // --- MOSTRAR RESULTADOS ---
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"TOTAL A PAGAR: ${totalAPagar}");
            Console.WriteLine("--------------------------------------------");

            // Pausa para ver el resultado
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}



