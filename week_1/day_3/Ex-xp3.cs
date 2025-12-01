using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create the brand dictionary
        var brand = new Dictionary<string, object>
        {
            {"name", "Zara"},
            {"creation_date", 1975},
            {"creator_name", "Amancio Ortega Gaona"},
            {"type_of_clothes", new List<string>{"men", "women", "children", "home"}},
            {"international_competitors", new List<string>{"Gap", "H&M", "Benetton"}},
            {"number_stores", 7000},
            {"major_color", new Dictionary<string, List<string>>
                {
                    {"France", new List<string>{"blue"}},
                    {"Spain", new List<string>{"red"}},
                    {"US", new List<string>{"pink", "green"}}
                }
            }
        };

        // Change number_stores to 2
        brand["number_stores"] = 2;

        // Print a sentence explaining Zara’s clients using type_of_clothes
        var typeOfClothes = (List<string>)brand["type_of_clothes"];
        Console.WriteLine($"Zara’s clients include {string.Join(", ", typeOfClothes)}, representing a broad customer base for all ages and interests [web:14][web:18].");

        // Add "country_creation": "Spain"
        brand["country_creation"] = "Spain";

        // Check if international_competitors exists and add "Desigual"
        if (brand.ContainsKey("international_competitors"))
        {
            var competitors = (List<string>)brand["international_competitors"];
            competitors.Add("Desigual");
        }

        // Delete creation_date
        brand.Remove("creation_date");

        // Print the last international competitor
        var competitorsList = (List<string>)brand["international_competitors"];
        Console.WriteLine($"Last international competitor: {competitorsList.Last()}");

        // Print the major colors in the US
        var majorColors = (Dictionary<string, List<string>>)brand["major_color"];
        Console.WriteLine($"Major colors in the US: {string.Join(", ", majorColors["US"])}");

        // Print the number of key-value pairs
        Console.WriteLine($"Number of key-value pairs: {brand.Count}");

        // Print all the keys
        Console.WriteLine($"All keys: {string.Join(", ", brand.Keys)}");

        // Merge with more_on_zara
        var more_on_zara = new Dictionary<string, object>
        {
            {"creation_date", 1975},
            {"number_stores", 10000}
        };

        // Merge dictionaries
        foreach (var kvp in more_on_zara)
        {
            brand[kvp.Key] = kvp.Value;
        }

        // Print number_stores and explain
        Console.WriteLine($"After merging, number_stores is: {brand["number_stores"]}");
        Console.WriteLine("The value was updated from 2 to 10000 because the merge overwrites existing keys with new values [web:24][web:27].");
    }
}