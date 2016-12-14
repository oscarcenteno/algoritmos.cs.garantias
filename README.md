# algoritmos.cs.garantias

[![Build status](https://ci.appveyor.com/api/projects/status/lp5cv5mnb0pk6ek0?svg=true)](https://ci.appveyor.com/project/oscarcenteno/algoritmos-cs-garantias)

# Descripcion
Este algoritmo genera una estructura de datos que contiene propiedades numéricas y de texto. 
En sus carpetas aplicamos los refactorings aprendidos en www.SoftwareMantenible.com, desde una programación procedimental hasta lograr un algoritmo orientado a objetos que cumple los principios SOLID.

# Unit Tests
Note la organización de las pruebas unitarias, donde no hay duplicación gracias a la organización de los escenarios. Además, note la forma de cada prueba unitaria donde siempre se deja claro elResultadoEsperado, la inicialización del escenario, elResultadoObtenido y la comparación. Esto permite que todas las pruebas se lean de manera sencilla sin distraernos en los detalles.

Ejecute build-unit-tests.bat para compilar ejecutar todas las pruebas unitarias.

# Specs
La especificación por ejemplos la planteamos como tablas de [Concordion](http://concordion.org/tutorial/csharp/html/) para poder tener una documentación viviente (living documentation). Ejecute build-specs.bat para compilar, ejecutar y mostrar la documentación ejecutable.
