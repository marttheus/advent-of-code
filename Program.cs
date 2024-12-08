using System;
using System.IO;
using AdventOfCode;

var dayOneFile = "dayOneInput.txt";
var dayOneInput = File.ReadAllLines(dayOneFile);
var dayOneResponse = DayOne.GetResponse(dayOneInput);
Console.WriteLine($"AoC Day One Response: {dayOneResponse}");