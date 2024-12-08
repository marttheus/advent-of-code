using System;
using System.IO;
using AdventOfCode;

var dayOneFile = "dayOneInput.txt";
var dayOneInput = File.ReadAllLines(dayOneFile);
var dayOnePartOneResponse = DayOnePartOne.GetResponse(dayOneInput);
Console.WriteLine($"AoC Day One Part 1 Response: {dayOnePartOneResponse}");

var dayOnePartTwoResponse = DayOnePartTwo.GetResponse(dayOneInput);
Console.WriteLine($"AoC Day One Part 2 Response: {dayOnePartTwoResponse}");

var dayTwoFile = "dayTwoInput.txt";
var dayTwoInput = File.ReadAllLines(dayTwoFile);
var dayTwoResponse = DayTwo.GetResponse(dayTwoInput);
Console.WriteLine($"AoC Day Two Response: {dayTwoResponse}");

Console.WriteLine();

var dayOneTestFile = "dayOneTestInput.txt";
var dayOneTestInput = File.ReadAllLines(dayOneTestFile);
var dayOnePartOneTestResponse = DayOnePartOne.GetResponse(dayOneTestInput);
Console.WriteLine($"AoC Day One Part 1 Test Response: {dayOnePartOneTestResponse}");

var dayOnePartTwoTestResponse = DayOnePartTwo.GetResponse(dayOneTestInput);
Console.WriteLine($"AoC Day One Part 2 Test Response: {dayOnePartTwoTestResponse}");

var dayTwoTestFile = "dayTwoTestInput.txt";
var dayTwoTestInput = File.ReadAllLines(dayTwoTestFile);
var dayTwoTestResponse = DayTwo.GetResponse(dayTwoTestInput);
Console.WriteLine($"AoC Day Two Test Response: {dayTwoTestResponse}");