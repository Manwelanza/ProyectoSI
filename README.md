#IA enemy simpe shooter 2D

##Componentes del grupo

* Manuel Alejandro Rodríguez Santana
* José Carlos Rodríguez Cortés

##Información de los controles

En caso de emplear teclado
* **W**         -> Desplazar personaje hacia arriba
* **A**         -> Desplazar personaje hacia la izquierda
* **S**         -> Desplazar personaje hacia abajo
* **D**         -> Desplazar personaje hacie la derecha
* **Arriba**    -> Disparar hacia arriba
* **Abajo**     -> Disparar hacia abajo
* **Izquierda** -> Disparar hacia la izquierda
* **Derecha**   -> Disparar hacia la derecha
* **P**         -> Pausar el juego
* **R**         -> Reiniciar el juego

En caso de emplear controlador XBox
* **Stick Izquierdo** -> Se empleará para desplazar al personaje
* **Stick Derecho**   -> Se empleará para disparar saliendo el proyectil en la dirección en la que se mueva el Stick Derecho
* **Start**           -> Pausar el juego
* **Back**            -> Reiniciar el juego

##Tipos de enemigos
Nos encontraremos con tres tipos de enemigos:
* **Enemigos normales** (color rojo): Son los enemigos más básicos que solamente irán a por el jugador esquivando obstáculos y disparandole al jugador cuando lo tengan "a tiro".
* **Enemigo SUPP** (color amarillo): Es un tipo de enemigo especial que tiene más rango que los enemigos normales y se centrará en disparar constantemente al jugador a una distancia prudencial para así cubrir las salidas de las coberturas.
* **Enemigo francotirador o Snipper** (color violeta): Este enemigo tiene un rango absoluto con lo que puede disparar desde su base sin tener que moverse, además, este enemigo posee un tipo especial de munición (de color verde), que, al contrario de la munición normal, atraviesa paredes. El Snipper cumple la función de evitar que el jugador no se "acomode" en una cobertura.

##Objetivo del juego
Conseguir acertar con un disparo 10 veces a los enemigos evitando que estos nos disparen 10 veces a nosotros.