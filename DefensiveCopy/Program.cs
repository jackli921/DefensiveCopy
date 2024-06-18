// See https://aka.ms/new-console-template for more information
using DefensiveCopy;

// Math competition
string[] a = new []{"Rick", "Sam", "Andre"};

TopThree mathWinners = new TopThree(a, true);
Console.WriteLine($"Math Competition Winners: {string.Join(", ", mathWinners.DisplayWinners())}");
Console.WriteLine("");

// Art competition
a[0] = "Brett";
a[1] = "Graham";
a[2] = "Nick";

TopThree artWinners = new TopThree(a, false);
Console.WriteLine($"Art Competition Winners: {string.Join(", ", artWinners.DisplayWinners())}");
Console.WriteLine("");

Console.WriteLine($"Math Competition Winners (After argument object was modified): {string.Join(", ", mathWinners.DisplayWinners())}");
Console.WriteLine("");

string[] myWinners = mathWinners.DisplayWinners(); // returning an new memory address 

myWinners[0] = "Hacker 1"; // modifying data in the new memory location; doesn't affect mathWinner's data
myWinners[1] = "Hacker 2"; // modifying data in the new memory location; doesn't affect mathWinner's data
myWinners[2] = "Hacker 3"; // modifying data in the new memory location; doesn't affect mathWinner's data

Console.WriteLine(string.Join(",", myWinners)); 
Console.WriteLine("");

Console.WriteLine($"Math Competition Winners (After returning a copy of winners): {string.Join(", ", mathWinners.DisplayWinners())}");
