/*
* Name: Drew Sturgill
* Course: CSCI 1250, Section 001
* Assignment: Lab 04, The Group Trip
* Date: September 24, 2026
* Description: Calculates trip cost, and how many hours you must work to pay for the trip.
*/

/* Basic Information */

System.Console.WriteLine("Round Trip Miles:");
double roundTripMiles = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("How many miles for your trip?");
double tripMiles = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("How many miles per gallon can your car go?");
double milePerGallon = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("How much did you pay for gas?");
double pricePerGallon = Convert.ToDouble(System.Console.ReadLine());

//Calulations for Part 1
double gallonsNeeded = tripMiles / milePerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;
double fuelcost = fuelCost(tripMiles, milePerGallon, pricePerGallon);

//Print the calculations
System.Console.WriteLine("gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("fuel cost: " + fuelCost.ToString("C"));
System.Console.WriteLine("pizza cost: " + pizzaCost.ToString("C"));
System.Console.WriteLine("trip cost: " + totalCost.ToString("C"));


System.Console.WriteLine("How many pizzas?");
double numPizzas = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("Price per pizza?");
double pricePerPizza = Convert.ToDouble(System.Console.ReadLine());

const double slicesPerPizza = 8;

//Calculations for Part 2
string[] names = {"Ada", "Grace", "Alan", "Katherine"};
double[] hoursWorked = { 22, 15, 30, 18};
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80};
double totalSlices = numPizzas * slicesPerPizza;
double pizzaSlicesPerPerson = totalSlices / names.Length;
double pizzaCost = numPizzas * pricePerPizza;
double costperPerson = totalCost / names.Length;
//Print the calculations
System.Console.WriteLine("The group:");
System.Console.WriteLine("Total slices: " + totalSlices);
System.Console.WriteLine("Pizza slices per person: " + pizzaSlicesPerPerson.ToString("F2"));
System.Console.WriteLine("Total pizza cost: " + pizzaCost.ToString("C"));
System.Console.WriteLine("People going on the trip: " + names.Length);
System.Console.WriteLine("Slices per person: " + pizzaSlicesPerPerson.ToString("F2"));
System.Console.WriteLine("Cost per person: " + costperPerson.ToString("C"));




//Calculations for Part 3
Double totalhoursWorked = 0;
for (int i = 0; i < hoursWorked.Length; i++)
{
    totalhoursWorked += hoursWorked[i];
}
Double TotalTakeHomePay = 0;
for (int i = 0; i < hoursWorked.Length; i++)
{
    double grossPay = hoursWorked[i] * hourlyRates[i];
    double taxRate = 0.15;
    double taxWitheld = grossPay * taxRate;
    double takeHomePay = grossPay - taxWitheld;
    TotalTakeHomePay += takeHomePay;
}
Double Longest=0;
for (int i = 0; i < hoursWorked.Length; i++)
{
    if (hoursWorked[i] > Longest)
    {
        Longest = hoursWorked[i];
    }
}
double taxWitheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWitheld;
//Print the calculations
System.Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax witheld: " + taxWitheld.ToString("C"));
System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));

//Calculations for Part 4
double totalCost = fuelCost + pizzaCost;
double costPerPerson = totalCost / numPeople;
double takeHomePayPerHour = takeHomePay / hoursWorked;
double hoursYouMustWork = costPerPerson / takeHomePayPerHour;
//Print the calculations
System.Console.WriteLine("Total cost: " + totalCost.ToString("C"));
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
System.Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
System.Console.WriteLine("Hours you must work: " + hoursYouMustWork.ToString("F2"));
/* Methods */
static double fuelCost(double tripMiles, double milePerGallon, double pricePerGallon)
{
    double gallonsNeeded = tripMiles / milePerGallon;
    double fuelCost = gallonsNeeded * pricePerGallon;
    return fuelCost;
}
static double TakeHomePay(double hoursWorked, double hourlyRates)
{
    double grossPay = hoursWorked * hourlyRates;
    double taxRate = 0.15;
    double taxWitheld = grossPay * taxRate;
    double takeHomePay = grossPay - taxWitheld;
    return takeHomePay;
}
static double hourstoWork(double costPerPerson, double takeHomePayPerHour)
{
    double hoursYouMustWork = costPerPerson / takeHomePayPerHour;
    return hoursYouMustWork;
}