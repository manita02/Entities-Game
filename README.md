


<h1 align="center">👺👾Entities Game👽👹</h1>
<section align="center">
  <img src="https://meups.com.br/wp-content/uploads/2023/08/Industria-dos-Games-900x503.jpg" alt="entities_game">
  
   <img src="https://img.shields.io/badge/ESTADO-EN DESARROLLO-green" alt="Estado del Proyecto">
</section>


# Índice
- [Sobre Entities Game :shipit:](#sobre-entities-game-shipit)

- [Programas necesarios :memo:](#white_check_mark-programas-necesariosclipboard)

- [Descargar proyecto :inbox_tray:](#white_check_mark-descargar-proyectoinbox_tray)
   

- [Abrir Proyecto :open_file_folder:](#white_check_mark-abrir-proyectoopen_file_folder)
    
- [Ejecutar el proyecto :rocket:](#white_check_mark-ejecutar-proyectorocket)

- [Funcionalidades :scroll:](#funcionalidades-scroll)

- [Tecnologías utilizadas :hammer:](#tecnologías-utilizadas-hammer)

- [Autor :black_nib:](#autor-black_nib)


## Sobre Entities Game :shipit:

<p align="justify">
Es una aplicación realizada según el patrón MVC (Modelo, Vista, Controlador) que permite el ABM (Alta, Baja, Modificación), de entidades, items y comidas. A su vez posee algunas funcionalidades de juego por medio de un mapa dividido en casilleros hexagonales (terrenos) en donde tendremos los objetos mencionados anteriormente. Las entidades pueden moverse entre casilleros, atacar otras entidades e interactuar con comidas o items. Una entidad puede ser acuática, terrestre, aérea o cualquier combinación de ellas (acuático-terrestre, aéreo-terrestre, aéreo-acuático-terrestre, etc), esto define el terreno por el cual puede moverse y su posición sobre el mapa.
</p>



### :white_check_mark: `Programas necesarios`:clipboard:
- Descargar e Instalar :arrow_down_small: 
  - Aprende a instalar Visual Studio Community :point_right: [10-minute tutorial ⏱️](https://www.youtube.com/watch?v=0Bylp5rPnWg)! 
  - <a href="https://visualstudio.microsoft.com/es/" target="_blank"> 
         Visual Studio Community :point_right: Desarrollo de escritorio con .NET (C#)
    </a>    
   

### :white_check_mark: `Descargar proyecto`:inbox_tray:
- [Download](https://github.com/manita02/probandoAnimales/archive/refs/heads/main.zip):anger: 



### :white_check_mark: `Abrir Proyecto`:open_file_folder:
- Descomprimir el archivo .ZIP descargado anteriormente.
- Abrir la carpeta descomprimida y buscar el archivo .SLN :point_right: Abrirlo con Visual Studio Community

  
### :white_check_mark: `Ejecutar Proyecto`:rocket:
- Hacer click al ícono de color verde▶️ para compilar el proyecto
  <section align="center">
      <img src="https://learn.microsoft.com/es-es/visualstudio/get-started/csharp/media/vs-2022/start-button.png?view=vs-2022" alt="runProject">
  </section>


## Funcionalidades :scroll:
### :ballot_box_with_check: `Mapa`🗺️
- El mapa se genera de forma aleatoria a través de la unión de 18 hexágonos. 
- Cada hexágono representa un terreno, el cual puede ser de tipo Acuático🌊 o Terrestre🌎. 
- En cada terreno habrá entidades (criaturas que podrán realizar diferentes interacciones), items (pociones que pueden ser negativas o positivas) y comidas.

### :ballot_box_with_check: `¿Qúe puede hacer una entidad?`🐉
- Una entidad puede moverse, atacar y alimentarse mientras su energía se lo permita. Todas estas acciones tienen un costo determinado de energía➖⚡.

<section align="center">
      <img src="https://www.escapistmagazine.com/wp-content/uploads/2022/08/major-games-list-august-december-2022.jpg?resize=800%2C400" alt="entities">
</section>

### :ballot_box_with_check: `Mecánica de Movimiento`👣
- La posibilidad de moverse hacia un terreno depende de los ambientes por los cuales una entidad pueda moverse (agua, tierra, aire, o cualquier combinación de ellas🌏).
- Una entidad solo se podra mover entre sus terrenos limitrofes respecto al terreno actual donde se encuentra. 

### :ballot_box_with_check: `La alimentación`🍽️
- Cuando una entidad ingiera una comida, esta recuperará una cierta cantidad de energía➕⚡.
- Solo podrá comer aquellos alimentos que su dieta le permita (vegetales🥬, carne🍖, energía eléctrica☢️💻)


### :ballot_box_with_check: `Uso de items (pociones)`⚗️
- Los items afectaran a la vida, energia, puntos de ataque y puntos de defensa, de forma positiva✔️ o negativa❌. 
- Una entidad podra usar un item si es que el reino de la entidad es compatible con el reino del item. 
- Los items podran ser utilizados  dependiendo del reino al que pertenzca la entidad seleccionada🐲. 

### :ballot_box_with_check: `Mecánica de Ataque`🤜💣💥
- Una entidad con rango 0️⃣ solo puede atacar entidades que se encuentren en el mismo terreno.
- Una entidad con rango 1️⃣ puede atacar a entidades en terrenos limítrofes y en su propio terreno actual. 
- Atacar tiene un costo determinado de puntos de energía➖⚡. 
- La entidad atacante debe arrojar un dado de 6 caras🎲, el resultado se sumará a sus puntos de ataque🥊 y se comparará con la defensa de la entidad atacada que también arrojará un dado de 6 caras🎲 que sumará a sus puntos de defensa🛡️.
- La entidad atacada recibirá una cantidad de daño igual a la diferencia entre su defensa y el ataque de la entidad atacante.
- Si la defensa🛡️ de la entidad atacada supera los puntos de ataque de la entidad atacante, la diferencia entre estos valores se resta a la vida de la entidad atacante🥊. 

<section align="center">
      <img src="https://e1.pxfuel.com/desktop-wallpaper/358/186/desktop-wallpaper-shirai-ryu-on-fire-shirai-ryu.jpg" alt="attack">
</section>

  
## Tecnologías utilizadas :hammer:
<section align="center">
<a href="https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/" target="_blank"> <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Logo_C_sharp.svg/1200px-Logo_C_sharp.svg.png" alt="c#" width="70" height="80"/> </a> ❕
<a href="https://dotnet.microsoft.com/es-es/learn/dotnet/what-is-dotnet" target="_blank"> <img class="img" src="https://seeklogo.com/images/1/net-logo-681E247422-seeklogo.com.png" alt=".net" width="80" height="80"/> </a> ❗
<a href="https://visualstudio.microsoft.com/es/#vs-section" target="_blank"> <img class="img" src="https://cdn-icons-png.flaticon.com/512/906/906324.png" alt="vs" width="80" height="80"/> </a>
</section>



## Autor :black_nib:
| [<img src="https://i.pinimg.com/564x/f7/20/31/f72031b55dcf72ad48889c7a9b2abf80.jpg" width=115><br><sub>Ana Lucia Juarez</sub>](https://github.com/manita02) | 
| :---: |
