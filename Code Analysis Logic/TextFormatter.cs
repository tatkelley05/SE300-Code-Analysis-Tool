using System;

public class TextFormatter
{
	private string id;
	private string[] inputFile;
	public TextFormatter(string id, string[] inputFile)
	{
		this.inputFile = inputFile;
		this.id = id;

	
	}

    //private string[] removeExtraSpaces(string[] target)
    //{
    //	for
    //}
    private string removeExtraSpacesInString(string input)
    {
        if (string.IsNullOrWhiteSpace(input)){ 
            return string.Empty;
        }
        char[] charArray = input.ToCharArray();
        string output = string.Empty;

        for (int i = 0; i < charArray.Length; i++){
            if (!char.IsWhiteSpace(charArray[i])){
                output += charArray[i];
            } else if (i > 0 && !char.IsWhiteSpace(charArray[i - 1])){
                output += ' ';
            }
        }

        return output.Trim(); // Trim to remove leading/trailing spaces
    }
    private string[] removeExtraSpacesInFile(string[] target)
    {
        string[] spacelessFile = target;

        for (int i = 0; i < target.Length; i++)
        {
            spacelessFile[i] = removeExtraSpacesInString(target[i]);
        }

        return spacelessFile;
    }
    
    //splits array of strings into an array of arrays of strings (each item rather than each line)
    private string[][] cutFile(string[] target)
    {
        string[][] temp = new string[target.Length][];
        for (int i = 0; i < target.Length; ++i)
        {
            temp[i] = target[i].Split(" ");
        }
        return temp;
    }
    public string[][] formatFile()
	{
        string[] modFile = this.inputFile;
        modFile = removeExtraSpacesInFile(modFile);


        string[][] returnFile = cutFile(modFile);
		return returnFile;
	}

}
