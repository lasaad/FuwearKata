namespace StringParser;

internal class Answer
{
    static internal bool Check(string str)
    {
        var elementFilter = new List<string>() { "()", "[]" };

        //if(string.IsNullOrEmpty(str))
        //    return true;

        //int index = 0;
        //int compteurCrochet = 0;
        //int compteurParenthese = 0;

        //foreach (var c in str)
        //{
        //    switch (c)
        //    {
        //        case '(':
        //            compteurParenthese ++;
        //            break;
        //        case ')':
        //            {
        //                compteurParenthese --;
        //                if (compteurCrochet > compteurParenthese)
        //                    return false;
        //                break;

        //            }
        //        case '[':
        //            compteurCrochet ++;
        //            break;
        //        case ']':
        //            {
        //            compteurCrochet --;
        //                if (compteurParenthese > compteurCrochet)
        //                    return false;
        //                break;

        //            }
        //        default:
        //            break;

        //    }
        //            index++;
        //    if (compteurCrochet < 0 || compteurParenthese < 0)
        //        return false;
        //}

        //if (compteurCrochet == 0 && compteurParenthese == 0)
        //    return true;
        //else
        //    return false;

        if (string.IsNullOrEmpty(str))
            return true;

        while (elementFilter.Any(str.Contains))
        {
            foreach (var item in elementFilter)
            {
                str = str.Replace(item, "");
            }
        }
        if (str.Count() == 0)
            return true;
        else
            return false;
    }
}
