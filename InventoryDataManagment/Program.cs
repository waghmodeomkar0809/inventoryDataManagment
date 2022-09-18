// See https://aka.ms/new-console-template for more information
using System;
using inventoryDataManagment;
string filepath = "C:\\Users\\91762\\bridgelabz\\InventoryDataMangment\\InventoryDataManagment\\Jsconfig1.json";

FetchForJsonData fetchForJsonData = new FetchForJsonData();
Rice data= fetchForJsonData.Read(filepath);
Console.WriteLine("Data for Rice");
for(int i=0;i<data.TypeOfRice.Count;i++)
{
    Console.WriteLine(data.TypeOfRice[i].Name);
    Console.WriteLine(data.TypeOfRice[i].weight);
    Console.WriteLine(data.TypeOfRice[i].price);
    Console.WriteLine("--------------");
}
Console.WriteLine("Data of pluse");
for (int i = 0; i < data.TypeOfPluse.Count; i++)
{
    Console.WriteLine(data.TypeOfPluse[i].Name);
    Console.WriteLine(data.TypeOfPluse[i].weight);
    Console.WriteLine(data.TypeOfPluse[i].price);
    Console.WriteLine("--------------");
}
Console.WriteLine("Data of Wheat");
for (int i = 0; i < data.TypeOfWheat.Count; i++)
{
    Console.WriteLine(data.TypeOfWheat[i].Name);
    Console.WriteLine(data.TypeOfWheat[i].weight);
    Console.WriteLine(data.TypeOfWheat[i].price);
    Console.WriteLine("--------------");
}
Console.ReadLine();