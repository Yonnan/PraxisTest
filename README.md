# PraxisTest
ASP.NET Core RESTful API than retrieve the details of the best stories from the Hacker News API.

HERRAMIENTAS
- Cree este proyecto haciendo uso del IDE Visual Studio 2022.
- Utilice el lenguaje de programación C#.
- Hace empleo del software de código abierto Swagger, para servicios RESTful.
- Empleo la librería "Newtonsoft.Json"

CONTENIDO
No contaba con experiencia previa diseñando cosas como lo que se pide en la prueba técnica, así que todo, fuera del conocimiento que tenía previamente con el lenguaje de programación C# fue conocimiento nuevo adquirido para mí.

- Haciendo uso del IDE Visual Studio, no brinda herramientas como una estructura muy básica de una API, lo cual, si necesitas crear una con una complejidad notablemente superior a la indicada en la prueba, casi parece lo mínimo que se esperaría. Algo así como esperar que al crear un archivo de texto nuevo con una determinada extensión nos cargue la estructura base de todo archivo de ese tipo, como un HTML o un PHP.

- Partiendo de esa base cree tres clases distintas: STORY, OUTPUT y BESTSTORYS las cuales utilice para la organización de los datos obtenidos desde la API Hackernews.

- La clase "BestStorys", nos ayuda a obtener y almacenar los dato obtenidos de la primera URL, lo cual es un arreglo con IDs de las Stories.

- La clase "Story", nos ayuda a almacenar los datos de cada una de las Stories, buscándolas haciendo uso de la segunda URL y del listado de IDs previo, mientras realizamos algunos cálculos con los datos de las mismas.

- La clase "Output" Nos ayuda a organizar de la manera en que queremos mostrar al final la información, pudiendo así omitir y agregar campos a voluntad.

- Cree un controlador llamado "StoryController", en el cual se encuentra la mayoría del código empleado para resolver la prueba.

- Por último en el proceso de creación, el software Swagger hace uso de los controladores para mostrar en pantalla los métodos y resultados de manera gráfica, cambio en el comportamiento de estos afecta la interfaz mostrada.

A futuro, acciones que yo por mi parte realizaría, sería separar el código para que sea más fácil reutilizarlo y esté más ordenado, así como agregar diferentes tipos de consultas si es que se busca obtener más información de la API. 
Ya que de momento el código es bastante lineal.

COMENTARIO FINAL
Una antigua maestra de programación solía repetir el dicho "No reinventes la rueda", así como me aconsejo en mis inicios que no me esforzara por memorizar todas las líneas de código, pues un código tiene una gran cantidad de acciones (líneas / códigos) diferentes, y existe una gran cantidad de lenguajes de programación; sino más bien, me enfocara en desarrollar mi lógica de programación, y así, sabría ante futuros problemas que es lo que tengo que hacer o que es lo que necesito, solo quedaría, buscar un poco cuáles son las herramientas que nos brinda el presente lenguaje de programación o software para realizarlo.
