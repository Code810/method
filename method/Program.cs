#region task1
string result(int num)
{
    if (num%7==0 && num%3==0)
    {
        return "bolunur";
    }
    return "bolunmur";
}

Console.WriteLine(result(14));
#endregion