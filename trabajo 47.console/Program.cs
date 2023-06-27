int contador = 0;
int suma = 0;
int suma_par = 0;
int num_mayor = 0;
do
{
    Console.WriteLine($"escribe el {contador + 1}º numero a sumar");

    var nro = int.Parse(Console.ReadLine());

    contador++;
    suma += nro;
    if (espar(nro))
    {
        suma_par += nro;
    }

    if (num_mayor < nro)
    {
        num_mayor = nro;
    }

}
while (contador < 10);

bool espar(int nro)
{
    return nro % 2 == 0;
}

Console.WriteLine($"la suma es: {suma}");
Console.WriteLine($"la suma de los pares es:{suma_par}");
Console.WriteLine($"El mayor numero ingresado fue: {num_mayor}");