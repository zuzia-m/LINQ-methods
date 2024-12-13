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

// SELECT - do rzutowania lub transformowania elementów kolekcji na nowy typ lub format
var productNames = products.Select(p => p.Name);
Console.WriteLine("Nazwy produktów:");
foreach (var name in productNames)
{
    Console.WriteLine(name);
}

// DISTINCT - wraca unikalne elementy z kolekcji, eliminując duplikaty
var uniqueNames = products.Select(p => p.Name).Distinct();
Console.WriteLine("\nUnikalne nazwy produktów:");
foreach (var name in uniqueNames)
{
    Console.WriteLine(name);
}

var uniqueCategories = products.Select(p => p.Category).Distinct();
Console.WriteLine("\nUnikalne kategorie produktów:");
foreach (var name in uniqueCategories)
{
    Console.WriteLine(name);
}

// WHERE - do filtrowania elementów kolekcji na podstawie warunku
var expensiveProducts = products.Where(p => p.Price > 500);
Console.WriteLine("\nProdukty droższe niz 500 zł:");
foreach (var product in expensiveProducts)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price} zł");
}

var appleProducts = products.Where(p => p.Brand == "Apple");
Console.WriteLine("\n Produkty firmy Apple:");
foreach (var product in appleProducts)
{
    Console.WriteLine($"{product.Name} - {product.Brand}");
}

// SINGLE -  Pobiera dokładnie jeden element z kolekcji, rzuca wyjątek, jeśli kolekcja zawiera zero lub więcej niż jeden element
var singleProdut = products.Single(p => p.Name == "Ładowarka");
Console.WriteLine($"\nPojedynczy produkt o nazwie Ładowarka - {singleProdut.Id}. {singleProdut.Name} - {singleProdut.Price} zł");

//var singleProdut2 = products.Single(p => p.Name == "Laptop");
//Console.WriteLine($"\nPojedynczy produkt o nazwie Laptop - {singleProdut2.Id}. {singleProdut2.Name} - {singleProdut2.Price} zł");

//var singleProdut3 = products.Single(p => p.Name == "Podkładka");
//Console.WriteLine($"\nPojedynczy produkt o nazwie Podkładka - {singleProdut3.Id}. {singleProdut3.Name} - {singleProdut3.Price} zł");

// SINGLE -  Pobiera dokładnie jeden element z kolekcji, rzuca wyjątek, jeśli kolekcja zawiera zero lub więcej niż jeden element
var singleOrDefaultProdut = products.SingleOrDefault(p => p.Name == "Podkładka");
if (singleOrDefaultProdut != null)
{
    Console.WriteLine($"\nPojedynczy produkt o nazwie Podkładka - {singleOrDefaultProdut.Id}. {singleOrDefaultProdut.Name} - {singleOrDefaultProdut.Price} zł");
}
else
{
    Console.WriteLine("\nNa liście nie ma produktu o nazwie Podkładka.");
}

// FIRST - Pobiera pierwszy element z kolekcji; rzuca wyjątek, jeśli kolekcja jest pusta
var firstProduct = products.First(p => p.Name == "Aparat");
Console.WriteLine($"\nPierwszy produkt o nazwie Aparat - {firstProduct.Id}. {firstProduct.Name} - {firstProduct.Price} zł");

//var firstProduct2 = products.First(p => p.Name == "Podkładka");
//Console.WriteLine($"\nPierwszy produkt o nazwie Podkładka - {firstProduct.Id}. {firstProduct.Name} - {firstProduct.Price} zł");

// FIRST OR DEFAULT - Pobiera pierwszy element lub domyślną wartość, jeśli kolekcja jest pusta; rzuca wyjątek, jeśli jest więcej niż jeden element
var firstOrDefaultProduct = products.FirstOrDefault(p => p.Name == "Podkładka");
if (firstOrDefaultProduct != null)
{
    Console.WriteLine($"\nPierwszy produkt o nazwie Podkładka - {firstOrDefaultProduct.Id}. {firstOrDefaultProduct.Name} - {firstOrDefaultProduct.Price} zł");
}
else
{
    Console.WriteLine("\nNa liście nie ma produktu o nazwie Podkładka.");
}

var firstOrDefaultProduct2 = products.FirstOrDefault(p => p.Name == "Laptop");
if (firstOrDefaultProduct2 != null)
{
    Console.WriteLine($"\nPierwszy produkt o nazwie Laptop - {firstOrDefaultProduct2.Id}. {firstOrDefaultProduct2.Name} - {firstOrDefaultProduct2.Price} zł");
}
else
{
    Console.WriteLine("\nNa liście nie ma produktu o nazwie Laptop.");
}

// ORDER BY - do sortowania elementów kolekcji w kolejności rosnącej na podstawie klucza
var orderedProductsByPrice = products.OrderBy(p => p.Price);
Console.WriteLine("\nProdukty posortowane po cenie rosnąco:");
foreach (var product in orderedProductsByPrice)
{
    Console.WriteLine($"{product.Name} - {product.Price} zł");
}

