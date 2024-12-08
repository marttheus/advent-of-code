using System;
using System.IO;
using AdventOfCode;

var dayOneFile = "dayOneInput.txt";
var dayOneInput = File.ReadAllLines(dayOneFile);
var dayOnePartOneResponse = DayOne.GetPartOneResponse(dayOneInput);
Console.WriteLine($"AoC Day One Part 1 Response: {dayOnePartOneResponse}");

var dayOnePartTwoResponse = DayOne.GetPartTwoResponse(dayOneInput);
Console.WriteLine($"AoC Day One Part 2 Response: {dayOnePartTwoResponse}");

var dayTwoFile = "dayTwoInput.txt";
var dayTwoInput = File.ReadAllLines(dayTwoFile);
var dayTwoResponse = DayTwo.GetPartOneResponse(dayTwoInput);
Console.WriteLine($"AoC Day Two Part 1 Response: {dayTwoResponse}");

var dayTwoPartTwoResponse = DayTwo.GetPartTwoResponse(dayTwoInput);
Console.WriteLine($"AoC Day Two Part 2 Response: {dayTwoPartTwoResponse}");

Console.WriteLine();

var dayOneTestFile = "dayOneTestInput.txt";
var dayOneTestInput = File.ReadAllLines(dayOneTestFile);
var dayOnePartOneTestResponse = DayOne.GetPartOneResponse(dayOneTestInput);
Console.WriteLine($"AoC Day One Part 1 Test Response: {dayOnePartOneTestResponse}");

var dayOnePartTwoTestResponse = DayOne.GetPartTwoResponse(dayOneTestInput);
Console.WriteLine($"AoC Day One Part 2 Test Response: {dayOnePartTwoTestResponse}");

var dayTwoTestFile = "dayTwoTestInput.txt";
var dayTwoTestInput = File.ReadAllLines(dayTwoTestFile);
var dayTwoTestResponse = DayTwo.GetPartOneResponse(dayTwoTestInput);
Console.WriteLine($"AoC Day Two Part 1 Test Response: {dayTwoTestResponse}");

var dayTwoPartTwoTestResponse = DayTwo.GetPartTwoResponse(dayTwoTestInput);
Console.WriteLine($"AoC Day Two Part 2 Test Response: {dayTwoPartTwoTestResponse}");