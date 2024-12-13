using LINQ_excercises;

var products = new List<Product>
        {
            new Product(1, "Laptop", 3000m, true, "Elektronika", "Dell", new DateTime(2023, 5, 1)),
            new Product(2, "Smartfon", 1500m, false, "Elektronika", "Samsung", new DateTime(2022, 9, 15)),
            new Product(3, "Tablet", 1000m, true, "Elektronika", "Apple", new DateTime(2024, 1, 20)),
            new Product(4, "Słuchawki", 200m, true, "Audio", "Sony", new DateTime(2023, 7, 11)),
            new Product(5, "Monitor", 700m, false, "Elektronika", "LG", new DateTime(2021, 11, 10)),
            new Product(6, "Klawiatura", 120m, true, "Akcesoria", "Logitech", new DateTime(2022, 8, 5)),
            new Product(7, "Mysz", 80m, true, "Akcesoria", "Razer", new DateTime(2021, 12, 15)),
            new Product(8, "Aparat", 2500m, true, "Fotografia", "Canon", new DateTime(2024, 2, 28)),
            new Product(9, "Zegarek", 3000m, false, "Elektronika", "Garmin", new DateTime(2023, 6, 9)),
            new Product(10, "Router", 350m, true, "Elektronika", "TP-Link", new DateTime(2022, 10, 12)),
            new Product(11, "Laptop", 3200m, true, "Elektronika", "HP", new DateTime(2023, 3, 17)),
            new Product(12, "Smartfon", 3000m, true, "Elektronika", "Samsung", new DateTime(2022, 12, 22)),
            new Product(13, "Tablet", 1100m, false, "Elektronika", "Huawei", new DateTime(2021, 4, 9)),
            new Product(14, "Monitor", 800m, true, "Elektronika", "Acer", new DateTime(2023, 9, 13)),
            new Product(15, "Aparat", 3000m, true, "Fotografia", "Sony", new DateTime(2023, 11, 1)),
            new Product(16, "Słuchawki", 220m, true, "Audio", "Beats", new DateTime(2023, 6, 4)),
            new Product(17, "Ładowarka", 50m, true, "Akcesoria", "Samsung", new DateTime(2023, 1, 17)),
            new Product(18, "Router", 400m, false, "Elektronika", "TP-Link", new DateTime(2021, 7, 14)),
            new Product(19, "Zegarek", 650m, true, "Elektronika", "Fitbit", new DateTime(2024, 4, 10)),
            new Product(20, "Smartfon", 2500m, true, "Elektronika", "Apple", new DateTime(2022, 11, 5)),
            new Product(21, "Laptop", 2800m, false, "Elektronika", "Lenovo", new DateTime(2021, 6, 30)),
            new Product(22, "Aparat", 2700m, true, "Fotografia", "Canon", new DateTime(2023, 8, 3)),
            new Product(23, "Słuchawki", 250m, true, "Audio", "Bose", new DateTime(2024, 2, 22)),
            new Product(24, "Smartfon", 1900m, false, "Elektronika", "Xiaomi", new DateTime(2023, 4, 1)),
            new Product(25, "Laptop", 3100m, true, "Elektronika", "Acer", new DateTime(2022, 5, 6)),
            new Product(26, "Router", 450m, true, "Elektronika", "Netgear", new DateTime(2023, 2, 15)),
            new Product(27, "Tablet", 2500m, true, "Elektronika", "Lenovo", new DateTime(2023, 10, 20)),
            new Product(28, "Klawiatura", 150m, false, "Akcesoria", "Corsair", new DateTime(2023, 11, 5)),
            new Product(29, "Mysz", 70m, true, "Akcesoria", "SteelSeries", new DateTime(2021, 9, 22)),
            new Product(30, "Zegarek", 700m, true, "Elektronika", "Garmin", new DateTime(2023, 12, 15)),
        };

// 1. Znajdź wszystkie produkty z kategorii "Elektronika", których cena jest większa niż 2000 zł.
var result = products.Where(p => p.Category == "Elektronika" && p.Price > 2000);
Console.WriteLine("\n1. Znajdź wszystkie produkty z kategorii \"Elektronika\", których cena jest większa niż 2000 zł");
foreach (var product in result)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price} - {product.Category}");
}

// 2. Posortuj produkty według ceny rosnąco, a następnie według nazwy alfabetycznie.
var result2 = products
    .OrderBy(p => p.Price)
    .ThenBy(p => p.Name);
Console.WriteLine("\n2. Posortuj produkty według ceny rosnąco, a następnie według nazwy alfabetycznie.");
foreach (var product in result2)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price} - {product.Category}");
}

