using System;

namespace puzzle
{
    class Program
    {
        static public int Num = 9;
        static public int Dir = 4;
        static public int[] put_index = new int[9];//0~8
        static public int[] put_dir = new int[9];//0~3 應該是逆時針轉
        static public bool[] state = new bool[9]; //沒用過就會是true
        static public int[,] Ans_index = new int[60,10];
        static public int[,] Ans_dir = new int[60, 10];
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
                put_dir[i] = 0;
                state[i] = true;
            }
            for (int now = 0; now < Num; now++)
            {
                for(int dir =0;dir<Dir;dir++)
                {
                    count(data, 0, now, dir);
                }
                
            }

        }
        static void count(int[,] data, int pointer, int now, int dir)
        {
            
            put_index[pointer] = now;
            put_dir[pointer] = dir;
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
                    for (int j = 0; j < Dir; j++)
                    {
                        switch (pointer)
                        {
                            case 0:
                                //Console.WriteLine("pointer = 0");
                                if (data[now, (1 + dir) %4] + data[i, (3 + j)% 4] == 0)
                                {
                                    count(data, pointer + 1, i, j);
                                }
                                break;
                            case 1:
                                //Console.WriteLine("pointer = 1");
                                if (data[now, (1 + dir) % 4] + data[i, (3 + j) % 4] == 0)
                                {
                                    count(data, pointer + 1, i, j);
                                }
                                break;
                            case 2:
                                //Console.WriteLine("pointer = 2");
                                if (data[put_index[0], (2 + put_dir[0]) % 4] + data[i, (0 + j) % 4] == 0)
                                {
                                    count(data, pointer + 1, i, j);
                                }
                                break;
                            case 3:
                                //Console.WriteLine("pointer = 3");
                                if ((data[now, (1 + dir) % 4] + data[i, (3 + j) % 4] == 0) && (data[put_index[1], (2 + put_dir[1]) % 4] + data[i, (0 + j) % 4] == 0))
                                {
                                    count(data, pointer + 1, i, j);
                                }
                                break;
                            case 4:
                                //Console.WriteLine("pointer = 4");
                                if ((data[now, (1 + dir) % 4] + data[i, (3 + j) % 4] == 0) && (data[put_index[2], (2 + put_dir[2]) % 4] + data[i, (0 + j) % 4] == 0))
                                {
                                    count(data, pointer + 1, i, j);
                                }
                                break;
                            case 5:
                                //Console.WriteLine("pointer = 5");
                                if (data[put_index[3], (2 + put_dir[3]) % 4] + data[i, (0 + j) % 4] == 0)
                                {
                                    count(data, pointer + 1, i, j);
                                }
                                break;
                            case 6:
                                //Console.WriteLine("pointer = 6");
                                if ((data[now, (1 + dir) % 4] + data[i, (3 + j) % 4] == 0) && (data[put_index[4], (2 + put_dir[4]) % 4] + data[i, (0 + j) % 4] == 0))
                                {
                                    count(data, pointer + 1, i, j);
                                }
                                break;
                            case 7:
                                //Console.WriteLine("pointer = 7");
                                if ((data[now, (1 + dir) % 4] + data[i, (3 + j) % 4] == 0) && (data[put_index[5], (2 + put_dir[5]) % 4] + data[i, (0 + j) % 4] == 0))
                                {
                                    count(data, pointer + 1, i,j);
                                }
                                break;
                            case 8:
                                //Console.WriteLine("pointer = 8");

                                break;
                        }

                    }
                }
                
                    
                        

                        
                
                if(pointer == 8)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Ans: ");
                        
                    }
                    Console.Write(put_index[i] + "("+ put_dir[i]+") ");
                    Ans_index[ans_index, i] = put_index[i];
                    Ans_dir[ans_index, i] = put_dir[i];

                    if (i == 8)
                    {
                        Console.WriteLine(".");
                        ans_index++;
                    }
                }
                

            }
            state[now] = true;
        }
        

    }
}
