using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateConsoleProject
{
    class Fruit
    {
        Random random = new Random();
        int randomItemPlace;
        float randomScore;
        int floorCount = 0;
        int[] itemCountPerScore = new int[5] { 0, 0, 0, 0, 0 };


        public void FloorCount(int distance, TileType[,] maze)
        {
            for (int i = 0; i < distance; i++)
            {
                for (int j = 0; j < distance; j++)
                {
                    if (maze[i, j].Type == (int)MazeCompo.floor)
                    {
                        floorCount++;
                    }
                }
            }
        }

        public int[] MakeRandomFruit(int distance, TileType[,] maze)
        {
            for (int i = 0; i < distance; i++)
            {
                for (int j = 0; j < distance; j++)
                {
                    if (maze[i, j].Type == (int)MazeCompo.floor)
                    {
                        randomItemPlace = random.Next(0, floorCount / distance);
                        randomScore = (float)random.Next(50, 351) / 100;

                        if (randomItemPlace == 0)
                        {
                            maze[i, j].Type = (int)MazeCompo.item;
                            maze[i, j].Score = randomScore;
                            if (maze[i, j].Score > 3)
                            {
                                itemCountPerScore[0]++;
                            }
                            else if (maze[i, j].Score > 3)
                            {
                                itemCountPerScore[1]++;
                            }
                            else if (maze[i, j].Score > 2.3)
                            {
                                itemCountPerScore[2]++;
                            }
                            else if (maze[i, j].Score > 1.7)
                            {
                                itemCountPerScore[3]++;
                            }
                            else
                            {
                                itemCountPerScore[4]++;
                            }
                        }
                    }
                }
            }
            return itemCountPerScore;
        }
    }
}
