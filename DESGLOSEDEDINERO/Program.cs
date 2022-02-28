//BILLETES
int Q100, Q50, Q20, Q10, Q5, Q1, cantidad;
double cantidad1;
decimal cambio, cambio1=7.65m;
Q100 = 0; Q50 = 0; Q20 = 0; Q10 = 0;  Q5 = 0;   Q1 = 0;  
Console.WriteLine("Hola! Ingrese la cantidad en dolares:");
cantidad=int.Parse(Console.ReadLine());
cambio = Convert.ToDecimal(cantidad);
cambio1 = cambio1* cantidad;
Console.WriteLine("La cantidad en Quetzales es: " + cambio1);
cantidad1 = Convert.ToDouble(cambio1);
if (cantidad1 >= 100)
{
    Q100 = ((int)cantidad1 / 100);
    cantidad1 = cantidad1 - (Q100 * 100);
}
if (cantidad1 >= 50)
{
    Q50 = ((int)cantidad1 / 50);
    cantidad1 = cantidad1 - (Q50 * 50);
}
if (cantidad1 >= 20)
{
    Q20 = ((int)cantidad1 / 20);
    cantidad1 = cantidad1 - (Q20 * 20);
}
if (cantidad1 >= 10)
{
    Q10 = ((int)cantidad1 / 10);
    cantidad1 = cantidad1 - (Q10 * 10);
}
if (cantidad1 >= 5)
{
    Q5 = ((int)cantidad1 / 5);
    cantidad1 = cantidad1 - (Q5 * 5);
}
if (cantidad1 >= 1)
{
    Q1 = ((int)cantidad1 / 1);
    cantidad1 = cantidad1 - (Q1 * 1);
}
Console.WriteLine("Billetes de Q100: " + Q100);
Console.WriteLine("Billetes de Q50: " + Q50);
Console.WriteLine("Billetes de Q20: " + Q20);
Console.WriteLine("Billetes de Q10: " + Q10);
Console.WriteLine("Billetes de Q5: " + Q5);
Console.WriteLine("Billetes de Q1: " + Q1);

//MONEDAS

int cen50, cen20, cen10, cen5, cen1;
cen50 = 0; cen20 = 0; cen10= 0; cen5= 0;   cen1= 0;

if (cantidad1 >= 0.5)
{
    cen50 = ((int)(cantidad1 / 0.5));
    cantidad1 = cantidad1 - ((float)cen50 * 0.5);
}
if (cantidad1 >= 0.2)
{
    cen20 = ((int)(cantidad1 / 0.2));
    cantidad1 = cantidad1 - ((float)cen20 * 0.2);
}
if (cantidad1 >= 0.1)
{
    cen10 = ((int)(cantidad1 / 0.1));
    cantidad1 = cantidad1 - ((float)cen10 * 0.1);
}
if (cantidad1 >= 0.5)
{
    cen5 = ((int)(cantidad1 / 0.5));
    cantidad1 = cantidad1 - ((float)cen5 * 0.5);
}
if (cantidad1 >= 0.01)
{
    cen1 = ((int)(cantidad1 / 0.01));
    cantidad1 = cantidad1 -((float)cen1 * 0.01);
}
Console.WriteLine("Monedas de Q0.50: " + cen50);
Console.WriteLine("Monedas de Q0.20: " + cen20);
Console.WriteLine("Monedas de Q0.10: " + cen10);
Console.WriteLine("Monedas de Q0.5: " + cen5);
Console.WriteLine("Monedas de Q0.01: " + cen1);

