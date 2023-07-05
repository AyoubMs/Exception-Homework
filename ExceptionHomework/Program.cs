

int[] ages = new int[] { 1, 3, 5, 7, 9 };

try
{
    for (int i = 0; i <= ages.Length; i++)
    {
        Console.WriteLine(ages[i]);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw new Exception("This is a catched exception", ex);
}