// ORDER BY DESCENDING - do sortowania elementów kolekcji w kolejności malejącej na podstawie klucza
var orderedProductsByPriceDescending = products.OrderByDescending(p => p.Price);
Console.WriteLine("\nProdukty posortowane po cenie malejąco:");
foreach (var product in orderedProductsByPriceDescending)
{
    Console.WriteLine($"{product.Name} - {product.Price} zł");
}

// THEN BY do stosowania dodatkowego kryterium sortowania w kolejności rosnącej
var orderedProductsByPriceAndName = products
    .OrderBy(p => p.Price)
    .ThenBy(p => p.Name);
Console.WriteLine("\nProdukty posortowane po cenie rosnąco i po nazwie:");
foreach (var product in orderedProductsByPriceAndName)
{
    Console.WriteLine($"{product.Name} - {product.Price} zł");
}

// ALL - Sprawdza, czy wszystkie elementy kolekcji spełniają określony warunek
var isAllElectronics = products.All(p => p.Category == "Elektronika");
Console.WriteLine($"\nCzy wszystkie prodkukty należą do kategorii Elektronika: {isAllElectronics}");

List<Product> electronicProducts = new List<Product>();
foreach (var product in products)
{
    if (product.Category == "Elektronika")
    {
        electronicProducts.Add(product);
    }
}
var allElectronics = products.Count() == electronicProducts.Count();
Console.WriteLine($"\nCzy wszystkie prodkukty należą do kategorii Elektronika: {allElectronics}");

var isAllMoreThan100 = products.All(p => p.Price > 100m);
Console.WriteLine($"\nCzy wszystkie produkty kosztują więcej niż 100 zł: {isAllMoreThan100}");

var isAllReleasedAfter2000 = products.All(p => p.ReleaseDate > new DateTime(2000, 1, 1));
Console.WriteLine($"\nCzy wszystkie produkty zostały wydane po 2000 roku: {isAllReleasedAfter2000}");

// ANY - Sprawdza, czy co najmniej jeden element kolekcji spełnia określony warunek
var anyAudio = products.Any(p => p.Category == "Audio");
Console.WriteLine($"\n Czy na liście jest jakikolwiek produkt kategorii Audio: {anyAudio}");

var anyAboveThan5000 = products.Any(p => p.Price > 5000m);
Console.WriteLine($"\nCzy na liście jest jakikolwiek produkt droższy niż 5000 zł: {anyAboveThan5000}");

// REVERSE - Odwraca kolejność elementów w kolekcji
var reversedProducts = products.AsEnumerable().Reverse();
Console.WriteLine($"\nOdwrócona lista produktów:");
foreach (var product in reversedProducts)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price}");
}

// SKIP -  Pomija określoną liczbę elementów na początku kolekcj
var skippedProducts = products.Skip(5);
Console.WriteLine("\nSkip 5:");
foreach (var product in skippedProducts)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price}");
}

// SKIP WHILE - Pomija elementy tak długo, jak spełniony jest warunek, a potem zwraca resztę kolekcji
var productsAbove100SkipWhile = products.SkipWhile(p => p.Price > 100m);
Console.WriteLine("\nWarunek cena ponad 100 zł - Skip While:");
foreach (var product in productsAbove100SkipWhile)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price}");
}

// TAKE - Pobiera określoną liczbę elementów od początku kolekcji
var take5Products = products.Take(5);
Console.WriteLine("\nTake 5:");
foreach (var product in take5Products)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price}");
}

// TAKE WHILE - Pobiera elementy tak długo, jak spełniony jest warunek, a potem przerywa
var productsAbove100TakeWhile = products.TakeWhile(p => p.Price > 100m);
Console.WriteLine("\nWarunek cena ponad 100 zł - Take While:");
foreach (var product in productsAbove100TakeWhile)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price}");
}

// CONCAT - Łączy dwie kolekcje w jedną sekwencję
var newList = new List<Product>()
{
    new Product(31, "Tablet", 1000m, true, "Elektronika", "Apple", new DateTime(2024, 1, 20)),
    new Product(32, "Słuchawki", 200m, true, "Audio", "Sony", new DateTime(2023, 7, 11))
};
var combinedList = products.Concat(newList);
Console.WriteLine("\nPołączona lista:");
foreach (var product in combinedList)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price}");
}

// UNION - połączenie bez duplikatów
var smartphone = new Product(4, "Smartfon", 3000, true, "Elektronika", "Samsung", new DateTime(2024, 1, 20));
var tablet = new Product(31, "Tablet", 1000m, true, "Elektronika", "Apple", new DateTime(2024, 1, 20));
var laptop = new Product(1, "Laptop", 1000m, true, "Elektronika", "Dell", new DateTime(2024, 1, 22));

