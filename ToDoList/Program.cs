using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to your task tracker!");
      Menu();
    }

    public static void Menu()
    {
      Console.WriteLine("Would you like to add a new item to your to-do list or view your current tasks?\n [VIEW] [ADD] [QUIT]");
      string userResponse = Console.ReadLine();
      if (userResponse.ToLower() == "view")
      {
        DisplayItems();
      }
      else if (userResponse.ToLower() == "add")
      {
        GetNewItemDescription();
      }
      else if (userResponse.ToLower() == "quit")
      {
        Console.WriteLine("Have a nice day!");
      }
    }

    public static void GetNewItemDescription()
    {
      Console.WriteLine("What task would you like to add to your to-do list? (enter a description)");
      string description = Console.ReadLine();
      Item newItem = new Item(description);
      DisplayItems();
    }

    public static void DisplayItems()
    {
      List<Item> allItems = Item.GetAll();
      if (allItems.Count > 0)
      {
        int counter = 1;
        Console.WriteLine("Your to-do list includes:");
        foreach (Item item in allItems)
        {
          Console.WriteLine(counter + ". " + item.Description);
          counter++;
        }
        Menu();
      }
      else
      {
        Console.WriteLine("You have nothing to do!");
        Menu();
      }
    }
  }
}