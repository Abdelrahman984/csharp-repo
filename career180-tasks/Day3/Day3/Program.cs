using Day3;

Duration D1 = new Duration(2, 30, 0);
Duration D2 = new Duration(1, 45, 0);

Duration D3 = D1 + D2;
Console.WriteLine(D3);  

D3++;
Console.WriteLine(D3);  

D3 = D3 - D2;
Console.WriteLine(D3);  

if (D1 <= D2)
{
    Console.WriteLine("D1 is less than or equal to D2");
}
else
{
    Console.WriteLine("D1 is greeter than  D2");

}