// 3. Wybierz nazwy i ceny produktów, które są aktualnie dostępne w sprzedaży (InStock = true).
var result3 = products
    .Where(p => p.InStock)
    .Select(p => new
    {
        p.Name,
        p.Price
    });
Console.WriteLine("\n3. Wybierz nazwy i ceny produktów, które są aktualnie dostępne w sprzedaży (InStock = true).");
foreach (var product in result3)
{
    Console.WriteLine($"{product.Name} - {product.Price}");
}

// 4. Znajdź pierwszy produkt, który kosztuje mniej niż 100 zł.
var result4 = products.FirstOrDefault(p => p.Price < 100); 
Console.WriteLine("4. Znajdź pierwszy produkt, który kosztuje mniej niż 100 zł.");
Console.WriteLine($"{result4.Name} - {result4.Price}");

// 5.  Znajdź wszystkie unikalne marki produktów.
var result5 = products.Select(p => p.Brand).Distinct();
Console.WriteLine("\n5.  Znajdź wszystkie unikalne marki produktów.");
foreach (var item in result5)
{
    Console.WriteLine($"{item}");
}

// 6. Połącz nazwy wszystkich produktów w jeden ciąg znaków oddzielony przecinkami.
var result6 = string.Join(", ", products.Select(p => p.Name));
Console.WriteLine("\n6. Połącz nazwy wszystkich produktów w jeden ciąg znaków oddzielony przecinkami.");
Console.WriteLine(result6);

// 7. Policz, ile produktów znajduje się w kategorii "Audio".
var result7 = products.Count(p => p.Category == "Audio");

// 8. Znajdź wszystkie unikalne marki produktów.
var result8 = products.Select(p => p.Brand).Distinct();

// 9. Sprawdź, czy wszystkie produkty w kategorii "Fotografia" są dostępne w sprzedaży.
var result9 = products
    .Where(p => p.Category == "Fotografia")
    .All(p => p.InStock);

// 10. Pobierz 5 najnowszych produktów według daty dodania.
var result10 = products
    .OrderByDescending(p => p.ReleaseDate)
    .Take(5);

// 11 .Znajdź produkty z ceną między 500 a 1500 zł, a następnie odwróć kolejność ich wyświetlania.
var result11 = products.Where(p => p.Price >= 500m && p.Price <= 1500m).Reverse().ToList();

// 12. Produkty z kategorii "Elektronika" posortowane po cenie rosnąco, a następnie malejąco po nazwie marki
var result12 = products
    .Where(p => p.Category == "Elektronika")
    .OrderBy(p => p.Price)
    .ThenByDescending(p => p.Brand)
    .ToList();

Console.WriteLine("\nProdukty z kategorii Elektronika:");
foreach (var product in result)
{
    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Brand: {product.Brand}");
}

// 13. Suma cen wszystkich dostępnych produktów (InStock = true)
var totalPrice = products
    .Where(p => p.InStock)
    .Sum(p => p.Price);

Console.WriteLine($"\nSuma cen dostępnych produktów: {totalPrice}");

// 14. Trzy najdroższe produkty z kategorii "Fotografia"
var top3PhotographyProducts = products
    .Where(p => p.Category == "Fotografia")
    .OrderByDescending(p => p.Price)
    .Take(3)
    .ToList();

Console.WriteLine("\nTrzy najdroższe produkty z kategorii Fotografia:");
foreach (var product in top3PhotographyProducts)
{
    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
}

// 15. Produkty, które zostały dodane w 2023 roku, posortowane malejąco po cenie
var productsAddedIn2023 = products
    .Where(p => p.ReleaseDate.Year == 2023)
    .OrderByDescending(p => p.Price)
    .ToList();

Console.WriteLine("\nProdukty dodane w 2023 roku:");
foreach (var product in productsAddedIn2023)
{
    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, ReleaseDate: {product.ReleaseDate}");
}

// 16. Sprawdzenie, czy jakikolwiek produkt w kategorii "Audio" kosztuje więcej niż 500 zł
var anyExpensiveAudio = products
    .Where(p => p.Category == "Audio")
    .Any(p => p.Price > 500);

Console.WriteLine(anyExpensiveAudio
    ? "\nW kategorii Audio istnieje produkt droższy niż 500 zł."
    : "\nW kategorii Audio nie ma produktów droższych niż 500 zł.");


// 17. Średnia cena produktów marki "Samsung"
var averagePriceSamsung = products
    .Where(p => p.Brand == "Samsung")
    .Average(p => p.Price);

Console.WriteLine($"\nŚrednia cena produktów marki Samsung: {averagePriceSamsung}");

// 18. Grupowanie produktów według kategorii i wyliczanie liczby produktów w każdej kategorii
var groupedByCategory = products
    .GroupBy(p => p.Category)
    .Select(g => new { Category = g.Key, Count = g.Count() })
    .ToList();

