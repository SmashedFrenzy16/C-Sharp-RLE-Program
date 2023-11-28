// See https://aka.ms/new-console-template for more information


Console.Write("Enter in the string of data you want to compress using RLE: ");
string rawData = Console.ReadLine();


for (int letterNum = 0; letterNum < rawData.Length; letterNum++)
{
    var num = 1;

    while (letterNum < rawData.Length - 1 && rawData[letterNum] == rawData[letterNum + 1])
    {


        num++;

        letterNum++;


    }

    Console.Write($"{num}{rawData[letterNum]}");

}