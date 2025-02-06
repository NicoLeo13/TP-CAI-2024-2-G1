# Sistema de Gestión Comercial - TP CAI G1

## Descripción

Sistema de gestión comercial desarrollado como trabajo práctico para CAI (Construcción de Aplicaciones Informáticas). El sistema permite la administración integral de una tienda, incluyendo gestión de productos, proveedores, ventas y usuarios.

## Características Principales

- Gestión de usuarios con diferentes roles (Administrador, Supervisor, Vendedor)
- Administración de productos
- Gestión de proveedores
- Sistema de ventas
- Carrito de compras
- Gestión de clientes
- Generación de reportes
- Sistema de autenticación

## Arquitectura

El proyecto está estructurado en 4 capas:

- **Presentación**: Interfaz de usuario (Windows Forms)
- **Negocio**: Lógica de negocio
- **Datos**: Modelos y entidades
- **Persistencia**: Acceso a datos

## Tecnologías Utilizadas

- .NET Framework 4.7.2
- Windows Forms
- EPPlus (manejo de Excel)
- Guna.UI2 (controles de interfaz)
- FontAwesome.Sharp (iconos)

## Requisitos del Sistema

- Windows 7 o superior
- .NET Framework 4.7.2
- Visual Studio 2019 o superior

## Instalación

1. Clonar el repositorio
2. Abrir la solución en Visual Studio
3. Restaurar los paquetes NuGet
4. Compilar la solución
5. Ejecutar el proyecto Presentacion

## Integración con API

El sistema se comunica con una API REST para realizar las operaciones CRUD (Create, Read, Update, Delete). A continuación se detallan los endpoints principales:

### Productos

- GET /api/productos - Obtener todos los productos
- GET /api/productos/{id} - Obtener un producto específico
- POST /api/productos - Crear nuevo producto
- PUT /api/productos/{id} - Actualizar producto existente
- DELETE /api/productos/{id} - Eliminar producto

### Proveedores

- GET /api/proveedores - Obtener todos los proveedores
- GET /api/proveedores/{id} - Obtener un proveedor específico
- POST /api/proveedores - Crear nuevo proveedor
- PUT /api/proveedores/{id} - Actualizar proveedor existente
- DELETE /api/proveedores/{id} - Eliminar proveedor

### Ventas

- GET /api/ventas - Obtener todas las ventas
- GET /api/ventas/{id} - Obtener una venta específica
- POST /api/ventas - Registrar nueva venta
- PUT /api/ventas/{id} - Actualizar venta existente

### Autenticación

- POST /api/auth/login - Iniciar sesión
- POST /api/auth/logout - Cerrar sesión
- POST /api/auth/reset-password - Restablecer contraseña

### Formato de Datos

Todas las peticiones y respuestas utilizan el formato JSON. Ejemplo de petición POST:

```json
{
  "nombre": "Producto Ejemplo",
  "precio": 999.99,
  "stock": 100,
  "categoria": "Electrónica",
  "proveedor_id": 1
}
```

### Manejo de Errores

La API retorna códigos de estado HTTP estándar:

- 200: Operación exitosa
- 201: Recurso creado exitosamente
- 400: Error en la petición
- 401: No autorizado
- 404: Recurso no encontrado
- 500: Error interno del servidor
