using System.ComponentModel.Design;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;


namespace Tetris
{
    class Shape1
    {
        public int Rotatetion = 1;
        public int shapeType;
        public int[,] CurrentRotate;

        public Shape1()
        {
            Random r = new Random();
            shapeType = r.Next(1, 8);
            CurrentRotate = GetRotate(1, shapeType);
        }

        private int[,] GetRotate(int rotatetion , int shapetype)
        {
            int[,] Rotate = new int[1,1];
            if (shapetype == 1)
            {
                if (rotatetion == 1) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 0},
                        {1 , 0},
                        {1 , 1}
                    };
                }
                else if (rotatetion == 2) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1 , 1},
                        {1 , 0 , 0}
                    };
                }
                else if (rotatetion == 3) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1},
                        {0 , 1},
                        {0 , 1}
                    };
                }
                else if (rotatetion == 4) 
                {
                    Rotate = new int[,]
                    {
                        {0 , 0 , 1},
                        {1 , 1 , 1}
                    };
                }
            }

            else if (shapetype == 2)
            {
                if (rotatetion == 1) 
                {
                    Rotate = new int[,]
                    {
                        {0 , 1},
                        {0 , 1},
                        {1 , 1}
                    };
                }
                else if (rotatetion == 2) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 0 , 0},
                        {1 , 1 , 1}
                    };
                }
                else if (rotatetion == 3) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1},
                        {1 , 0},
                        {1 , 0}
                    };
                }
                else if (rotatetion == 4) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1 , 1},
                        {0 , 0 , 1}
                    };
                }
            }

            else if (shapetype == 3)
            {
                if (rotatetion == 1) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1},
                        {1 , 1}
                    };
                }
                else if (rotatetion == 2) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1},
                        {1 , 1}
                    };
                }
                else if (rotatetion == 3) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1},
                        {1 , 1}
                    };
                }
                else if (rotatetion == 4) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1},
                        {1 , 1}
                    };
                }
            }
            

            else if (shapetype == 4)
            {
                if (rotatetion == 1) 
                {
                    Rotate = new int[,]
                    {
                        {1},
                        {1},
                        {1},
                        {1}
                    };
                }
                else if (rotatetion == 2) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1 , 1 , 1}
                    };
                }
                else if (rotatetion == 3) 
                {
                    Rotate = new int[,]
                    {
                        {1},
                        {1},
                        {1},
                        {1}
                    };
                }
                else if (rotatetion == 4) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1 , 1 , 1}
                    };
                }
            }
            

            else if (shapetype == 5)
            {
                if (rotatetion == 1) 
                {
                    Rotate = new int[,]
                    {
                        {0 , 1 , 0},
                        {1 , 1 , 1}
                    };
                }
                else if (rotatetion == 2) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 0},
                        {1 , 1},
                        {1 , 0}
                    };
                }
                else if (rotatetion == 3) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1 , 1},
                        {0 , 1 , 0}
                    };
                }
                else if (rotatetion == 4) 
                {
                    Rotate = new int[,]
                    {
                        {0 , 1},
                        {1 , 1},
                        {0 , 1}
                    };
                }
            }
            

            else if (shapetype == 6)
            {
                if (rotatetion == 1) 
                {
                    Rotate = new int[,]
                    {
                        {0 , 1},
                        {1 , 1},
                        {1 , 0}
                    };
                }
                else if (rotatetion == 2) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1 , 0},
                        {0 , 1 , 1}
                    };
                }
                else if (rotatetion == 3) 
                {
                    Rotate = new int[,]
                    {
                        {0 , 1},
                        {1 , 1},
                        {1 , 0}
                    };
                }
                else if (rotatetion == 4) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 1 , 0},
                        {0 , 1 , 1}
                    };
                }
            }
            
            

            else if (shapetype == 7)
            {
                if (rotatetion == 1) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 0},
                        {1 , 1},
                        {0 , 1}
                    };
                }
                else if (rotatetion == 2) 
                {
                    Rotate = new int[,]
                    {
                        {0 , 1 , 1},
                        {1 , 1 , 0}
                    };
                }
                else if (rotatetion == 3) 
                {
                    Rotate = new int[,]
                    {
                        {1 , 0},
                        {1 , 1},
                        {0 , 1}
                    };
                }
                else if (rotatetion == 4) 
                {
                    Rotate = new int[,]
                    {
                        {0 , 1 , 1},
                        {1 , 1 , 0}
                    };
                }
            }

            return Rotate;
        }


        public void Rotate()
        {
            if (Rotatetion != 4)
            {
                Rotatetion++;
                CurrentRotate = GetRotate(Rotatetion,this.shapeType);
            }
            else
            {
                Rotatetion = 1;
                CurrentRotate = GetRotate(Rotatetion, this.shapeType);
            }
        }
    }
    class Program
    {
        static bool KeyPressWithinTimeSpan(out ConsoleKeyInfo keyInfo, TimeSpan timeout)
        {
            DateTime start = DateTime.Now;

            while ((DateTime.Now - start) < timeout)
            {
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(intercept: true);
                    return true;
                }
                Thread.Sleep(50); // Small delay to reduce CPU usage
            }

            keyInfo = default;
            return false;
        }

        static float ChooseDificulty()
        {
            Console.WriteLine("Choose The Dificulty : ");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Normal");
            Console.WriteLine("3 - Hard");
            while (true) 
            {
                Console.Write("Your choice : ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    return 1.5F;
                }
                else if (choice == "2")
                {
                    return 1;

                }
                else if (choice == "3")
                {
                    return 0.5F;
                }
                else { Console.WriteLine("Invalid Input"); }
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Tetris";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            int score = 0;
            int hieght = 20;
            int width = 10;
            int[,] background = new int[hieght, width];
            int[,] Tempbackground = new int[hieght, width];
            float dificulty = ChooseDificulty();


            bool NotGameOver = true;
            while (NotGameOver)
            {
                Shape1 CurrentShape = new Shape1();
                int y = CurrentShape.CurrentRotate.GetLength(0) - 1;
                int x = 4;
                int t = 0;
                bool NotPlaced = true;
                while (NotPlaced)
                {
                    string errorM = "";
                    if (t != 0)
                    {
                        bool TryInput = true;
                        while (TryInput)
                        {
                            TryInput = false;
                            Console.Write("Your Action :");
                            string action ;
                            if (KeyPressWithinTimeSpan(out ConsoleKeyInfo keyInfo, TimeSpan.FromSeconds(dificulty)))
                            {
                                action = Convert.ToString(keyInfo.Key);
                            }
                            else
                            {
                                action = "NoInput";
                            }
                            errorM = "";
                            if (action == "LeftArrow") 
                            {
                                if ((x != 0) && CheckMove(background, x-1, y, CurrentShape))
                                    { x--; } 
                            }
                            else if (action == "RightArrow") 
                            {
                                if ( ((x + CurrentShape.CurrentRotate.GetLength(1)) != 10) && CheckMove(background,x+1,y,CurrentShape))
                                    { x++; } 
                            }
                            else if (action == "DownArrow" || action == "NoInput") 
                            { 
                                if ( ((y + 1) != 20) && CheckMove(background,x,y+1,CurrentShape))
                                    { y++; }

                                if (!(((y + 1) != 20) && CheckMove(background, x, y + 1, CurrentShape)))
                                { NotPlaced = false; }
                            }
                            else if (action == "Z") 
                            {
                                int stop = 0;
                                while (CheckMove(background, x, y + stop + 1, CurrentShape))
                                {
                                    stop++;
                                    if (y + stop + 1 >= 20) break;
                                }
                                y += stop;
                            }
                            else if (action == "UpArrow") 
                            {
                                CurrentShape.Rotate();
                                try
                                {
                                    if(!CheckMove(background, x, y, CurrentShape))
                                    {
                                        CurrentShape.Rotate(); 
                                        CurrentShape.Rotate(); 
                                        CurrentShape.Rotate();
                                        errorM = "Cant rotate here";
                                    }
                                }
                                catch (Exception)
                                {
                                    CurrentShape.Rotate(); 
                                    CurrentShape.Rotate(); 
                                    CurrentShape.Rotate();
                                    errorM = "Cant rotate here";
                                }
                            }
                            else if (action == "Escape")
                            {
                                NotGameOver = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                TryInput = true;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    t++;
                    if (NotGameOver == false)
                    {
                        break;
                    }

                    Console.Clear();
                    Console.WriteLine("How to Play :\n" +
                        "Press UpArrow to rotate\n" +
                        "Press LeftArrow to go right\n" +
                        "Press RightArrow to go left\n" +
                        "Press DownArrow to go down\n" +
                        "Press z to go to the bottom\n" +
                        "Press Escape to exit");
                    Console.WriteLine();
                    if (errorM.Length > 0) { Console.WriteLine(errorM); Console.Beep(); }
                    Console.WriteLine($"Your Score : {score}");
                    Array.Copy(background, Tempbackground, background.Length);
                    int b = CurrentShape.CurrentRotate.GetLength(0) - 1;
                    for (int i = y; i > y - CurrentShape.CurrentRotate.GetLength(0); i--, b--)
                    {
                        int a = 0;
                        for (int j = x; j < x + CurrentShape.CurrentRotate.GetLength(1); j++, a++)
                        {
                            Tempbackground[i, j] = Tempbackground[i, j] + CurrentShape.CurrentRotate[b, a];
                            if(Tempbackground[i, j] == 2)
                            {
                                NotGameOver = false;
                            }
                        }
                    }
                    if(NotGameOver == false){
                        break;
                    }

                    printTable(Tempbackground, width, hieght);
                }
                Console.WriteLine();
                Console.WriteLine();


                int tetris;
                for (int i = 0; i < hieght; i++)
                {
                    tetris = 0;
                    for (int j = 0; j < width; j++)
                    {
                        if (Tempbackground[i, j] == 1)
                        { tetris++; }
                    }
                    if (tetris == width)
                    {
                        score++;
                        for (int j = 0; j < width; j++)
                        {
                            Tempbackground[i, j] = 0;
                        }
                        for (int k = i; k > 0 ; k--)
                        {
                            SwapRows(Tempbackground, k, k - 1);
                        }
                    }
                }

                Array.Copy(Tempbackground , background , background.Length);
                for (int i = 0;i < width; i++)
                {
                    if (background[0,i] == 1)
                    {
                        NotGameOver = false;
                        break;
                    }
                }

            }
            Console.WriteLine($"Your Score : {score}");
            Console.WriteLine("Game Over !!!");

            static bool CheckMove(int[,] background , int x , int y ,Shape1 shape)
            {
                int[,] Tempbackground2 = new int[background.GetLength(0), background.GetLength(1)]; 
                Array.Copy(background, Tempbackground2, background.Length);
                int b = shape.CurrentRotate.GetLength(0) - 1;
                for (int i = y; i > y - shape.CurrentRotate.GetLength(0); i--, b--)
                {
                    int a = 0;
                    for (int j = x; j < x + shape.CurrentRotate.GetLength(1); j++, a++)
                    {
                        Tempbackground2[i, j] = Tempbackground2[i, j] + shape.CurrentRotate[b, a];
                        if(Tempbackground2[i, j] == 2)
                            { return false; }
                    }
                }
                return true ;
            }            

            static void printTable(int[,] table ,int width ,int hieght)
            {
                for (int i = 0; i < hieght; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (table[i, j] == 1)
                        { Console.Write("[#]"); }
                        else if (table[i, j] == 0)
                        { Console.Write(" - "); }
                        else
                        { Console.Write("[?]"); }
                    }
                    Console.WriteLine();
                }
            }

            static void SwapRows(int[,] table, int row1 , int row2 )
            {
                int temp;
                for (int i = 0; i < table.GetLength(1); i++)
                {
                    temp = table[row1 , i];
                    table[row1,i] = table[row2 , i];
                    table[row2, i ] = temp;
                }
            }
        }
    }
}
