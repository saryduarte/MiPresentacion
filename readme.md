MiPresentacion - Mi primera aplicación gráfica

1. Descripción del proyecto

MiPresentacion es una aplicación de escritorio desarrollada en C# utilizando Avalonia UI 11. Su objetivo es permitir que el usuario ingrese su nombre, apellido y edad para generar una presentación personalizada.

Este proyecto permite poner en práctica conceptos de programación orientada a objetos, interfaces gráficas, eventos y validación de datos.

2. Tecnologías utilizadas

- C#
- .NET 8
- Avalonia UI 11
- XAML
- Visual Studio Code

3. Características de la aplicación

La aplicación cuenta con las siguientes funcionalidades:

- Ingresar datos: permite escribir el nombre, apellido y edad del usuario.
- Presentarme: genera un saludo personalizado con los datos ingresados.
- Validar información: comprueba que el nombre y el apellido no estén vacíos y que la edad sea un número entero positivo.
- Limpiar: borra los campos, restablece el mensaje inicial y devuelve el foco al campo del nombre.
- Cambiar saludo: permite alternar entre dos mensajes de presentación.

4. Controles utilizados

Control| Función
Window| Ventana principal de la aplicación.
StackPanel| Organiza los elementos verticalmente.
TextBlock| Muestra títulos, etiquetas y mensajes.
TextBox| Permite ingresar los datos.
Button| Ejecuta las acciones de la aplicación.

También se utilizaron propiedades como "Margin", "Spacing", "Text", "FontSize" y "x:Name" para organizar y personalizar la interfaz.

5. Programación orientada a eventos

La aplicación utiliza eventos "Click" para responder a las acciones del usuario.

- "Presentarme_Click": valida los datos y muestra la presentación.
- "Limpiar_Click": limpia los campos y restablece la aplicación.
- "CambiarSaludo_Click": alterna entre los dos saludos disponibles.

Para validar la edad se utiliza "int.TryParse()", mientras que "string.IsNullOrWhiteSpace()" permite comprobar que los campos de texto no estén vacíos.

6. Relación entre MainWindow.axaml y MainWindow.axaml.cs

El archivo "MainWindow.axaml" contiene la estructura visual de la aplicación, es decir, los controles, botones, etiquetas y campos de texto.

Por otra parte, "MainWindow.axaml.cs" contiene la lógica de programación que permite que esos controles funcionen.

Ambos archivos se relacionan mediante la propiedad "x:Name", que permite identificar y acceder a los controles desde C#, y mediante la propiedad "Click", que conecta los botones con sus respectivos métodos.

De esta manera, la interfaz gráfica y el código trabajan juntos para ofrecer una aplicación interactiva.

7. Evidencias de funcionamiento

Presentación personalizada

"Presentación personalizada" (screenshots/01-presentacion.png)

Validación de datos

"Validación de datos" (screenshots/02-validacion.png)

Cambio de saludo

"Saludo alternativo" (screenshots/03-saludo-alternativo.png)

Función limpiar

"Limpiar campos" (screenshots/04-limpiar.png)

8. Instrucciones para ejecutar el proyecto

Para ejecutar la aplicación se necesita tener instalado el SDK de .NET 8 o una versión compatible.

1. Descargar o clonar el repositorio.

2. Abrir una terminal dentro de la carpeta del proyecto.

3. Ejecutar el siguiente comando para restaurar las dependencias:
   
   "dotnet restore"

4. Compilar el proyecto:
   
   "dotnet build"

5. Ejecutar la aplicación:
   
   "dotnet run"

9. Conclusión

Con el desarrollo de este proyecto pude comprender cómo se construye una interfaz gráfica en Avalonia UI 11 y cómo se relaciona con la programación en C#.

También aprendí a utilizar eventos, controles visuales y validaciones para crear una aplicación que responde a las acciones del usuario.
