﻿// See https://aka.ms/new-console-template for more information
using CS6_Vectors;

Vector2 v = new(2.5, 7);
Vector2 w = new(-2, 3);

//use the + operator defined in Vector2.cs
Vector2 sum = v+w;

Console.WriteLine($"{v} + {w} = {sum}");
Console.WriteLine($"|{v}| = {v.R}");
Console.WriteLine($"|{w}| = {w.R}");
Console.WriteLine($"|{sum}| = {sum.R}");

Console.WriteLine("Done!");
Console.ReadLine();