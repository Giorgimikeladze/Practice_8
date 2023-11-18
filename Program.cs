
Console.Write("Enter an integer value: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int numb);

if (isParsed && numb >= 1)
{
    var binaryList = new List<int>();

    while (numb > 0)
    {
        binaryList.Add(numb % 2);
        numb /= 2;
    }

    Console.Write("Binary representation: ");
    for (int i = binaryList.Count - 1; i >= 0; i--)
    {
        Console.Write(binaryList[i]);
    }
}
else
{
    Console.WriteLine("Invalid value! Please enter a positive integer.");
}