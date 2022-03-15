
public class RomanToInt
{

    public static int BasicRomanNumerals(string str)
    {
        int parsedInt = 0;
        var charArr = str.ToCharArray();

        for (int i = 0; i < charArr.Length; i++)
        {
            if (HasNext(charArr, i))
            {
                var firstNr = ParseRegularRomanNumeral(charArr[i]);
                var secondNr = ParseRegularRomanNumeral(charArr[i + 1]);

                if (firstNr >= secondNr)
                {
                    parsedInt += firstNr;
                }
                else
                {
                    parsedInt += (secondNr - firstNr);
                    i++;
                }
            }
            else
            {
                parsedInt += ParseRegularRomanNumeral(charArr[i]);
            }

        }
        return parsedInt;

    }

    private static bool HasNext(char[] arr, int i)
    {

        return arr.Length > i + 1;
    }


    private static int ParseRegularRomanNumeral(char c) =>
        c switch
        {
            'M' => 1000,
            'D' => 500,
            'C' => 100,
            'L' => 50,
            'X' => 10,
            'V' => 5,
            'I' => 1
        };


}

