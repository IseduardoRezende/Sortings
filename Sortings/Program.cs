using Bogus;
using Sortings;

//Any Bubble =)

Console.WriteLine("Hello, World!");

//Using Bogus Faker class to generate fake datas
var faker = new Faker();

//Chars:
var chars = faker.Random.Chars('A', 'Z', count: 10);

//Ints:
var numbers = Enumerable.Range(1, 10).Select(_ => faker.Random.Int(-100, 100)).ToArray();

//Strings:
var strings = Enumerable.Range(1, 10).Select(_ => new string(faker.Random.AlphaNumeric(length: 5))).ToArray();

//Inicializando Sorting Type:
var orderType = OrderType.Asc;

#region Bubble with Strings

Console.WriteLine("Before Bubble Sort:");
strings.ToList().ForEach(Console.WriteLine);

orderType = OrderType.Desc;

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble<string>.IsSorted(strings, orderType));

Bubble<string>.Sort(strings, orderType);

Console.WriteLine($"After Bubble Sort: \nType: ({orderType})");
strings.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble<string>.IsSorted(strings, orderType));

#endregion

Console.ReadLine();

#region Bubble with Chars

Console.WriteLine("Before Bubble Sort:");
chars.ToList().ForEach(Console.WriteLine);

orderType = OrderType.Asc;

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble<char>.IsSorted(chars));

Bubble<char>.Sort(chars);

Console.WriteLine($"After Bubble Sort: \nType: ({orderType})");
chars.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble<char>.IsSorted(chars));

#endregion

Console.ReadLine();

#region Bubble with Ints

Console.WriteLine("Before Bubble Sort:");
numbers.ToList().ForEach(Console.WriteLine);

orderType = OrderType.Desc;

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble<int>.IsSorted(numbers, orderType));

Bubble<int>.Sort(numbers, orderType);

Console.WriteLine($"After Bubble Sort: \nType: ({orderType})");
numbers.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble<int>.IsSorted(numbers, orderType));

#endregion