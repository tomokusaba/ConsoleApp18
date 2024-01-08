try
{
    string[] d = args[0].Split('-');
    Console.WriteLine(new DateOnly(int.Parse(d[2]), int.Parse(d[0]), int.Parse(d[1])).ToString("yyyy/MM/dd"));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}