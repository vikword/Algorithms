// // See https://aka.ms/new-console-template for more information
//
// var array = new[] { 1, 5, 2, 0, 3, 8, 6, 10, 0, 4 };
// Console.Write("[");
// foreach (var t in array)
// {
//     Console.Write($"{t}, ");
// }
// Console.Write("]");
//
// var cout1 = 0;
// var cout2 = 0;
// for (var i = 0; i < array.Length; i++)
// {
//     for (var j = i; j < array.Length; j++)
//     {
//         if (array[j] == 0 && j < array.Length - 1)
//         {
//             array[j] = array[j + 1];
//             array[j + 1] = 0;
//         }
//
//         cout2++;
//     }
//
//     cout1++;
// }
//
// Console.Write("[");
// foreach (var t in array)
// {
//     Console.Write($"{t}, ");
// }
// Console.Write($"] количество итераций: {cout1 + cout2}");

using System;

var nums = new[] { 1, 5, 2, 0, 3, 8, 6, 10, 0, 4 };
Console.Write("[");
foreach (var t in nums)
{
    Console.Write($"{t}, ");
}
Console.Write("]");
var lastNonZeroFoundAt = 0;
var count = 0;
for (var i = 0; i < nums.Length; i++) {
    if (nums[i] != 0) {
        nums[lastNonZeroFoundAt++] = nums[i];
    }

    count++;
}

for (var i = lastNonZeroFoundAt; i < nums.Length; i++) {
    nums[i] = 0;
    count++;
}
Console.Write("[");
foreach (var t in nums)
{
    Console.Write($"{t}, ");
}
Console.Write($"] количество итераций: {count}");