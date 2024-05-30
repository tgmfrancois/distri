// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int stock1, stock2, stock3, choix;

stock1 = 5;
stock2 = 2;
stock3 = 0;

Console.WriteLine("Veuillez sélectionner une boisson");
Console.WriteLine("1. Eau");
Console.WriteLine("2. Soda");
Console.WriteLine("3. Orangeade");
// dans un monde idéal j'ai rajouté une boucle 
choix = int.Parse(Console.ReadLine());
switch (choix) 
{
    case 1:
        if (stock1 > 0)
        {
            Console.WriteLine("Voici votre eau");
            stock1--;
        }
        else 
        { 
        Console.WriteLine("Sold Out !");
        }
        break;
    case 2:
        if (stock2 > 0)
        {
            Console.WriteLine("Voici votre soda");
            stock2--;            
        }
        else
        {
            Console.WriteLine("Sold Out !");
        }
        break;
    case 3:
        if (stock3 > 0)
        {       
        Console.WriteLine("Voici votre orangeade");
        stock3--;
        }
        else
        {
            Console.WriteLine("Sold Out !");
        }
        break;
    default: Console.WriteLine("Choix indisponible");
        break;


}






