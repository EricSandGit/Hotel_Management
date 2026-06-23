# Hotel_Management - Sistema de Gestión Hotelera

Este es un proyecto de escritorio desarrollado en **C# Windows Forms** y **.NET 10.0**, diseñado para digitalizar y simplificar el flujo de trabajo de recepción en un hotel. Permite la administración de clientes, habitaciones, usuarios del sistema, reservas, estadías activas, consumos adicionales (gastos extras) y la facturación consolidada.

---

## 🚀 Características Principales

*   **Gestión de Huéspedes e Inventario:** Control total sobre el catálogo de clientes y de habitaciones (configuración de camas individuales/matrimoniales y precio base).
*   **Control del Ciclo de Reservas:** Creación, edición, cancelación y búsqueda de reservas.
*   **Módulo de Estadías (Check-In y Check-Out):** Flujo en tiempo real para ingresar a los huéspedes, registrar sus consumos en el hotel y darles la salida.
*   **Consolidación de Cuentas:** Facturación automatizada que suma el costo total de noches de hospedaje y añade los gastos extras acumulados.
*   **Persistencia Local Rápida:** Conexión directa a base de datos **SQLite** (`HotelDB.db`).

---

## 🏗️ Arquitectura del Proyecto (N-Capas)

El código sigue una estructura de capas para mejorar la mantenibilidad y modularidad:

1.  **Capa de Presentación (`Forms/`):** 
    *   Formularios Windows Forms interactivos organizados en subcarpetas temáticas (`fClientes`, `fEstadias`, `fReservas`, `fCuenta`, etc.).
2.  **Capa de Lógica / Negocio (`Controladores/`):** 
    *   Clases controladoras con el prefijo `n` (ej. `nReserva`, `nEstadia`, `nCuenta`) que se encargan de validar que se cumplan las reglas lógicas (evitar overbooking, validar capacidad, restringir fechas, etc.) antes de persistir cambios.
3.  **Capa de Modelos (`Modelos/`):** 
    *   Clases POCO que modelan los registros de la base de datos como entidades estructuradas (ej. `Cliente`, `Reserva`, `Estadia`, `GastoExtra`).
4.  **Capa de Persistencia / Acceso a Datos (`Persistencia/`):** 
    *   Clases con prefijo `p` que implementan la interfaz `IRepositorio` y encapsulan las consultas SQL usando `Microsoft.Data.Sqlite`.

---

## 🔄 Resumen del Flujo Lógico Central

```
   [ Reserva Creada ] (Pendiente)
           │
           ▼  (Check-In el día previsto)
   [ Estadía Iniciada ] (Activa) ───► [ Registro de Gastos Extras ] (Minibar, etc.)
           │
           ▼  (Check-Out el día previsto)
   [ Estadía Finalizada ] ───► [ Generación automática de Cuenta ] (Pendiente de pago)
                                                 │
                                                 ▼ (Huésped abona)
                                         [ Cuenta Pagada ]
```

*   **Validación de Reservas:** El sistema valida automáticamente que no haya traslapes de fechas para la misma habitación y que el número de huéspedes no exceda las camas disponibles.
*   **Validación de Estadías:** Los Check-Ins y Check-Outs están restringidos por fecha. El sistema impide realizarlos si no coinciden exactamente con los días definidos en la reserva.
*   **Control de Cuentas:** Calcula automáticamente el subtotal de noches (`Noches * PrecioPorNoche`) y añade los gastos extras de la estadía activa para obtener el monto final.

---

## 🛠️ Requisitos e Instalación

### Requisitos Previos
*   [.NET SDK 10.0](https://dotnet.microsoft.com/download) o superior.
*   Visual Studio 2022 o VS Code con el kit de desarrollo de C#.

### Ejecución
1.  Clona o abre el directorio del proyecto.
2.  Abre la terminal en la carpeta raíz `WinFormsApp1` y ejecuta:
    ```bash
    dotnet run
    ```
3.  El motor SQLite creará o leerá automáticamente el archivo `HotelDB.db` local.

---
*Este README fue creado con ❤️ por **Antigravity**, tu asistente de programación inteligente.*