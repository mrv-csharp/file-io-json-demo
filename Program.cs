// FILE I/O JSON DEMO by Mr. V
// Place code into main()

// Import JSON module
using System.Text.Json;

// JSON stands for JavaScript Object Notation
// It is a notation for representing data
// JSON may be used to convert data to a string and vice versa

// Create a list of objects to turn into JSON
List<Point> data = new List<Point>();
data.Add(new Point("1", "1"));
data.Add(new Point("2", "2"));
data.Add(new Point("3", "3"));

// The Serialize method will convert data to a json string
// To make it work with objects, we need to set the IncludeFields option to true
var options = new JsonSerializerOptions { IncludeFields = true };
string jsonString = JsonSerializer.Serialize(data, options);
Console.WriteLine(jsonString);

// The data as a JSON string may be easily saved to a file
File.WriteAllText(@"F:\__CS\C#\file-io-json-demo\data.txt", jsonString);

// Load JSON string from file
string jsonStringFromFile = File.ReadAllText(@"F:\__CS\C#\file-io-json-demo\data2.txt");
Console.WriteLine(jsonStringFromFile);

// The Deserialize method will convert a json string to data

List<Point>? data2 = JsonSerializer.Deserialize<List<Point>>(jsonStringFromFile, options);
Console.WriteLine(data2);
if (data2 != null) {
    foreach (var point in data2) {
        Console.WriteLine(point);
    }
}


class Point {
    public string x;
    public string y;

    public Point(string x, string y) {
        this.x = x;
        this.y = y;
    }

    public override string ToString() {
        return $"({this.x},{this.y})";
    }
}



