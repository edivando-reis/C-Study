string[] requests = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };


foreach (string request in requests)
{
    if (request.StartsWith("B"))
    {
        Console.WriteLine(request);
    }
}
