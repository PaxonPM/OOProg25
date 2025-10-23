
List<int> listOfInt = new List<int>();
listOfInt.Add(4);
listOfInt.Add(12);
listOfInt.Add(9);

// Case 1
// Console.WriteLine($"Case 1: Element with index 1 is {listOfInt[1]}");

// Case 2
// Console.WriteLine($"Case 2: List contains {listOfInt.Count} elements");

listOfInt.Add(5);
listOfInt.Add(22);

// Case 3
// Console.WriteLine($"Case 3: Element with index 3 is {listOfInt[3]}");

listOfInt.RemoveAt(0);

// Case 4
 Console.WriteLine($"Case 4: Element with index 3 is {listOfInt[3]}");



listOfInt.Clear();
listOfInt.Add(14);
listOfInt.Add(87);
listOfInt.Add(62);
listOfInt.Add(21);
listOfInt.Add(40);
listOfInt.Add(3);

// Case 5: Add code that prints out 
// all the elements in the list
foreach (var number in listOfInt)
{
    Console.WriteLine(number);
}



// Case 6: Add code that finds the 
// sum of the elements in the list, and prints the result
int sumOfInts = 0;
foreach (var number in listOfInt)
{
    sumOfInts += number;
}
Console.WriteLine($"case 6: the sum is: {sumOfInts}");


// [DIFFICULT]
// Case 7: Add code that finds the smallest  
// element in the list, and prints the result
// Tip: Think in detail about how you would do this manually
int check = 100;
foreach (var number in listOfInt)
{
    if (number < check)
    check = number;
}
Console.WriteLine($"case 7: the sum is: {check}");


// [(maybe) DIFFICULT]
// Case 8: Add code that sorts the content of the list.
// Tip: Think before you code...

