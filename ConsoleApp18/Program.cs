try
{
    string[] d = args[0].Split('-');
    Console.WriteLine(new DateOnly(Int32.Parse(d[2]), Int32.Parse(d[0]), int.Parse(d[1])).ToString("yyyy/MM/dd"));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}