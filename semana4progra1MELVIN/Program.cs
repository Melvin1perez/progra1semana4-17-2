
using semana4progra1MELVIN.entidades;
using semana4progra1MELVIN.negocio;

entidadcontador Texto = new entidadcontador ();
negociocontador negociocontador = new negociocontador();



  Console.WriteLine("Ingrese un texto por favor:");
  string textoIngresado = Console.ReadLine();

  entidadcontador entidad = new entidadcontador();
  entidad.Texto = textoIngresado;

  negociocontador negocio = new negociocontador();
  int cantidadLetras = negocio.ContarLetras(entidad);

  Console.WriteLine ("La cantidad de letras ingresadas es: " + cantidadLetras);