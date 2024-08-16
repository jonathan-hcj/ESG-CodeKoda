using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ESG_CodeKoda
{
    public class StringCalculator
    {
        /* Step 9 */
        public static int Add(string numberList)
        {
            var result = 0;
            var separators = new HashSet<string>() { ",", "\n" };
            var firstEOL = numberList.IndexOf('\n');
            var negativesList = new HashSet<int>();

            /* additional separators ? */
            if (numberList.StartsWith("//") && firstEOL != -1)
            {
                var pattern = "(?<=\\[)[^][]*(?=])";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                var matches = regex.Matches(numberList[2..firstEOL]);

                /* add any additional separators to the list and jump past the 1st line, if somehow there are empty separators, ignore them */
                separators.UnionWith(matches.AsEnumerable().Where(x => !string.IsNullOrWhiteSpace(x.Value)).Select((y) => y.Value));
                numberList = numberList[(firstEOL + 1)..];
            }

            /* separators can be multiple charactors, split it and get rid of any empty strings */
            var numberBlock = numberList.Split(separators.ToArray(),StringSplitOptions.TrimEntries);
            var numberBlockFiltered = numberBlock.Where(x => !string.IsNullOrWhiteSpace(x));

            foreach (var number in numberBlockFiltered)
            {
                if (Int32.TryParse(number, out int intNumber))
                {
                    /* negatives need to be listed in the exception */
                    if (intNumber < 0)
                    {
                        negativesList.Add(intNumber);
                    }
                    /* ignore numbers over 1000 */
                    else if (intNumber <= 1000)
                    {
                        result += intNumber;
                    }
                }
            }

            if (negativesList.Count > 0)
            {
                throw new Exception($"Negatives not allowed: {string.Join(",", negativesList)}");
            }

            return result;
        }


        /* Step 6 */
        //public static int Add(string numberList)
        //{
        //    var result = 0;
        //    var separators = new HashSet<char>() { ',', '\n' };
        //    var firstEOL = numberList.IndexOf('\n');
        //    var negativesList = new HashSet<int>();

        //    if (numberList.StartsWith("//") && firstEOL != -1)
        //    {
        //        separators.Add(numberList[2]);
        //        numberList = numberList[(firstEOL + 1)..];
        //    }

        //    var numberBlock = numberList.Split([.. separators]);

        //    foreach (var number in numberBlock)
        //    {
        //        if (Int32.TryParse(number, out int intNumber))
        //        {
        //            if (intNumber < 0)
        //            {
        //                negativesList.Add(intNumber);
        //            }
        //            else if(intNumber <= 1000)
        //            {
        //                result += intNumber;
        //            }
        //        }
        //    }

        //    if (negativesList.Count > 0)
        //    {
        //        throw new Exception($"Negatives not allowed: {string.Join(",", negativesList)}");
        //    }

        //    return result;
        //}

        /* Step 5 */
        //public static int Add(string numberList)
        //{
        //    var result = 0;
        //    var separators = new HashSet<char>() { ',', '\n' };
        //    var firstEOL = numberList.IndexOf('\n');
        //    var negativesList = new HashSet<int>();

        //    if (numberList.StartsWith("//") && firstEOL != -1)
        //    {
        //        separators.Add(numberList[2]);
        //        numberList = numberList[(firstEOL + 1)..];
        //    }

        //    var numberBlock = numberList.Split([.. separators]);

        //    foreach (var number in numberBlock)
        //    {
        //        if (Int32.TryParse(number, out int intNumber))
        //        {
        //            if (intNumber < 0)
        //            {
        //                negativesList.Add(intNumber);
        //            }
        //            else
        //            { 
        //                result += intNumber;                    
        //            }
        //        }
        //    }

        //    if (negativesList.Count > 0)
        //    {
        //        throw new Exception($"Negatives not allowed: {string.Join(",", negativesList)}");
        //    }

        //    return result;
        //}

        /* Step 4 - This was as far as I got on my 1st attempt */
        //public static int Add(string numberList)
        //{
        //    var result = 0;
        //    var separators = new HashSet<char>() { ',', '\n' };
        //    var firstEOL = numberList.IndexOf('\n');
 
        //    if (numberList.StartsWith("//") && firstEOL != -1)
        //    {
        //        separators.Add(numberList[2]);
        //        numberList = numberList[(firstEOL+1)..];
        //    }

        //    var numberBlock = numberList.Split([.. separators]);

        //    foreach (var number in numberBlock)
        //    {
        //        if (Int32.TryParse(number, out int intNumber))
        //        {
        //            result += intNumber;
        //        }
        //    }

        //    return result;
        //}

        /* Step 3 */
        //public static int Add(string numberList)
        //{
        //    var separators = new List<char>() { ',', '\n' };
        //    var result = 0;
        //    var numberBlock = numberList.Split([.. separators]);

        //    foreach (var number in numberBlock)
        //    {
        //        if (Int32.TryParse(number, out int intNumber))
        //        {
        //            result += intNumber;
        //        }
        //    }

        //    return result;
        //}

        /* Step 2 */
        //public static int Add(string numberList)
        //{
        //    int result = 0;
        //    var numberBlock = numberList.Split(',');

        //    foreach (var number in numberBlock)
        //    {
        //        if (Int32.TryParse(number, out int intNumber))
        //        {
        //            result += intNumber;
        //        }
        //    }

        //    return result;
        //}

        /* Step 1 */
        //public static int Add(string numberList)
        //{
        //    int result = 0;
        //    var numberBlock = numberList.Split(',');

        //    if (numberBlock.Length <= 2)
        //    {
        //        foreach (var number in numberBlock)
        //        {
        //            if (Int32.TryParse(number, out int intNumber))
        //            {
        //                result += intNumber;
        //            }
        //        }
        //    }
        //    return result;
        //}
    }
}
