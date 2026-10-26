int [] calificaciones = [72, 85, 91, 60, 43, 78, 95, 55, 88, 67];

Console.WriteLine("\n=== REGISTRO DE CALIFICACIONES ===");

for (int i = 0; i < calificaciones.Length; i++)
{
    Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
}

Console.WriteLine("\n=== ORDEN DESCENDENTE ===");

for (int i = calificaciones.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
}

Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");

int suma = 0;

foreach (int calificacion in calificaciones)
{
    suma += calificacion;
}

double promedio = (double)suma / calificaciones.Length;

Console.WriteLine($"Suma total {suma}");
Console.WriteLine($"Promedio: {promedio}");

Console.WriteLine("\n=== POSICIONES PARES ===");

for (int i = 0; i < calificaciones.Length; i += 2)
{
    Console.WriteLine($"Posición par: {calificaciones[i]}");
    
}

//Sección 2 — While y Do-While: Validación y juego interactivo

Console.WriteLine("\n=== CONTROL DE ACCESO  ===");

sbyte intentos = 0;
string clave = "sena2025";

while (intentos < 3)
{
    Console.Write("Ingrese la clave: ");
    string claveIngresada = Console.ReadLine()!;

    if (claveIngresada == clave)
    {
        Console.WriteLine("Acceso concedido");
        break;
    }
    else
    {
        intentos++;
        Console.WriteLine($" Clave incorrecta. Intentos restantes: {3 - intentos}. ");
    }
    
}

Console.WriteLine("\n=== MENÚ PRINCIPAL  ===");

int opcion;

do
{
    Console.WriteLine("1. Ver promedio del grupo ");
    Console.WriteLine("2. Ver calificación más alta ");
    Console.WriteLine("3. Salir");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"Promedio del grupo: {promedio}");
            break;
        case 2:
            int calificacionMaxima = calificaciones[0];
            for (int i = 1; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] > calificacionMaxima)
                {
                    calificacionMaxima = calificaciones[i];
                }
            }
            Console.WriteLine($"Calificación más alta: {calificacionMaxima}");
            break;
        case 3:
            Console.WriteLine("Hasta luego.");
            break;
        default:
            Console.WriteLine("Opción no válida. Intenta de nuevo.");
            break;
    }
}while (opcion != 3);

// Sección 3 — Break y Continue: Filtrado y búsqueda eficiente

Console.WriteLine("\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");
        int posicionReprobatoria = -1;
        int valorReprobatorio = 0;

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 60)
            {
                posicionReprobatoria = i;
                valorReprobatorio = calificaciones[i];
                break; 
            }
        }

        Console.WriteLine($"Encontrada en posición {posicionReprobatoria}: {valorReprobatorio}");


        Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");
        int totalAprobados = 0;

        foreach (int calificacion in calificaciones)
        {
            if (calificacion <= 60)
            {
                continue; 
            }
            Console.WriteLine($"Aprobado: {calificacion}");
            totalAprobados++;
        }

        Console.WriteLine($"Total aprobados: {totalAprobados}");


        
        Console.WriteLine("\n=== FILTRO COMBINADO ===");
        for (int i = 0; i < calificaciones.Length; i++)
        {
            int calificacion = calificaciones[i];

            
            if (calificacion < 70)
            {
                continue;
            }

            
            if (calificacion >= 91)
            {
                Console.WriteLine($"Búsqueda detenida al encontrar: {calificacion}");
                break;
            }

            Console.WriteLine($"Calificación procesada: {calificacion}");
        }