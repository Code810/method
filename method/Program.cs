#region task1
//string result(int num)
//{
//    if (num%7==0 && num%3==0)
//    {
//        return "bolunur";
//    }
//    return "bolunmur";
//}

//Console.WriteLine(result(14));
#endregion
#region task2
//int sum(int n,int m)
//{
//    if (n%2== 0 && m%2==0)
//    {
//        return n + m;
//    }
//    return 0;
//}
#endregion
#region task3
//int coutnum(int n, int m)
//{
//    int count = default;
//    if (n<m)
//  {
//   for (int i = n; i <= m; i++)
//       {
//        if (i %2 != 0)
//             count++;
//       }
//        return count;
//  }
//    return 0;
//}
#endregion
#region task4
int sumnumbers(int n, int m)
{
    int sum = default;
    if (n < m)
    {
        for (int i = n; i <= m; i++)
        {
            if (i%2!=0)
            {
                sum = sum + i;
            }
        }
        return sum;
    }
    return 0;
}
#endregion
//Console.WriteLine(result(14));
//Console.WriteLine(sum(3,8));
//Console.WriteLine(coutnum(11,9));
Console.WriteLine(sumnumbers(9,7));