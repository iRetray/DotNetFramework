var valorNumerico = 100;
var estaCasado = true;
var nombrePersona = "Jaime Alberto";
var inicial = "J";
var precioProducto = 5000.34;

function cambiarContenido() {
  document.getElementById("etiquetaValor").innerHTML = valorNumerico;
  document.getElementById("etiquetaBooleano").innerHTML = estaCasado;
  document.getElementById("etiquetaPersona").innerHTML = nombrePersona;
  document.getElementById("etiquetaInicial").innerHTML = inicial;
  document.getElementById("etiquetaPrecio").innerHTML = precioProducto;
}

function sumarNumeros(valor1, valor2) {
  var resultado = 0;

  resultado = valor1 + valor2;

  return resultado;
}

function mostrarCalculo() {
  document.getElementById("resultadoSuma").innerHTML = sumarNumeros(4, 9);
}

function mostrarCalculo2() {
  document.getElementById("resultadoSuma2").innerHTML = sumarNumeros(
    "Clase NET",
    " Viernes"
  );
}

function calcularSumaDatos() {
  var n1 = 0;
  var n2 = 0;
  var resultado = 0;

  n1 = parseInt(prompt("Digite el primer valor"));
  n2 = parseInt(prompt("Digite el segundo valor"));

  resultado = sumarNumeros(n1, n2);

  alert(
    "El resultado de la suma de N1 = " +
      n1 +
      " y N2 = " +
      n2 +
      " es igual a = " +
      resultado
  );
}
