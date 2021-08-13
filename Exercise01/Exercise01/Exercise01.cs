using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class exercise01
    {
        static double enteredNumber = 1000000000000777;

       // string response = AmountInWords(enteredNumber);

        public static bool IsNumeric(object enteredNumber)
        {
            double retNum;
            bool isParamenteredaNumber = Double.TryParse(Convert.ToString(enteredNumber), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isParamenteredaNumber;
        }
        /*
        public static string AmountInWords(double enteredNumber) // double with take care of both BigInteger and int 
        {
            try
            {
                bool isParamenteredaNumber = IsNumeric(enteredNumber);

                if (isParamenteredaNumber == false)
                {
                    return "Parameter Entered Is Not Valid";
                }
                else
                {
                    var n = (double)enteredNumber;

                    if (n == 0)
                        return "";
                    else if (n > 0 && n <= 19)
                    {
                        var arr = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", 
                            "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                        return arr[Convert.ToInt32(n) - 1] + " ";
                    }
                    else if (n >= 20 && n <= 99)
                    {
                        var arr = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                        return arr[Convert.ToInt32(n) / 10 - 2] + " " + AmountInWords(n % 10);
                    }
                    else if (n >= 100 && n <= 199)
                    {
                        return "One Hundred " + AmountInWords(n % 100);
                    }
                    else if (n >= 200 && n <= 999)
                    {
                        return AmountInWords(n / 100) + "Hundred, " + AmountInWords(n % 100);
                    }
                    else if (n >= 1000 && n <= 1999)
                    {
                        return "One Thousand " + AmountInWords(n % 1000);
                    }
                    else if (n >= 2000 && n <= 999999)
                    {
                        return AmountInWords(n / 1000) + "Thousand, " + AmountInWords(n % 1000);
                    }
                    else if (n >= 1000000 && n <= 1999999)
                    {
                        return "One Million " + AmountInWords(n % 1000000);
                    }
                    else if (n >= 1000000 && n <= 999999999)
                    {
                        return AmountInWords(n / 1000000) + "Million, " + AmountInWords(n % 1000000);
                    }
                    else if (n >= 1000000000 && n <= 1999999999)
                    {
                        return "One Billion " + AmountInWords(n % 1000000000);
                    }
                    else if (n >= 1000000000 && n <= 999999999)
                    {
                        return AmountInWords(n / 1000000000) + "Billion, " + AmountInWords(n % 1000000000);
                    }

                    else if (n >= 1000000000000 && n <= 1999999999999)
                    {
                        return "One Trillion " + AmountInWords(n % 1000000000000);
                    }
                    else if (n >= 1000000000000 && n <= 999999999999)
                    {
                        return AmountInWords(n / 1000000000000) + "Trillion " + AmountInWords(n % 1000000000000);
                    }

                    else if (n >= 1000000000000000 && n <= 1999999999999999)
                    {
                        return "One Quadrillion " + AmountInWords(n % 1000000000000000);
                    }
                    else// if (n >= 1000000000000000 && n <= 999999999999999)
                    {
                        return AmountInWords(n / 1000000000000000) + "Quadrillion " + AmountInWords(n % 1000000000000000);
                    }

                    //else if (n >= 1000000000000000000 && n <= 1999999999999999999)
                    //{
                    //    return "One Quintillion " + AmountInWords(n % 1000000000000000000);
                    //}
                    //else 
                    //{
                    //    return AmountInWords(n / 1000000000000000000) + "Quintillion " + AmountInWords(n % 1000000000000000000);
                    //} 

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        */
        public static string Rapper(double n)
        {
            string words = "";
            double intPart;
            double decPart = 0;

            try
            {
                bool isParamenteredaNumber = IsNumeric(enteredNumber);

                if (isParamenteredaNumber == false)
                {
                    return "Parameter Entered Is Not Valid";
                }
                else
                {

                    if (n == 0)
                        return "zero";
                    try
                    {
                        string[] splitter = n.ToString().Split('.');
                        intPart = double.Parse(splitter[0]);
                        decPart = double.Parse(splitter[1]);
                    }
                    catch
                    {
                        intPart = n;
                    }

                    words = NumWords(intPart);

                    if (decPart > 0)
                    {
                        if (words != "")
                            words += " and ";
                        int counter = decPart.ToString().Length;
                        switch (counter)
                        {
                            case 1: words += NumWords(decPart) + " tenths"; break;
                            case 2: words += NumWords(decPart) + " hundredths"; break;
                            case 3: words += NumWords(decPart) + " thousandths"; break;
                            case 4: words += NumWords(decPart) + " ten-thousandths"; break;
                            case 5: words += NumWords(decPart) + " hundred-thousandths"; break;
                            case 6: words += NumWords(decPart) + " millionths"; break;
                            case 7: words += NumWords(decPart) + " ten-millionths"; break;
                            case 8: words += NumWords(decPart) + " hundred-millionths"; break;
                            case 9: words += NumWords(decPart) + " billionths"; break;
                            case 10: words += NumWords(decPart) + " ten-billionths"; break;
                            case 11: words += NumWords(decPart) + " hundred-billionths"; break;
                            case 12: words += NumWords(decPart) + " trillionths"; break;
                            case 13: words += NumWords(decPart) + " ten-trillionths"; break;
                            case 14: words += NumWords(decPart) + " hundred-trillionths"; break;
                            case 15: words += NumWords(decPart) + " Quadrillionths"; break;
                            case 16: words += NumWords(decPart) + " ten-Quadrillionths"; break;
                            case 17: words += NumWords(decPart) + " hundred-Quadrillionths"; break;
                            case 18: words += NumWords(decPart) + " Quintillionths"; break;
                            case 19: words += NumWords(decPart) + " ten-Quintillionths"; break;
                            case 20: words += NumWords(decPart) + " hundred-Quintillionths"; break;
                        }
                    }
                }
                return words;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string NumWords(double enteredNumber) 
        {
            string[] numbersArr = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensArr = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            string[] suffixesArr = new string[] { "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion", "Sextillion", "Septillion", "Octillion", "Nonillion", "Decillion", "Undecillion", "Duodecillion", "Tredecillion", "Quattuordecillion", 
                "Quindecillion", "Sexdecillion", "Septdecillion", "Octodecillion", "Novemdecillion", "Vigintillion" };
            string words = "";

            bool tens = false;
            try
            {
                if (enteredNumber < 0)
                {
                    words += "negative ";
                    enteredNumber *= -1;
                }

                int power = (suffixesArr.Length + 1) * 3;

                while (power > 3)
                {
                    double pow = Math.Pow(10, power);
                    if (enteredNumber >= pow)
                    {
                        if (enteredNumber % pow > 0)
                        {
                            words += NumWords(Math.Floor(enteredNumber / pow)) + " " + suffixesArr[(power / 3) - 1] + ", ";
                        }
                        else if (enteredNumber % pow == 0)
                        {
                            words += NumWords(Math.Floor(enteredNumber / pow)) + " " + suffixesArr[(power / 3) - 1];
                        }
                        enteredNumber %= pow;
                    }
                    power -= 3;
                }
                if (enteredNumber >= 1000)
                {
                    if (enteredNumber % 1000 > 0) words += NumWords(Math.Floor(enteredNumber / 1000)) + " Thousand, ";
                    else words += NumWords(Math.Floor(enteredNumber / 1000)) + " Thousand";
                    enteredNumber %= 1000;
                }
                if (0 <= enteredNumber && enteredNumber <= 999)
                {
                    if ((int)enteredNumber / 100 > 0)
                    {
                        words += NumWords(Math.Floor(enteredNumber / 100)) + " Hundred";
                        enteredNumber %= 100;
                    }
                    if ((int)enteredNumber / 10 > 1)
                    {
                        if (words != "")
                            words += " ";
                        words += tensArr[(int)enteredNumber / 10 - 2];
                        tens = true;
                        enteredNumber %= 10;
                    }

                    if (enteredNumber < 20 && enteredNumber > 0)
                    {
                        if (words != "" && tens == false)
                            words += " ";
                        words += (tens ? "-" + numbersArr[(int)enteredNumber - 1] : numbersArr[(int)enteredNumber - 1]);
                        enteredNumber -= Math.Floor(enteredNumber);
                    }
                }
                return words;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}