using System.Reflection;

var intType = typeof(int);

// Console.WriteLine(intType);

MethodInfo[] methods = intType.GetMethods();

foreach(MethodInfo info in methods)
{
    // Console.WriteLine(info);
}

Type arrayType = typeof(Array);
PropertyInfo[] props = arrayType.GetProperties();

foreach(PropertyInfo prop in props)
{
    Console.WriteLine(prop);
}