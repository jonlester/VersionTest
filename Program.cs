// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Reflection;

Console.WriteLine("Hello, World!");
var assembly = Assembly.GetExecutingAssembly();
var assemblyName = assembly.GetName().Name;
var gitVersionInformationType = assembly.GetType("GitVersionInformation");
var fields = gitVersionInformationType.GetFields();

foreach (var field in fields)
{
    Trace.WriteLine(string.Format("{0}: {1}", field.Name, field.GetValue(null)));
}

// The GitVersionInformation class generated from a F# project exposes properties
var properties = gitVersionInformationType.GetProperties();

foreach (var property in properties)
{
    Trace.WriteLine(string.Format("{0}: {1}", property.Name, property.GetGetMethod(true).Invoke(null, null)));
}