var firstList = new List<Product>()
{
    smartphone, tablet
};
var secondList = new List<Product>()
{
    laptop, smartphone
};

var combinedListWithUnion = firstList.Union(secondList);
Console.WriteLine("\nPołączona lista z union - bez duplikatów:");
foreach (var product in combinedListWithUnion)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price}");
}

var combinedListWithConcat2 = firstList.Concat(secondList);
Console.WriteLine("\nPołączona lista z concat - z duplikatami:");
foreach (var product in combinedListWithConcat2)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price}");
}

var firstList2 = new List<Product>()
{
    new Product(4, "Smartfon", 3000, true, "Elektronika", "Samsung", new DateTime(2024, 1, 20)),
    new Product(31, "Tablet", 1000m, true, "Elektronika", "Apple", new DateTime(2024, 1, 20))
};
var secondList2 = new List<Product>()
{
    new Product(1, "Laptop", 1000m, true, "Elektronika", "Dell", new DateTime(2024, 1, 22)),
    new Product(4, "Smartfon", 3000, true, "Elektronika", "Samsung", new DateTime(2024, 1, 20))
};
var combinedListWithUnion2 = firstList2.Union(secondList2);
Console.WriteLine("\nPołączona lista z union - bez duplikatów, new Product:");
foreach (var product in combinedListWithUnion2)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Price}");
}

// COUNT - policzenie elementów
var countProducts = products.Count();
Console.WriteLine($"\nNa liście jest {countProducts} produktów.");

var countInStockProducts = products.Count(p => p.InStock);
Console.WriteLine($"\nNa liście są {countInStockProducts} produky dostępne.");

// INTERSECT - do zwrócenia wspólnych elementów dwóch kolekcji
var smartphone2 = new Product(4, "Smartfon", 3000, true, "Elektronika", "Samsung", new DateTime(2024, 1, 20));
var tablet2 = new Product(31, "Tablet", 1000m, true, "Elektronika", "Apple", new DateTime(2024, 1, 20));
var laptop2 = new Product(1, "Laptop", 1000m, true, "Elektronika", "Dell", new DateTime(2024, 1, 22));
var mysz = new Product(11, "Musz", 100m, true, "Akcesoria", "LG", new DateTime(2024, 1, 22));
var klawiatura = new Product(17, "Klawiatura", 600m, true, "Akcesoria", "LG", new DateTime(2024, 1, 22));

var firstList3 = new List<Product>()
{
    new Product(4, "Smartfon", 3000, true, "Elektronika", "Samsung", new DateTime(2024, 1, 20)),
    tablet2,
    mysz,
    klawiatura
};
var secondList3 = new List<Product>()
{
    laptop2,
    new Product(4, "Smartfon", 3000, true, "Elektronika", "Samsung", new DateTime(2024, 1, 20)),
    klawiatura
};

var combinedProducts = firstList3.Intersect(secondList3);
Console.WriteLine("\nProdukty wspólne dla obu list:");
foreach (var product in combinedProducts)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Brand}");
}

// TYPY WARTOŚCIOWE
var ints1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
var ints2 = new List<int>() { 4, 5, 6, 7, 8, 9};

var combinedInts = ints1.Intersect(ints2);
Console.WriteLine("\nInty wspólne dla obu list");
foreach (var item in combinedInts)
{
    Console.WriteLine(item);
}

// EXCEPT - do zwracania elementów z jednej kolekcji, które nie występują w drugiej kolekcji
var exceptProducts = firstList3.Except(secondList3);
Console.WriteLine("\nProdukty z listy 1, które nie występują na liście 2:");
foreach (var product in exceptProducts)
{
    Console.WriteLine($"{product.Id}. {product.Name} - {product.Brand}");
}

var exceptInts = ints1.Except(ints2);
Console.WriteLine("\nInty z listy 1, które nie występują na liście 2:");
foreach (var item in exceptInts)
{
    Console.WriteLine(item);
}

// ELEMENT AT
var productAtIndex3 = products.ElementAt(3);
Console.WriteLine($"\nProdukt na indeksie 3 to: {productAtIndex3.Id}. {productAtIndex3.Name}");

// ELEMENT AT OR DEFAULT
var productAtIndex33 = products.ElementAtOrDefault(33);
if (productAtIndex33 != null)
{
    Console.WriteLine($"\nProdukt na indeksie 33 to: {productAtIndex33.Id}. {productAtIndex33.Name}");
}
else
{
    Console.WriteLine("\nBrak produktu o indeksie 33");
}

// GROUP BY
var groupedProducts = products
    .GroupBy(p => p.Category)
    .Select(group => new
    {
        Category = group.Key,
        Products = group.ToList()
    });

Console.WriteLine("\nPogrupowane produkty:");
foreach (var group in groupedProducts)
{
    Console.WriteLine($"Kategoria: {group.Category}");
    foreach (var product in group.Products)
    {
        Console.WriteLine($" - {product.Name} - {product.Price}");
    }
}