Console.WriteLine("\nLiczba produktów w każdej kategorii:");
foreach (var group in groupedByCategory)
{
    Console.WriteLine($"Category: {group.Category}, Count: {group.Count}");
}

// 19. Produkty, które są na stanie i mają cenę w przedziale od 500 do 2000 zł
var activeProductsInRange = products
    .Where(p => p.InStock && p.Price >= 500 && p.Price <= 2000)
    .ToList();

Console.WriteLine("'mProdukty na stanie w przedziale cenowym 500-2000 zł:");
foreach (var product in activeProductsInRange)
{
    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
}

// 20. Lista nazw produktów i marek, których ceny są większe niż średnia cena wszystkich produktów
var averagePrice = products.Average(p => p.Price);

var aboveAverageProducts = products
    .Where(p => p.Price > averagePrice)
    .Select(p => new { p.Name, p.Brand })
    .ToList();

Console.WriteLine("\nProdukty z ceną powyżej średniej:");
foreach (var product in aboveAverageProducts)
{
    Console.WriteLine($"Name: {product.Name}, Brand: {product.Brand}");
}


// 21.Złączenie produktów, które są na stanie, z ich kategorią w nowy obiekt
var activeProductsWithCategory = products
    .Where(p => p.InStock)
    .Select(p => new { p.Name, p.Category, p.Price })
    .ToList();

Console.WriteLine("Produkty na stanie z kategoriami:");
foreach (var product in activeProductsWithCategory)
{
    Console.WriteLine($"Name: {product.Name}, Category: {product.Category}, Price: {product.Price}");
}

// 22. Pierwszy produkt w kategorii "Akcesoria" posortowany malejąco po dacie dodania
var firstAccessory = products
    .Where(p => p.Category == "Akcesoria")
    .OrderByDescending(p => p.ReleaseDate)
    .FirstOrDefault();

if (firstAccessory != null)
{
    Console.WriteLine($"\nPierwszy produkt w kategorii Akcesoria: Name: {firstAccessory.Name}, ReleaseDate: {firstAccessory.ReleaseDate}");
}
else
{
    Console.WriteLine("\nBrak produktów w kategorii Akcesoria.");
}

// 23. Lista marek, które występują w więcej niż jednym produkcie
var brandsWithMultipleProducts = products
    .GroupBy(p => p.Brand)
    .Where(g => g.Count() > 1)
    .Select(g => g.Key)
    .ToList();

Console.WriteLine("\nMarki z więcej niż jednym produktem:");
foreach (var brand in brandsWithMultipleProducts)
{
    Console.WriteLine($"Brand: {brand}");
}

// 24. Produkty, które nie są na stanie i zostały dodane przed 2023 rokiem
var inactiveProductsBefore2023 = products
    .Where(p => !p.InStock && p.ReleaseDate.Year < 2023)
    .ToList();

Console.WriteLine("\nProdukty, których nie ma na stanie dodane przed 2023 rokiem:");
foreach (var product in inactiveProductsBefore2023)
{
    Console.WriteLine($"Name: {product.Name}, ReleaseDate: {product.ReleaseDate}");
}

// 25. Unikalne kategorie dostępnych produktów
var uniqueCategories = products
    .Where(p => p.InStock)
    .Select(p => p.Category)
    .Distinct()
    .ToList();

Console.WriteLine("Unikalne kategorie dostępnych produktów:");
foreach (var category in uniqueCategories)
{
    Console.WriteLine($"Category: {category}");
}

// 26. Łączenie produktów z tej samej kategorii i sumowanie ich cen
var categoryPriceSums = products
    .GroupBy(p => p.Category)
    .Select(g => new { Category = g.Key, TotalPrice = g.Sum(p => p.Price) })
    .ToList();

Console.WriteLine("Suma cen produktów w każdej kategorii:");
foreach (var group in categoryPriceSums)
{
    Console.WriteLine($"Category: {group.Category}, TotalPrice: {group.TotalPrice}");
}


