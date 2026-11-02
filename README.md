 MiPresentacion

Mi primera aplicación gráfica con C# y Avalonia UI 11

Aplicación de escritorio desarrollada como proyecto académico para poner en práctica los conceptos de Programación Orientada a Objetos, interfaces gráficas y programación orientada a eventos.

---

 Descripción del proyecto

MiPresentacion es una aplicación gráfica que permite al usuario ingresar su nombre, apellido y edad para generar una presentación personalizada.

La aplicación cuenta con una interfaz sencilla e intuitiva, validación de datos y diferentes botones que permiten interactuar con el programa.

🛠️ Tecnologías utilizadas

Tecnología| Descripción
C#| Lenguaje de programación.
.NET 8| Plataforma de desarrollo.
Avalonia UI 11| Framework para crear interfaces gráficas.
XAML| Diseño de la interfaz de usuario.
Visual Studio Code| Entorno de desarrollo.

 Funcionalidades principales

-  Ingresar datos: permite escribir nombre, apellido y edad.
-  Presentarme: genera un saludo personalizado.
-  Validar información: comprueba que los campos no estén vacíos y que la edad sea un número entero positivo.
-  Limpiar: borra los campos y restablece el mensaje inicial.
-  Cambiar saludo: permite alternar entre dos mensajes de presentación.

 Interfaz gráfica

La interfaz fue construida utilizando los siguientes controles:

Control| Función
"Window"| Ventana principal.
"StackPanel"| Organiza los elementos verticalmente.
"TextBlock"| Muestra títulos, etiquetas y mensajes.
"TextBox"| Permite ingresar información.
"Button"| Ejecuta las acciones de la aplicación.

También se utilizaron propiedades como "Margin", "Spacing", "FontSize" y "x:Name" para organizar y personalizar los elementos.

 Programación orientada a eventos

La aplicación utiliza eventos "Click" para ejecutar acciones cuando el usuario presiona los botones.

Evento| Descripción
"Presentarme_Click"| Valida los datos y genera la presentación.
"Limpiar_Click"| Limpia los campos y restablece la interfaz.
"CambiarSaludo_Click"| Alterna entre los dos saludos disponibles.

Validaciones implementadas:

- "string.IsNullOrWhiteSpace()" para comprobar que los campos de texto no estén vacíos.
- "int.TryParse()" para verificar que la edad sea un número entero.
- Una condición para comprobar que la edad sea mayor que cero.

 Relación entre XAML y C#

El archivo MainWindow.axaml contiene la estructura visual de la aplicación, incluyendo los botones, etiquetas y campos de texto.

Por otro lado, MainWindow.axaml.cs contiene la lógica que permite que los controles funcionen.

Ambos archivos se comunican mediante la propiedad "x:Name", que permite identificar los controles desde C#, y la propiedad "Click", que conecta los botones con sus respectivos métodos.

De esta manera, la interfaz gráfica y la lógica de programación trabajan conjuntamente para ofrecer una aplicación interactiva.

---

 Evidencias del funcionamiento

1. Presentación personalizada

Muestra los datos ingresados y el mensaje generado por la aplicación.

"Presentación personalizada" (screenshots/01-presentacion.png)

2. Validación de datos

Muestra la advertencia cuando el usuario deja el nombre vacío.

"Validación de datos" (screenshots/02-validacion.png)

3. Cambio de saludo

Muestra el mensaje alternativo generado al presionar el botón correspondiente.

"Saludo alternativo" (screenshots/03-saludo-alternativo.png)

4. Limpiar campos

Muestra la interfaz después de utilizar el botón Limpiar.

"Limpiar campos" (screenshots/04-limpiar.png)

---

 Instrucciones para ejecutar el proyecto

Requisitos previos:

- Tener instalado el SDK de .NET 8.
- Tener instalado Git (opcional, para clonar el repositorio).

Pasos para ejecutar:

1. Clonar el repositorio:
   
   git clone https://github.com/saryduarte/MiPresentacion.git

2. Entrar en la carpeta del proyecto:
   
   cd MiPresentacion

3. Restaurar las dependencias:
   
   dotnet restore

4. Compilar la aplicación:
   
   dotnet build

5. Ejecutar el programa:
   
   dotnet run

---

 Aprendizajes obtenidos

Con este proyecto pude aprender a crear interfaces gráficas utilizando Avalonia UI 11, relacionar archivos XAML con código C#, implementar eventos y validar la información ingresada por el usuario.

También pude fortalecer mis conocimientos sobre programación orientada a objetos y comprender cómo las acciones del usuario pueden generar respuestas dentro de una aplicación de escritorio.

---

Desarrollado por: Saray Duarte
Proyecto académico: Mi primera aplicación gráfica
Lenguaje: C#
Framework: Avalonia UI 11
Plataforma: .NET 8
