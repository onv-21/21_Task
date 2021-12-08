int m = Convert.ToInt32(Console.ReadLine()); ;
int n=Convert.ToInt32(Console.ReadLine());
int [,] land = new int[n, m];

Thread gardener1 = new Thread(garden1);
Thread gardener2 = new Thread(garden2);

gardener1.Start();
gardener2.Start();

gardener1.Join();
gardener2.Join();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(land[i, j] + " ");
    }
    Console.WriteLine();
}

 void garden1()
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (land[i, j] == 0)
                land[i, j] = 1;
            Thread.Sleep(1);
        }
    }
}

 void garden2()
{
    for (int i = m - 1; i > 0; i--)
    {
        for (int j = n - 1; j > 0; j--)
        {
            if (land[j, i] == 0)
                land[j, i] = 2;
            Thread.Sleep(1);
        }
    }
}
