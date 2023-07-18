using System;

namespace puzzle
{
    class Program
    {
        static public int Num = 9;
        static public int Dir = 4;
        static public int[] put_index = new int[9];
        static public bool[] state = new bool[9]; //沒用過就會是true
        static public int[,] Ans = new int[50,9];
        static public int ans_index = 0;
        //static public int pointer = -1;


        static void Main(string[] args)
        {
            int[,] data = new int[Num, Dir];
            for (int i = 0; i < Num; i++)
            {
                Console.WriteLine("Input num " + (i));
                for (int j = 0; j < Dir; j++)
                {
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                put_index[i] = -1;
                state[i] = true;
            }
            for (int now = 0; now < Num; now++)
            {
                count(data, 0,now);
            }

        }
        static void count(int[,] data, int pointer, int now)
        {
            
            put_index[pointer] = now;
            //Console.WriteLine("put_index: ");
            //for (int i = 0; i < Num; i++)
            //{
            //    Console.Write(put_index[i] + " ");
            //}
            state[now] = false;
            for (int i = 0; i < Num; i++)
            {

                if (state[i])
                {
                    switch (pointer)
                    {
                        case 0:
                            //Console.WriteLine("pointer = 0");
                            if (data[now, 1] + data[i, 3] == 0)
                            {
                                count(data, pointer + 1, i);
                            }
                            break;
                        case 1:
                            //Console.WriteLine("pointer = 1");
                            if (data[now, 1] + data[i, 3] == 0)
                            {
                                count(data, pointer + 1, i);
                            }
                            break;
                        case 2:
                            //Console.WriteLine("pointer = 2");
                            if (data[put_index[0], 2] + data[i, 0] == 0)
                            {
                                count(data, pointer + 1, i);
                            }
                            break;
                        case 3:
                            //Console.WriteLine("pointer = 3");
                            if ((data[now, 1] + data[i, 3] == 0) && (data[put_index[1], 2] + data[i, 0] == 0))
                            {
                                count(data, pointer + 1, i);
                            }
                            break;
                        case 4:
                            //Console.WriteLine("pointer = 4");
                            if ((data[now, 1] + data[i, 3] == 0) && (data[put_index[2], 2] + data[i, 0] == 0))
                            {
                                count(data, pointer + 1, i);
                            }
                            break;
                        case 5:
                            //Console.WriteLine("pointer = 5");
                            if (data[put_index[3], 2] + data[i, 0] == 0)
                            {
                                count(data, pointer + 1, i);
                            }
                            break;
                        case 6:
                            //Console.WriteLine("pointer = 6");
                            if ((data[now, 1] + data[i, 3] == 0) && (data[put_index[4], 2] + data[i, 0] == 0))
                            {
                                count(data, pointer + 1, i);
                            }
                            break;
                        case 7:
                            //Console.WriteLine("pointer = 7");
                            if ((data[now, 1] + data[i, 3] == 0) && (data[put_index[5], 2] + data[i, 0] == 0))
                            {
                                count(data, pointer + 1, i);
                            }
                            break;
                        case 8:
                            //Console.WriteLine("pointer = 8");
                            
                            break;
                    }
                        

                        
                }
                if(pointer == 8)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Ans: ");
                    }
                    Console.Write(put_index[i] + " ");
                    Ans[ans_index, i] = put_index[i];
                    ans_index++;
                    if (i == 8)
                    {
                        Console.WriteLine(".");
                    }
                }
                

            }
            state[now] = true;
        }
        

    }
}
