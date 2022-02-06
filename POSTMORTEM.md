# Post Mortem

Bueno, es mi primer juego en Unity, yo normalmente programo en C++ o Java; no me pareció difícil, fue una experiencia interesante, y divertida.

Me baje Unity, y un libro bastante interesante, y con ello me puse a hacerlo. 

Recomiendo jugar la version compilada a pantalla completa, para disfrutar la experiencia de juego correcta, se puede bajar en Releases, o compilar para Windows desde Unity.

## Desarrollo

Primero leí bastante un libro introductorio a Unity 2D, ya que era una tecnología nueva para mi, mi especialidad es C++ y Java diseñando motores y portando y optimizando código existente, no tanto usar motores "enlatados", aunque tuve contacto con Godot y engines "in-house" en Gameloft. 

En cuanto al desarrollo en si, lo primero fue armar la escena, y lograr que el pájaro volara, experimente con distintos valores hasta lograr un vuelo natural.

Luego agregue un generador de tuberías, que serian el "enemigo" de nuestro héroe.

Las tuberías cuentan con una zona que se considera "vuelo exitoso" que cuenta para sumar el puntaje, fuera de esa zona (aunque el pájaro este invencible por la estrella) no se considera un punto exitoso, me parece que es justo que sea así. 

La jugabilidad es lo mas importante, así que estuve bastante tiempo enfocado en ajustar los parámetros de velocidades y demás reacciones, para lograr que el juego sea difícil sin ser imposible. 

Acto seguido, agregue un generador de estrellas. La estrella en estilo Mario, viene volando y hay que atraparla, y nos da inmunidad total por unos segundos, indicado al jugador con un cambio de música y color (tal cual sucede en la consola Nintendo).

Además, para terminar de pulir la experiencia del jugador, decidí agregar efectos de sonido, y crear una pantalla titulo y algunos mensajes informativos. 

Quedo un juego 100% completo, además probé compilarlo para plataforma Windows sin ningún tipo de problemas, e hice el lanzamiento del binario win64, que se puede bajar de "Releases". Podría hacer un instalador también mediante NSIS o similar, para un usuario final.

Luego coloque un botón para encender o apagar el sonido en la esquina inferior izquierda, y un botón para salir en la esquina superior derecha, esto pensando en la versión "stand-alone" ya compilada de escritorio. Es importante permitirle al jugador configurar a su gusto el juego, apagando sonidos o saliendo rápido si así lo desea.

Para finalizar, agregue un truco, un cheat "secreto", creo que todo buen juego debe tener secretos, tocando la letra "G" entra en "modo Dios" invencible.

## Código 

El código es sencillo de entender, y esta comentado en ingles. Siempre trabajo en ingles, acostumbrado a trabajar con equipos internacionales, dado que de esa manera se puede colaborar con colegas sin tener problemas idiomáticos, es el lenguaje universal.

Mantuve las interacciones entre objetos, y el código lo mas sencillo posible, y comentado, no hay necesidad de complicar excesivamente el código, especialmente trabajando en equipo y pensando en mantenimiento futuro del mismo.

## Futuro

Me gustaría en el futuro agregar algunas cosas, como tabla de puntajes, y estrellas con diferentes efectos como ralentizar el tiempo, o acelerar el vuelo.

En cuanto a la parte tecnológica, quizá reescribir en C++ el juego, podría hacerlo correr incluso en hardware de muchos menos requerimientos que Unity; a mi me gusta hacer el código lo mas eficiente posible, creo que un juego tan sencillo se podría hacer mucho mas pequeño usando C++ y Allegro o SDL. Godot también es buena opción y me gusta la licencia libre que tiene.

La gran ventaja que le veo a Unity (o Godot) es no tener que inicializar el hardware, o manipular la RAM de manera directa como C++, eso me hizo acelerar enormemente el desarrollo, y evita errores. Me gusto mucho, yo soy "old school", vengo haciendo videojuegos desde la época del C64 con BASIC y ASM, pero me gusta conocer y adaptarme a nuevas tecnologías.

Puedo hacer juegos en muchas tecnologías diferentes, y elegir la tecnología adecuada de acuerdo al juego, target de hardware, publico, etc es muy importante. Mi especialidad en Gameloft era portar juegos a celulares de gama baja, donde el hardware estaba muy limitado (usando Java ME).

También puedo codificar gráficos en lenguaje de bajo nivel como Assembler o C, para MS-DOS, Linux, etc

## Los libros que consulte 

Como es mi primer contacto con Unity, tuve que recurrir a leer varios libros para guiarme, saltando a las partes que me interesaban para este desarrollo en particular; adaptarme a nuevas tecnologias es mi fuerte.

Franz Lanzinger - 2D Game Development with Unity - CRC Press (2021)

David Baron - Game Development Patterns with Unity  - Packt Publishing (2021)

Joseph Hocking - Unity in Action_ Multiplatform game development in C# - Manning Publications (2022)

Lanzinger, Franz - 3d Game Development With Unity - CRC Pr I Llc (2022)

Victor G Brusca - Advanced Unity Game Development_ Build Professional Games with Unity, C#, and Visual Studio - Apress (2022)