// See https://aka.ms/new-console-template for more information

class Program
    {	    {


        private static List<int> _list = new List<int>();	        private static List<int> _list = new List<int>();

        private static object _sync = new object();	        private static object _sync = new object();


        static void Main(string[] args)	        static void Main(string[] args)
@@ -20,47 +21,82 @@ static void Main(string[] args)


            // Test3();	            // Test3();



            //
            // var1	            // // var1
            lock (_sync)	            // lock (_sync)
            {	            // {
                Console.WriteLine("lock");	            //     Console.WriteLine("lock");
            }	            // }
            //
            // // var2
            // try
            // {
            //     
            //     Monitor.Enter(_sync);
            //     
            //     // if(!Monitor.TryEnter(_sync, TimeSpan.FromMilliseconds(100)))
            //     //     throw new TimeoutException("Timeout");
            //     
            //     // critical section
            //     
            //     Console.WriteLine("lock");
            // }
            // finally
            // {
            //     Monitor.Exit(_sync);
            // }
            //
            //
            // Thread t1 = new Thread(ReadDelegate){Name = "Reader1"};
            // Thread t3 = new Thread(ReadDelegate){Name = "Reader2"};
            // Thread t4 = new Thread(ReadDelegate){Name = "Reader3"};
            //
            // Thread writeThread = new Thread(WriteDelegate){Name = "Writer"};
            //
            // t1.Start();
            // t3.Start();
            // t4.Start();
            //
            // writeThread.Start();



            // var2	            DeadLock();
            try	

            Console.ReadLine();
        }

        private static void DeadLock()
        {
            object o1 = new object();
            object o2 = new object();

            Thread th1 = new Thread(() =>
            {	            {

                lock (o1) // 1
                Monitor.Enter(_sync);	                {

                    lock (o2) // 2
                // if(!Monitor.TryEnter(_sync, TimeSpan.FromMilliseconds(100)))	                    {
                //     throw new TimeoutException("Timeout");	                        

                    }
                // critical section	                }

            });
                Console.WriteLine("lock");	
            }	            Thread th2 = new Thread(() =>
            finally	
            {	            {
                Monitor.Exit(_sync);	                lock (o2) // 1
            }	                {

                    lock (o1) // 2

                    {

                        
                    }
                }
            });


            Thread t1 = new Thread(ReadDelegate){Name = "Reader1"};	
            Thread t3 = new Thread(ReadDelegate){Name = "Reader2"};	            th1.Start();
            Thread t4 = new Thread(ReadDelegate){Name = "Reader3"};	

            Thread writeThread = new Thread(WriteDelegate){Name = "Writer"};	

            t1.Start();	
            t3.Start();	
            t4.Start();	

            writeThread.Start();	


            th2.Start();
        }	        


        private static void ReadDelegate()
        {	        
            while (true)
            {	            
                //var copy = _list.ToList();
                lock (_sync)
                {	                
                    foreach (var item in _list)
                    {	                    
                        Console.Write(item);
                    }	                    
                }	                
                	                
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
            }	            
        }	        
        private static void WriteDelegate()
        {	        
            while (true)
            {	            
                int h = 0;
                	                
                lock (_sync)
                {	                
                    _list.Add(1);
                }	                
                	                
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
            }	            
        }	        
        	        
        	        
        private static void TestDelagate()
        {	        
            for (int i = 0; i < 100; i++)
            {	            
                lock (_sync)
                {	                
                    _list.Add(i);
                    _list.Remove(i);
                }	                
            }	            
        }	        
        private static void Test3()
        {	        {
            var figures = new List<Cube>();
            foreach (var i in Enumerable.Range(1, 100))
            {	            
                figures.Add(new Cube(i, i));
            }	            
            // TODO: распараллель это! долго считает
            // var sum = figures
            //     .Select(x => x.Volume)
            //     .Sum();
            double summ1 = 0;
            double summ2 = 0;
            bool finished1 = false;
            bool finished2 = false;
            AutoResetEvent flag1 = new AutoResetEvent(false);
            AutoResetEvent flag2 = new AutoResetEvent(false);
            Console.WriteLine(Environment.ProcessorCount);
            var thread1 = new Thread(o =>
            {	            
                summ1 = figures
                    .Take(figures.Count / 2)
                    .Select(x => x.Volume)
                    .Sum();
                //finished1 = true;
                flag1.Set();
            });	       
            var thread2 = new Thread(o =>	     
            {	            
                summ2 = figures	              
                    .TakeLast(figures.Count / 2)	 
                    .Select(x => x.Volume)	
                    .Sum();
                // finished2 = true;	                // finished2 = true;
                flag2.Set();
            });
            thread1.Start();	
            thread2.Start();	         
            if (WaitHandle.WaitAll(new[] { flag1, flag2 }, TimeSpan.FromSeconds(1)))
            {	            
                Console.WriteLine($"Result: {summ1 + summ2}");	              
            }	            
            else	           
            {	            
                Console.WriteLine($"Не удалось произвести расчеты.");	
            }	            
            // while (!finished1 || !finished2)	            // while (!finished1 || !finished2)
            // {	            // {
            //     Thread.Sleep(TimeSpan.FromMilliseconds(10));	            //     Thread.Sleep(TimeSpan.FromMilliseconds(10));
            // }	            // }
            //Thread.Sleep(TimeSpan.FromSeconds(5));	            //Thread.Sleep(TimeSpan.FromSeconds(5));
        }	        
        private static void CreateThreadMethodTwo()	      
        {	        
            ThreadPool.QueueUserWorkItem(state => { Console.WriteLine("pool"); });	 
        }	        
        private static void CreateThreadMethodOne()	       
        {	        
            var threadDelegate = new ThreadStart(DoWork1);	          
            var t1 = new Thread(threadDelegate);	         
            t1.Name = "#1";	        
            t1.Start();	          
            var t2 = new Thread(DoWork2);	 
            t2.Name = "#2";	       
            t2.Start();	         
        }	        
        private static void DoWork1()
        {	        
            Console.WriteLine("start thread 1");	   
        }	        
        	        
        private static void DoWork2(object obj)	    
        {	        
            Console.WriteLine("start thread 2");
        }	        
    }	    
}	
