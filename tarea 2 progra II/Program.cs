using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_1_progra_II
{
    internal class Program
    {
        static void Main(string[] args)
        {   //definifimos las variables
            int cedula;
            string nombre;
            byte tipo;
            byte horas;
            decimal precio_hora;
            //le pedimos los datos al usuario
            Console.WriteLine("ingrese su numero de cedula:");
            cedula = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese el tipo de empleado (1, 2 o 3):");
            while (!byte.TryParse(Console.ReadLine(), out tipo) || tipo < 1 || tipo > 3)
            {
                Console.WriteLine("Entrada inválida. Ingrese 1, 2 o 3:");
            }
            Console.WriteLine("ingrese las horas trabajadas:");
            horas = byte.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el precio por hora:");
            precio_hora = decimal.Parse(Console.ReadLine());

            //calculamos el salario bruto
            decimal salario_bruto = horas * precio_hora;  
            if (tipo == 1)
            {
                salario_bruto = salario_bruto * 1.15m; //aumentamos un 15% para el tipo de empleado 1
            }
            else if (tipo == 2)
            {
                salario_bruto = salario_bruto * 1.10m; //aumentamos un 10% para el tipo de empleado 2
            }
            else if (tipo == 3)
            {
                salario_bruto = salario_bruto * 1.05m; //aumentamos un 5% para el tipo de empleado 3
            }

            //calculamos el salario neto
            decimal impuesto = salario_bruto * 0.0917m; // 9.17%
            decimal salario_neto = salario_bruto - impuesto; //restamos el impuesto de la CCSS

            //mostramos todos los datos al usuario
            Console.WriteLine($"Cédula: {cedula}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Tipo de Empleado: {tipo}");
            Console.WriteLine($"Horas Trabajadas: {horas}");
            Console.WriteLine($"Precio por Hora: {precio_hora}");
            Console.WriteLine($"Salario Bruto: {salario_bruto}");
            Console.WriteLine($"salario ordinario: {horas * precio_hora}");
            Console.WriteLine($"Aumento por Tipo de Empleado: {salario_bruto - (horas * precio_hora)}");
            Console.WriteLine($"Impuesto de la CCSS: {impuesto}");
            Console.WriteLine($"Salario Neto: {salario_neto}");

            {
            }



        {
        }
    }
}
}


