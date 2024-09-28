# DSOO_TP1_Com1A_Grupo2

Este proyecto es una aplicación de consola para la gestión de un club deportivo. Permite agregar, eliminar y listar clientes, así como inscribirlos en actividades y listar las actividades de un cliente.

## Estructura del Proyecto

DSOO_TP1_Com1A_Grupo2/
├── Actividad.cs
├── Actividades.cs
├── Cliente.cs
├── Clientes.cs
├── ClubDeportivo.cs
├── DSOO_TP1_Com1A_Grupo2.csproj
├── bin/
│   └── Debug/
├── obj/
│   └── Debug/
├── .gitignore
├── DSOO_TP1_Com1A_Grupo2.sln
└── README.md

### Archivos Principales

- **ClubDeportivo.cs**: Contiene la clase principal [`ClubDeportivo`](command:_github.copilot.openSymbolFromReferences?%5B%22ClubDeportivo%22%2C%5B%7B%22uri%22%3A%7B%22%24mid%22%3A1%2C%22fsPath%22%3A%22c%3A%5C%5CUsers%5C%5CIllei%5C%5Csource%5C%5Crepos%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CClubDeportivo.cs%22%2C%22_sep%22%3A1%2C%22external%22%3A%22file%3A%2F%2F%2Fc%253A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22path%22%3A%22%2FC%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22scheme%22%3A%22file%22%7D%2C%22pos%22%3A%7B%22line%22%3A2%2C%22character%22%3A19%7D%7D%5D%5D "Go to definition") que maneja la lógica del menú y las operaciones principales.
- **Cliente.cs**: Define la clase [`Cliente`](command:_github.copilot.openSymbolFromReferences?%5B%22Cliente%22%2C%5B%7B%22uri%22%3A%7B%22%24mid%22%3A1%2C%22fsPath%22%3A%22c%3A%5C%5CUsers%5C%5CIllei%5C%5Csource%5C%5Crepos%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CCliente.cs%22%2C%22_sep%22%3A1%2C%22external%22%3A%22file%3A%2F%2F%2Fc%253A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FCliente.cs%22%2C%22path%22%3A%22%2Fc%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FCliente.cs%22%2C%22scheme%22%3A%22file%22%7D%2C%22pos%22%3A%7B%22line%22%3A8%2C%22character%22%3A19%7D%7D%2C%7B%22uri%22%3A%7B%22%24mid%22%3A1%2C%22fsPath%22%3A%22c%3A%5C%5CUsers%5C%5CIllei%5C%5Csource%5C%5Crepos%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CClientes.cs%22%2C%22_sep%22%3A1%2C%22external%22%3A%22file%3A%2F%2F%2Fc%253A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClientes.cs%22%2C%22path%22%3A%22%2Fc%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClientes.cs%22%2C%22scheme%22%3A%22file%22%7D%2C%22pos%22%3A%7B%22line%22%3A11%2C%22character%22%3A21%7D%7D%2C%7B%22uri%22%3A%7B%22%24mid%22%3A1%2C%22fsPath%22%3A%22c%3A%5C%5CUsers%5C%5CIllei%5C%5Csource%5C%5Crepos%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CClubDeportivo.cs%22%2C%22_sep%22%3A1%2C%22external%22%3A%22file%3A%2F%2F%2Fc%253A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22path%22%3A%22%2FC%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22scheme%22%3A%22file%22%7D%2C%22pos%22%3A%7B%22line%22%3A117%2C%22character%22%3A12%7D%7D%5D%5D "Go to definition") con sus propiedades y métodos.
- **Clientes.cs**: Maneja la colección de clientes y las operaciones relacionadas.
- **Actividad.cs**: Define la clase [`Actividad`](command:_github.copilot.openSymbolFromReferences?%5B%22Actividad%22%2C%5B%7B%22uri%22%3A%7B%22%24mid%22%3A1%2C%22fsPath%22%3A%22c%3A%5C%5CUsers%5C%5CIllei%5C%5Csource%5C%5Crepos%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CActividad.cs%22%2C%22_sep%22%3A1%2C%22external%22%3A%22file%3A%2F%2F%2Fc%253A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FActividad.cs%22%2C%22path%22%3A%22%2Fc%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FActividad.cs%22%2C%22scheme%22%3A%22file%22%7D%2C%22pos%22%3A%7B%22line%22%3A8%2C%22character%22%3A19%7D%7D%2C%7B%22uri%22%3A%7B%22%24mid%22%3A1%2C%22fsPath%22%3A%22c%3A%5C%5CUsers%5C%5CIllei%5C%5Csource%5C%5Crepos%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CActividades.cs%22%2C%22_sep%22%3A1%2C%22external%22%3A%22file%3A%2F%2F%2Fc%253A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FActividades.cs%22%2C%22path%22%3A%22%2Fc%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FActividades.cs%22%2C%22scheme%22%3A%22file%22%7D%2C%22pos%22%3A%7B%22line%22%3A10%2C%22character%22%3A20%7D%7D%2C%7B%22uri%22%3A%7B%22%24mid%22%3A1%2C%22fsPath%22%3A%22c%3A%5C%5CUsers%5C%5CIllei%5C%5Csource%5C%5Crepos%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CCliente.cs%22%2C%22_sep%22%3A1%2C%22external%22%3A%22file%3A%2F%2F%2Fc%253A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FCliente.cs%22%2C%22path%22%3A%22%2Fc%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FCliente.cs%22%2C%22scheme%22%3A%22file%22%7D%2C%22pos%22%3A%7B%22line%22%3A16%2C%22character%22%3A20%7D%7D%2C%7B%22uri%22%3A%7B%22%24mid%22%3A1%2C%22fsPath%22%3A%22c%3A%5C%5CUsers%5C%5CIllei%5C%5Csource%5C%5Crepos%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CDSOO_TP1_Com1A_Grupo2%5C%5CClubDeportivo.cs%22%2C%22_sep%22%3A1%2C%22external%22%3A%22file%3A%2F%2F%2Fc%253A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22path%22%3A%22%2FC%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22scheme%22%3A%22file%22%7D%2C%22pos%22%3A%7B%22line%22%3A151%2C%22character%22%3A16%7D%7D%5D%5D "Go to definition") con sus propiedades y métodos.
- **Actividades.cs**: Maneja la colección de actividades y las operaciones relacionadas.

