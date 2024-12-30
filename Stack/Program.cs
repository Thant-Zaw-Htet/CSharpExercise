using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 9, 2, 3 };
            int min = numbers[0];
            int max = numbers[0];

            foreach (int num in numbers)
            {
                {
                    if (num < min)
                    {
                        min = num;

                    }
                    if (num > max)
                    {
                        max = num;

                    }
                }
            }

                Console.WriteLine($"min" + min);

                Console.WriteLine($"mxn" + max);

                ////Stack(LIFO)
                //Stack<int> st1 = new Stack<int>(); //Collection.Generic
                //st1.Push(4);
                //st1.Push(2);
                //st1.Push(12);

                //Console.WriteLine("LIFO");
                //foreach (int i in st1)
                //{
                //    Console.WriteLine(i);
                //}

                //Stack st = new Stack();
                //st.Push("Hello");
                //st.Push(12);
                //st.Push(true);
                //st.Push(32); e

                //foreach (int i in st)
                //{
                //    Console.WriteLine(i);

                //}
                //Console.WriteLine();

                //Stack st3 = new Stack(); //Collection


                //Stack<string> st4 = new Stack<string>();
                //Console.WriteLine(st4.DefaultIfEmpty());

                //Queue(FIFO)
                //Queue queue = new Queue();//Collection
                //queue.Enqueue(4);
                //queue.Enqueue("Coffee");
                //queue.Enqueue(true);

                //queue.Dequeue();
                //Console.WriteLine("FIFO");
                //foreach (var i in queue)
                //{
                //    Console.WriteLine(i);
                //}





            }
        }
    }
    
