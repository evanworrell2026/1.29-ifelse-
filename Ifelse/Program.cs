using System;

Console.WriteLine("Please enter your membership type - Gold, Silver, or Guest:");
string membership = Console.ReadLine();

if (membership == "GolD")
{
    Console.WriteLine($"Welcome, Gold Member!");
}
else if (membership == "Silver")
{
    Console.WriteLine($"Welcome, Silver Member!");
}
else if (membership == "Guest")
{
    Console.WriteLine($"Welcome, Guest!");
}
// using ternary operator to handle multiple conditions
string message = membership == "Gold" ? "Welcome, Gold Member!"
                : membership == "Silver" ? "Welcome, Silver Member!" :
                "Welcome, Guest!";
Console.WriteLine("Using ternary operator: " + message);

double discount = membership == "Gold" ? 0.20
                : membership == "Silver" ? 0.10 :
                0.0;
double pre_discountPrice = 100.0;

double after_discountPrice = pre_discountPrice * (1 - discount);

Console.WriteLine($"Price after discount: {after_discountPrice}");