## Funcionalidades

### Menú Principal

El menú principal ofrece las siguientes opciones:

1. **Agregar Cliente**: Permite agregar un nuevo cliente al club.
2. **Eliminar Cliente**: Permite eliminar un cliente existente.
3. **Listar Clientes**: Muestra una lista de todos los clientes.
4. **Inscribir Cliente a una Actividad**: Inscribe a un cliente en una actividad.
5. **Listar Actividades de un Cliente**: Muestra las actividades en las que está inscrito un cliente.
6. **Salir**: Termina la aplicación.

### Métodos Principales

- **[`MostrarMenu`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2FC%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22MostrarMenu%22%5D "c:\Users\Illei\source\repos\DSOO_TP1_Com1A_Grupo2\DSOO_TP1_Com1A_Grupo2\ClubDeportivo.cs")**: Muestra el menú principal.
- **[`LeerOpcion`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2FC%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22LeerOpcion%22%5D "c:\Users\Illei\source\repos\DSOO_TP1_Com1A_Grupo2\DSOO_TP1_Com1A_Grupo2\ClubDeportivo.cs")**: Lee la opción seleccionada por el usuario.
- **[`EjecutarOpcion`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2FC%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22EjecutarOpcion%22%5D "c:\Users\Illei\source\repos\DSOO_TP1_Com1A_Grupo2\DSOO_TP1_Com1A_Grupo2\ClubDeportivo.cs")**: Ejecuta la opción seleccionada.
- **[`AgregarCliente`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2FC%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22AgregarCliente%22%5D "c:\Users\Illei\source\repos\DSOO_TP1_Com1A_Grupo2\DSOO_TP1_Com1A_Grupo2\ClubDeportivo.cs")**: Agrega un nuevo cliente.
- **[`EliminarCliente`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2FC%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22EliminarCliente%22%5D "c:\Users\Illei\source\repos\DSOO_TP1_Com1A_Grupo2\DSOO_TP1_Com1A_Grupo2\ClubDeportivo.cs")**: Elimina un cliente existente.
- **[`ListarClientes`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2FC%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22ListarClientes%22%5D "c:\Users\Illei\source\repos\DSOO_TP1_Com1A_Grupo2\DSOO_TP1_Com1A_Grupo2\ClubDeportivo.cs")**: Lista todos los clientes.
- **[`InscribirClienteActividad`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2FC%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22InscribirClienteActividad%22%5D "c:\Users\Illei\source\repos\DSOO_TP1_Com1A_Grupo2\DSOO_TP1_Com1A_Grupo2\ClubDeportivo.cs")**: Inscribe a un cliente en una actividad.
- **[`ListarActividadesCliente`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2FC%3A%2FUsers%2FIllei%2Fsource%2Frepos%2FDSOO_TP1_Com1A_Grupo2%2FDSOO_TP1_Com1A_Grupo2%2FClubDeportivo.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22ListarActividadesCliente%22%5D "c:\Users\Illei\source\repos\DSOO_TP1_Com1A_Grupo2\DSOO_TP1_Com1A_Grupo2\ClubDeportivo.cs")**: Lista las actividades de un cliente.

## Cómo Ejecutar

Para ejecutar la aplicación, sigue estos pasos:

1. Clona el repositorio:
    ```sh
    git clone <URL_DEL_REPOSITORIO>
    ```

2. Navega al directorio del proyecto:
    ```sh
    cd DSOO_TP1_Com1A_Grupo2
    ```

3. Compila el proyecto:
    ```sh
    dotnet build
    ```

4. Ejecuta la aplicación:
    ```sh
    dotnet run --project DSOO_TP1_Com1A_Grupo2
    ```

## Requisitos

- [.NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) o superior.

## Contribuciones

Las contribuciones son bienvenidas. Por favor, sigue los siguientes pasos:

1. Haz un fork del repositorio.
2. Crea una nueva rama (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios y haz commit (`git commit -am 'Agrega nueva funcionalidad'`).
4. Haz push a la rama (`git push origin feature/nueva-funcionalidad`).
5. Abre un Pull Request.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.