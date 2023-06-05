﻿using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

 namespace TestTasks
 {
     class Program
     {
         private static object _sync = new object();

         private static CancellationTokenSource _cancellationTokenSource;

         static void Main(string[] args)
         {
             // 1st var
             // var task = new Task(PrintTimeAction);
             // task.Start();

             // 2nd var
             //var task = Task.Factory.StartNew(PrintTimeAction); // task1
             //Task.Factory.StartNew(PrintRandomNumber); // task2


             // 3d var
             //var task = Task.Run(PrintRandomNumber);

             // 4th var
             //Parallel.Invoke(PrintRandomNumber, PrintTimeAction);


             // var task = new Task<int>(Calc);
             // task.Start();
             // Console.WriteLine($"task result is {task.Result}");



             // Parallel.Invoke(LongWork);

             // Task.Factory.StartNew(LongWork);

             // var time = Stopwatch.StartNew();
             //
             // var r1 = Task.Factory.StartNew(LongWork1).Result;
             // var r2 = Task.Factory.StartNew(LongWork2).Result;
             //
             // time.Stop();
             //
             // Console.WriteLine($"RESULT is {r1+r2}. TIME is {time.ElapsedMilliseconds}ms");



             var time = Stopwatch.StartNew();


             _cancellationTokenSource = new CancellationTokenSource();


             var parent = Task.Factory.StartNew(() =>
             {
                 Console.WriteLine("Parent task executing.");
                 var child = Task.Factory.StartNew(() =>
                 {
                     Console.WriteLine("Attached child starting.");
                     Thread.SpinWait(5000000);
                     Console.WriteLine("Attached child completing.");
                 }, TaskCreationOptions.AttachedToParent);
             });

             parent.Wait();

             Console.WriteLine("Parent has completed.");

             return;

             try
             {

                 var task1 = Task.Factory.StartNew(LongWork1, _cancellationTokenSource.Token);

                 var task2 = Task.Factory.StartNew(LongWork2, _cancellationTokenSource.Token);


                 Task.Factory.ContinueWhenAny(new[] { task1, task2 }, tasks =>
                 {
                     Task.Delay(1000); // analog Thread.Sleep(1000)

                     var taskChild = new Task(() => { });
                     taskChild.Start();

                     Console.WriteLine(
                         $"RESULT is {task1.Result + task2.Result}. TIME is {time.ElapsedMilliseconds}ms");
                 });


                 //Task.WaitAll(task1, task2);

                 //     var tasks = new Task<int>[2] { task1, task2 };
                 //
                 //     int finishedTaskIndex = Task.(tasks);
                 //
                 //    // _cancellationTokenSource.Cancel();
                 //
                 //     var result = tasks[finishedTaskIndex];
                 //     Console.WriteLine($"Result {result.Result}. Finished task index={finishedTaskIndex}");
                 //     
                 //     time.Stop();
                 //
                 //     Console.WriteLine($"RESULT is {task1.Result + task2.Result}. TIME is {time.ElapsedMilliseconds}ms");
                 // }
             }
             catch (AggregateException exception)
             {

             }

             Console.ReadLine();

             // for (int i = 0; i < tasks.Length; i++)
             // {
             //     if (i != finishedTaskIndex)
             //     {
             //         var task = tasks[i];
             //     }
             // }

             //Console.ReadLine();




             // while (true)
             // {
             //     Console.WriteLine("main thread");
             //     Thread.Sleep(500);
             // }


             return;



             while (true)
             {
                 Console.WriteLine("Enter numbers!");

                 Console.ReadLine();

                 lock (_sync)
                 {
                     int a = Convert.ToInt32(Console.ReadLine());
                     int b = Convert.ToInt32(Console.ReadLine());

                     Console.WriteLine($"SUM is : {CalculateSum(a, b)}");
                 }

             }

             Console.WriteLine("Hello World!");
         }


         private static void PrintRandomNumber()
         {
             while (true)
             {
                 var random = new Random();
                 lock (_sync)
                 {
                     Console.WriteLine($"Random number is {random.Next(10)}");
                 }

                 Thread.Sleep(1000);
             }
         }

         private static void PrintTimeAction()
         {
             while (true)
             {
                 lock (_sync)
                 {
                     Console.WriteLine($"TIME: {DateTime.Now:t}");
                 }

                 Thread.Sleep(3000);
             }
         }

         private static int CalculateSum(int a, int b)
         {
             return a + b;
         }

         private static int Calc()
         {
             return 5 + 4;
         }

         private static int LongWork1()
         {
             Thread.Sleep(2000);
             //throw new DivideByZeroException("zero");

             if (_cancellationTokenSource.IsCancellationRequested)
             {
                 _cancellationTokenSource.Token.ThrowIfCancellationRequested();
             }

             return Calc();
         }

         private static int LongWork2()
         {
             Thread.Sleep(5000);

             if (_cancellationTokenSource.IsCancellationRequested)
             {
                 return -1;
                 _cancellationTokenSource.Token.ThrowIfCancellationRequested();
             }

             Console.WriteLine("FINISHED long work 2");
             return Calc() * Calc() * Calc();
         }
     }
 }