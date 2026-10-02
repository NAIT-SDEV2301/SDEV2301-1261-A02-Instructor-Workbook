using Lesson13_LinqIntro;
using System;
using System.Collections.Generic;
using System.Linq;

// SUPPLIED DATA: leave these lists unchanged during the activities.
var students = new List<Student>
{
    new Student("Asha", 91),
    new Student("Chris", 68),
    new Student("Sofia", 77),
    new Student("Jordan", 84),
    new Student("Mei", 59)
};

// Exact 20-entry dataset from the linked Pokemon worksheet.
var pokedex = new List<Pokemon>
{
    new(  1, "Bulbasaur",  "Grass",  "Poison", 49, 49, 45, 318, false),
    new(  4, "Charmander", "Fire",   null,     52, 43, 65, 309, false),
    new(  7, "Squirtle",   "Water",  null,     48, 65, 43, 314, false),
    new( 25, "Pikachu",    "Electric",null,    55, 40, 90, 320, false),
    new( 39, "Jigglypuff", "Normal", "Fairy",  45, 20, 20, 270, false),
    new( 52, "Meowth",     "Normal", null,     45, 35, 90, 290, false),
    new( 63, "Abra",       "Psychic",null,     20, 15, 90, 310, false),
    new( 92, "Gastly",     "Ghost",  "Poison", 35, 30, 80, 310, false),
    new( 95, "Onix",       "Rock",   "Ground", 45,160, 70, 385, false),
    new(129, "Magikarp",   "Water",  null,     10, 55, 80, 200, false),
    new(131, "Lapras",     "Water",  "Ice",    85, 80, 60, 535, false),
    new(133, "Eevee",      "Normal", null,     55, 50, 55, 325, false),
    new(143, "Snorlax",    "Normal", null,    110, 65, 30, 540, false),
    new(149, "Dragonite",  "Dragon", "Flying",134, 95, 80, 600, false),
    new(150, "Mewtwo",     "Psychic",null,    110, 90,130, 680, true),
    new(151, "Mew",        "Psychic",null,    100,100,100, 600, true),
    new(245, "Suicune",    "Water",  null,     75,115, 85, 580, true),
    new(248, "Tyranitar",  "Rock",   "Dark",  134,110, 61, 600, false),
    new(384, "Rayquaza",   "Dragon", "Flying",150, 90, 95, 680, true),
    new(445, "Garchomp",   "Dragon", "Ground",130, 95,102, 600, false),
};

var products = new List<Product>
{
    new Product("Notebook", 4.99m, "School"),
    new Product("Mouse", 19.99m, "Tech"),
    new Product("Headphones", 79.99m, "Tech"),
    new Product("Granola Bars", 6.49m, "Food"),
    new Product("Water Bottle", 14.99m, "School")
};

// STARTUP CHECK: run the unchanged starter before starting the activities.
Console.WriteLine($"Students ready: {students.Count}");
Console.WriteLine($"Pokémon ready: {pokedex.Count}");

// Write your code in the sections below. Use a different variable name for
// each query, or edit an existing query as directed during the lesson.
// Predict the result type in a comment, then print results to check your work.

#region Warm-up - slide 4
// TODO: Follow the warm-up instructions on the slide.


#endregion

#region Where - slide 8
// TODO: Write your filtering queries and print the results.
// Predicted result type:


#endregion

#region Select - slide 11
// TODO: Write your names, marks, and labels queries.
// Predicted result type for each query:


#endregion

#region Student chains - slide 14
// TODO: Complete the student-query challenge.
// Predicted result type for each query:


#endregion

#region Sorting - slide 17
// TODO: Complete the sorting activity.
// Predicted result type after each method:


#endregion

#region Pokemon A - filtering
// TODO: Complete worksheet tasks A1-A5.
// Predict each result type, then print the results.


#endregion

#region Pokemon B - projection
// TODO: Complete worksheet tasks B6-B8.
// Predict each result type, then print the results.


#endregion

#region Pokemon C - chaining
// TODO: Complete worksheet tasks C9-C12.
// Predict each result type, then print the results.


#endregion

#region Pokemon D - read the query
// TODO: Explain the three worksheet queries here using comments.
// Include what is filtered, what is returned, and the result type.


#endregion

#region Optional extension - Pokemon sorting
// TODO: Follow the extension prompt on slide 20 when you finish A-D.


#endregion

#region Products names price <= 15, sorted by price

var sortedProductNames = products
    .Where(currentProduct => currentProduct.Price <= 15)
    .OrderBy(currentProduct => currentProduct.Price)
    .Select(currentProduct => currentProduct.Name);
foreach(var currentName in sortedProductNames)
{
    Console.WriteLine($"{currentName}");
}

#endregion

#region Product names in Tech, sorted by price descending
var sortedProductNamesInTech = products
    .Where(p => p.Name.Contains("Tech"))
    .OrderByDescending(p => p.Price)
    .Select(p => p.Name);
#endregion

#region School products, sorted by name, projecting name only
var sortedSchoolProducts = products
    .Where(p => p.Name.ToLower() == "School".ToLower())
    .OrderBy(p => p.Name)
    .Select(p => p.Name);
#endregion

var groups = products.GroupBy(p => p.Category);

var countsByCategory = products
    .GroupBy(p => p.Category)
    .Select(g => new
    {
        Category = g.Key,
        Count = g.Count()
    });
foreach(var row in countsByCategory)
{
    Console.WriteLine($"{row.Category}: {row.Count}");
}

