using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una pila para almacenar estudiantes que han completado sus tareas
        Stack<string> tareasCompletadas = new Stack<string>();

        // Crear una cola para gestionar las solicitudes de asesoramiento
        Queue<string> solicitudesAsesoramiento = new Queue<string>();

        // Crear una lista enlazada para almacenar la información detallada de los estudiantes
        LinkedList<Estudiante> listaEstudiantes = new LinkedList<Estudiante>();

        // Agregar estudiantes a la lista
        listaEstudiantes.AddLast(new Estudiante("Juan", "Pérez", 20, "Ingeniería"));
        listaEstudiantes.AddLast(new Estudiante("María", "Gómez", 22, "Ciencias de la Computación"));
        listaEstudiantes.AddLast(new Estudiante("Carlos", "López", 21, "Matemáticas"));

        // Simular tareas completadas y solicitudes de asesoramiento
        tareasCompletadas.Push("Juan");
        tareasCompletadas.Push("María");

        solicitudesAsesoramiento.Enqueue("Carlos");
        solicitudesAsesoramiento.Enqueue("Juan");

        // Generar un informe
        GenerarInforme(tareasCompletadas, solicitudesAsesoramiento, listaEstudiantes);
    }

    static void GenerarInforme(Stack<string> tareasCompletadas, Queue<string> solicitudesAsesoramiento, LinkedList<Estudiante> listaEstudiantes)
    {
        Console.WriteLine("Informe de Estudiantes:");
        Console.WriteLine("-----------------------");

        // Mostrar estudiantes y su información
        foreach (var estudiante in listaEstudiantes)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre} {estudiante.Apellido}, Edad: {estudiante.Edad}, Carrera: {estudiante.Carrera}");
        }

        Console.WriteLine("\nTareas Completadas:");
        // Mostrar estudiantes que completaron tareas (pila)
        while (tareasCompletadas.Count > 0)
        {
            Console.WriteLine($"- {tareasCompletadas.Pop()} ha completado sus tareas.");
        }

        Console.WriteLine("\nSolicitudes de Asesoramiento:");
        // Mostrar solicitudes de asesoramiento (cola)
        while (solicitudesAsesoramiento.Count > 0)
        {
            Console.WriteLine($"- {solicitudesAsesoramiento.Dequeue()} ha solicitado asesoramiento.");
        }
    }
}

class Estudiante
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Carrera { get; set; }

    public Estudiante(string nombre, string apellido, int edad, string carrera)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Carrera = carrera;
    }
}
