// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.IO;

string createText = "yippee!!" + Environment.NewLine;
File.WriteAllText("outputMe.txt", createText);
