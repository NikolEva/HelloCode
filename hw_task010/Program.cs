﻿// программа, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа. 
// например: 456 -> 5  782 -> 8   918 -> 1

int num = new Random().Next(100, 1000);
int b = num/100;
int c = num%10;
int a = (num - b*100 - c)/10;
Console.WriteLine(num + " -> " + a);