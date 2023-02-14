/* selecting from array of strings only shorter then 4 characters */
void SelectOnlyThree(ref string[] arrayInput, ref string[] arrayOutput)
{
    int j = 0;
    foreach (string i in arrayInput)
    {
        if (i.Length < 4)
        {
            arrayOutput[j] = i;
            Array.Resize(ref arrayOutput, arrayOutput.Length + 1);
            j++;
        }
    }
    Array.Resize(ref arrayOutput, arrayOutput.Length - 1);
}

void WriteArray(string[] arrayInput)
{
    foreach (string i in arrayInput) Console.WriteLine(i);
}

string[] arrayInput = new string[1];
string[] arrayOutput = new string[1];

Console.Clear();
Console.WriteLine("Input some strings. For stop input empty string (press 'Enter' twice).");

int k = 0;
while (true)
{
    string? inString = Console.ReadLine();
    if (string.IsNullOrEmpty(inString)) break;
    arrayInput[k] = inString;
    Array.Resize(ref arrayInput, arrayInput.Length + 1);
    k++;
}
Array.Resize(ref arrayInput, arrayInput.Length - 1);

WriteArray(arrayInput);
SelectOnlyThree(ref arrayInput, ref arrayOutput);
if (arrayOutput.Length > 0) 
{
Console.WriteLine("\nThese strings are shorter than 4 characters:");
WriteArray(arrayOutput);
}
else Console.WriteLine("\nSorry. No strings are shorter than 4 characters.");