var people = new List<Person>
{
    new Person("John", "Smith", 35, "Engineer", 5500m, new DateTime(2023, 5, 1)),
    new Person("Anna", "Brown", 28, "Doctor", 8000m, new DateTime(2022, 11, 15)),
    new Person("Peter", "Green", 40, "Lawyer", 10000m, new DateTime(2020, 7, 10)),
    new Person("Mary", "White", 33, "Teacher", 4000m, new DateTime(2021, 3, 22)),
    new Person("Tom", "Black", 50, "Director", 15000m, new DateTime(2019, 1, 5)),
    new Person("Catherine", "Jones", 27, "Engineer", 6000m, new DateTime(2023, 6, 30)),
    new Person("Paul", "Davis", 38, "Driver", 3500m, new DateTime(2021, 12, 1)),
    new Person("Eve", "Moore", 45, "Cook", 4200m, new DateTime(2020, 10, 20)),
    new Person("Michael", "Taylor", 30, "Doctor", 7000m, new DateTime(2023, 4, 14)),
    new Person("Sophia", "Anderson", 32, "Architect", 7500m, new DateTime(2021, 9, 12)),
    new Person("Luke", "Thomas", 29, "Programmer", 9500m, new DateTime(2022, 8, 1)),
    new Person("Agnes", "Harris", 37, "Manager", 8500m, new DateTime(2023, 3, 5)),
    new Person("Chris", "Martin", 42, "Driver", 4000m, new DateTime(2021, 11, 9)),
    new Person("Joanna", "Clark", 25, "Student", 2000m, new DateTime(2023, 12, 15)),
    new Person("Rafael", "Walker", 48, "Driver", 3700m, new DateTime(2020, 2, 27)),
};

// 1. Lista osób starszych niż 30 lat z wynagrodzeniem wyższym niż średnie na liście
var averageSalary = people.Average(p => p.Salary);

var people1 = people
    .Where(p => p.Age > 30 && p.Salary > averageSalary)
    .Select(p => new { p.FirstName, p.LastName, p.Salary });

foreach (var person in people1)
{
    Console.WriteLine($"{person.FirstName} {person.LastName} - {person.Salary:C}");
}

// 2. Liczba osób zatrudnionych po 2021 roku
var peopleCount = people.Count(p => p.EmploymentDate.Year > 2021);
Console.WriteLine($"\nNumber of people hired after 2021: {peopleCount}");

// 3. Grupowanie osób według profesji i liczenie osób w każdej grupie
var groupedByProfession = people
    .GroupBy(p => p.Profession)
    .Select(group => new { Profession = group.Key, Count = group.Count() });

Console.WriteLine("\n People grouped by profession:");
foreach (var group in groupedByProfession)
{
    Console.WriteLine($"{group.Profession}: {group.Count} people");
}

// 4. Osoba z najdłuższym stażem pracy
var personWithLongestEmployment = people
    .OrderBy(p => p.EmploymentDate)
    .First();

Console.WriteLine($"\nPerson with the longest employment: {personWithLongestEmployment.FirstName} {personWithLongestEmployment.LastName}, hired on {personWithLongestEmployment.EmploymentDate:yyyy-MM-dd}");


// 5. Czy wszyscy kierowcy zarabiają więcej niż 3000 zł?
var allDriversEarnMoreThan3000 = people
    .Where(p => p.Profession == "Driver")
    .All(p => p.Salary > 3000m);

Console.WriteLine(allDriversEarnMoreThan3000 ? "\nYes, all drivers earn more than 3000" : "\nNo, not all drivers earn more than 3000");

// 6. Lista unikalnych zawodów
var uniqueProfessions = people
    .Select(p => p.Profession)
    .Distinct();
Console.WriteLine("\nUnique professions:");
foreach (var profession in uniqueProfessions)
{
    Console.WriteLine(profession);
}

// 7. Złączenie imion osób w jeden ciąg znaków oddzielony przecinkami
var names = string.Join(", ", people.Select(p => p.FirstName));
Console.WriteLine($"\nNames: {names}");

// 8. Najstarsza osoba zarabiająca mniej niż 5000 zł
var oldestPersonUnder5000 = people
    .Where(p => p.Salary < 5000m)
    .OrderByDescending(p => p.Age)
    .First();

Console.WriteLine($"\nOldest person earning less than 5000: {oldestPersonUnder5000.FirstName} {oldestPersonUnder5000.LastName}, Age: {oldestPersonUnder5000.Age}");

// 9. Najlepiej zarabiająca osoba w każdej profesji
var bestEarnersByProfession = people
    .GroupBy(p => p.Profession)
    .Select(group => group.OrderByDescending(p => p.Salary).First());

Console.WriteLine("\nThe highest paid person in any profession");
foreach (var person in bestEarnersByProfession)
{
    Console.WriteLine($"Profession: {person.Profession}, Person: {person.FirstName} {person.LastName}, Salary: {person.Salary:C}");
}

// 10. Osoby, które zostały zatrudnione w ostatnim roku
var oneYearAgo = DateTime.Now.AddYears(-1);

var recentlyHired = people
    .Where(p => p.EmploymentDate > oneYearAgo);

Console.WriteLine("\nPeople who were hired last year");
foreach (var person in recentlyHired)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}, Hired on: {person.EmploymentDate:yyyy-MM-dd}");
}
