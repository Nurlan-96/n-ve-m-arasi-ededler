//int counter = 0;

//int numbers(int n, int m)
//{
//    while (n < m)
//    {
//        if (n % 2 != 0)
//        {
//            counter++;
//        }
//     n++;
//    }
//    return counter;
//}
//Console.WriteLine(numbers(1, 10));


int sum = 0;
int SumNumbers(int n, int m)
{
    while (n < m)
    {
        if (n % 2 != 0)
        {
            sum += n;
        }
        n++;
    }
    return sum;
}
       
Console.WriteLine(SumNumbers(1,10));