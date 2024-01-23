
// objetos


using EjercicioClase;

SuperHeroe Batman = new SuperHeroe();
Batman.Nombre = "Batman";
Batman.IdentidadSecreta = "Bruno Diaz";
Batman.Ciudad = "Gotica";
Batman.PuedeVolar = false;
Batman.Poder.Nombre = "Intelecto";
Batman.Poder.Descripcion = "Habilidades como detective";
Batman.Poder.Nivel = 5;
Batman.Imprimir();

Console.WriteLine("----------------------------------------------------------------------------------------------------------");

SuperHeroe LinternaVerde = new SuperHeroe();
LinternaVerde.Nombre = "Linterna verde";
LinternaVerde.IdentidadSecreta = "Hal Jordan";
LinternaVerde.Ciudad = "Sector 2814";
LinternaVerde.PuedeVolar = true;
LinternaVerde.Poder.Nombre = "Semi-invulnerable, proyecciones solidadas de luz, volar";
LinternaVerde.Poder.Descripcion =  "Capacidad de proyectar objetos solidad por medio de la luz";
LinternaVerde.Poder.Nivel=4;
LinternaVerde.Imprimir();

Console.WriteLine("----------------------------------------------------------------------------------------------------------");
SuperHeroe Flash = new SuperHeroe();
Flash.Nombre = "Flash";
Flash.IdentidadSecreta ="Barry Allen";
Flash.Ciudad = "Central City";
Flash.PuedeVolar = false;
Flash.Poder.Nombre = "Velocidad sobrehumana";
Flash.Poder.Descripcion = "Capacidad de romper las leyes de la fisica";
Flash.Poder.Nivel = 5;
Flash.Imprimir();