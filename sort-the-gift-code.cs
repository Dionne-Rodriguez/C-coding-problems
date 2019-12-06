// Santa's senior gift organizer Elf developed a way to represent up to 26 gifts by assigning a unique alphabetical character to each gift. 
// After each gift was assigned a character, the gift organizer Elf then joined the characters to form the gift ordering code.
// Santa asked his organizer to order the characters in alphabetical order,
//  but the Elf fell asleep from consuming too much hot chocolate and candy canes! Can you help him out?
// Sort the Gift Code
// Write a function called sortGiftCode/sort_gift_code/SortGiftCode that accepts a string containing up to 26 unique alphabetical characters,
//  and returns a string containing the same characters in alphabetical order.

// Examples:
// Kata.SortGiftCode("abcdef") => "abcdef"
// Kata.SortGiftCode("pqksuvy") => "kpqsuvy"
// Kata.SortGiftCode("zyxwvutsrqponmlkjihgfedcba") => "abcdefghijklmnopqrstuvwxyz"



// using System;
// using System.Linq;
// using System.Text;

// using static System.Console;

// namespace Code_Wars
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             WriteLine("Hello World!");
//             Kata.SortGiftCode("CBA");
//         }
//     }

//     public static class Kata
//     {
        
//         public static string SortGiftCode(string code){
//             String str = code;
//             char[] chars = str.ToArray();
//             Array.Sort(chars);
//             return new string (chars); 
//     }
// }
// }
 