using System;
using System.IO;
using AdventOfCode;

var dayOneFile = "dayOneInput.txt";
var dayOneInput = File.ReadAllLines(dayOneFile);
var dayOneResponse = DayOnePartOne.GetResponse(dayOneInput);
Console.WriteLine($"AoC Day One Part 1 Response: {dayOneResponse}");

var dayTwoResponse = DayOnePartTwo.GetResponse(dayOneInput);
Console.WriteLine($"AoC Day One Part 2 Response: {dayTwoResponse}");

Console.WriteLine();

var dayOneTestFile = "testInput.txt";
var dayOneTestInput = File.ReadAllLines(dayOneTestFile);
var dayOneTestResponse = DayOnePartOne.GetResponse(dayOneTestInput);
Console.WriteLine($"AoC Day One Part 1 Test Response: {dayOneTestResponse}");

var dayTwoTestResponse = DayOnePartTwo.GetResponse(dayOneTestInput);
Console.WriteLine($"AoC Day One Part 2 Test Response: {dayTwoTestResponse}");