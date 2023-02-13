using System;

/* selecting from array of strings only shorter then 4 characters */ 
void SelectOnlyThree(ref string[] arrayInput, ref string[] arrayOutput)
{
    int j = 0;
    for (int i = 0; i < arrayInput.Length; i++)
    {
        if(arrayInput[i].Length  < 4)
        {
            arrayOutput[j] = arrayInput[i];
            Array.Resize(ref arrayOutput, arrayOutput.Length + 1);
            j++;
        }
    }

}

void WriteArray(string[] arrayInput)
{
    for (int i = 0; i < arrayInput.Length; i++)
    {
        Console.WriteLine(arrayInput[i]);
    }

}

//string[] arrayInput = new string[1];
string[] arrayOutput = new string[1];
string[] arrayInput = new string[] { "Sun", "Monday", "Tue", "Wednsday", "Thu", "Friday", "Sat" };

SelectOnlyThree(ref arrayInput, ref arrayOutput);
WriteArray(arrayOutput);