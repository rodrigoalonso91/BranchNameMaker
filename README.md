# RamaMaker
Su funcion es generar el formato que usamos para las _ramas_ y el _primer commit_ de desarrollo.
Necesario? no... Util? eemmm, tipeas menos 🤷‍♂️.

## Interfaz
![image](https://user-images.githubusercontent.com/77740217/176239096-a37c92b6-c3b6-4d85-b446-c11ba1c8974d.png)
### 1. Clipboar View
Contenido del clipboard al momento de ejecutar la applicación.
Para volver a importar el contenido del clipboar solo es necesario hacer doble clip el cuerpo del form:
![importclipboard](https://user-images.githubusercontent.com/77740217/176240041-c1f74084-52c1-42bb-9aea-cb0508d883e0.gif)

### 2. BranchFormat
Muestra el contenido del clipboard en formato Rama de desarrollo.

### 3. CommitFormat
Muestra el contenido del clipboard en formato de primer commit (Ya que usamos squash commit para el merge de los PR).

### 4. BranchFolder
Aqui se ingresa el folder de la rama que sera el prefijo en BranchFormat (es necesario poner la barra!).

### 5. Button BranchFormat
Copia en el portapapeles el contenido que se muestra en BranchFormat

### 6. Button CommitFormat
Copia en el portapapeles el contenido que se muestra en CommitFormat.

### 7. Button Lock
Cuando el candado esta abierto hacer un doble click en el form hace que se vuelva a importar el contenido del clipboard, esto no ocurre si el candado esta cerrado.
