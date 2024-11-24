using System;
using System.Threading;

public  class DistractorThreads
{
    private const int NumberOfThreads = 10;

    public static void StartDistractingThreads()
    {
        for (int i = 0; i < NumberOfThreads; i++)
        {
            Thread distractorThread = new Thread(PerformDummyCalculations)
            {
                IsBackground = true 
            };
            distractorThread.Start();
        }
    }

    private static void PerformDummyCalculations()
    {
        Random rand = new Random();
        double junkResult = 0;

        while (true)
        {
            try
            {
                int a = rand.Next(1, 1000);
                int b = rand.Next(1, 1000);
                junkResult += Math.Sqrt(a) * Math.Sin(b);
                junkResult -= Math.Log(a) * Math.Cos(b);

                Thread.Sleep(rand.Next(10, 50));
            }
            catch
            {
                
                junkResult = 0;
            }
        }
    }
}
