using Bogus;
using Sortings;

Console.WriteLine("Hello, World!");

//Using Bogus Faker class to generate fake datas
var faker = new Faker();

//Strings:
var strings = Enumerable.Range(1, 10_000).Select(_ => new string(faker.Random.AlphaNumeric(length: 6))).ToArray();

//Chars:
var chars = faker.Random.Chars('A', 'Z', count: 10_000);

//Ints:
var numbers = Enumerable.Range(1, 100_000).Select(_ => faker.Random.Int(-10_000, 10_000)).ToArray();

//Inicializando Sorting Type:
var orderType = OrderType.Desc;

#region Selection

#region Selection with Strings

Console.WriteLine("Before Selection Sort:");
strings.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ({orderType}): {Selection.IsSorted(strings, orderType)}");

Selection.Sort(strings, orderType);

Console.WriteLine("After Selection Sort:");
strings.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ({orderType}): {Selection.IsSorted(strings, orderType)}");

#endregion

Console.ReadLine();

#region Selection with Chars

Console.WriteLine("Before Selection Sort:");
chars.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ({orderType}): {Selection.IsSorted(chars, orderType)}");

Selection.Sort(chars, orderType);

Console.WriteLine("After Selection Sort:");
chars.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ({orderType}): {Selection.IsSorted(chars, orderType)}");

#endregion

Console.ReadLine();

#region Selection with Ints

Console.WriteLine("Before Selection Sort:");
numbers.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ({orderType}): {Selection.IsSorted(numbers, orderType)}");

Selection.Sort(numbers, orderType);

Console.WriteLine("After Selection Sort:");
numbers.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ({orderType}): {Selection.IsSorted(numbers, orderType)}");

#endregion

Console.ReadLine();

#endregion

#region Bubble

#region Bubble with Strings

Console.WriteLine("Before Bubble Sort:");
strings.ToList().ForEach(Console.WriteLine);

orderType = OrderType.Asc;

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble.IsSorted(strings));

Bubble.Sort(strings);

Console.WriteLine($"After Bubble Sort: \nType: ({orderType})");
strings.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble.IsSorted(strings));

#endregion

Console.ReadLine();

#region Bubble with Chars

Console.WriteLine("Before Bubble Sort:");
chars.ToList().ForEach(Console.WriteLine);

orderType = OrderType.Desc;

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble.IsSorted(chars, orderType));

Bubble.Sort(chars, orderType);

Console.WriteLine($"After Bubble Sort: \nType: ({orderType})");
chars.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble.IsSorted(chars, orderType));

#endregion

Console.ReadLine();

#region Bubble with Ints

Console.WriteLine("Before Bubble Sort:");
numbers.ToList().ForEach(Console.WriteLine);

orderType = OrderType.Desc;

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble.IsSorted(numbers, orderType));

Bubble.Sort(numbers, orderType);

Console.WriteLine($"After Bubble Sort: \nType: ({orderType})");
numbers.ToList().ForEach(Console.WriteLine);

Console.WriteLine($"Is Sorted ? ({orderType})");
Console.WriteLine(Bubble.IsSorted(numbers, orderType));

#endregion

#endregion