using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_s_Algorithm
{
    class Floyd
    {
        List<int> queue = new List<int>(); // Очередь для хранения непросмотренных вершин
        public Floyd(double[,] _adjacencyMatrix, int start, int s)
        {
            int[,] array = new int[s, s];
            initial(start, s);

            for (int i =0; i < s; i++) 
            {
                for (int j =0; j < s; j++)
                {
                    if (_adjacencyMatrix[i, j] == 0)
                    {
                        _adjacencyMatrix[i, j] = double.PositiveInfinity; // 1000
                    }
                    if (i == j) _adjacencyMatrix[i, j] = 0;
                }
            }

            //            for (int k = 0; k < s; ++k)
            //            {
            //                for (int i = 0; i < s; ++i)
            //                {
            //                    for (int j = 0; j < s; ++j)
            //                    {
            //                        if (_adjacencyMatrix[i, k] > _adjacencyMatrix[k, j] + _adjacencyMatrix[i, j])
            //                        {
            //                            _adjacencyMatrix[i, j] = _adjacencyMatrix[i, k] + _adjacencyMatrix[k, j];
            //;
            //                        }
            //                    }
            //                }
            //            }
            for (int k = 0; k < s; k++)
            {
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        if ((i != j))
                        {
                            if (_adjacencyMatrix[i, k] + _adjacencyMatrix[k, j] < _adjacencyMatrix[i, j] || _adjacencyMatrix[i, j] == 0)
                            {
                                _adjacencyMatrix[i,j] = _adjacencyMatrix[i,k] + _adjacencyMatrix[k,j];
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < s; i++)
            {
                dist[i] = _adjacencyMatrix[0,i];
            }
        }

        public double[] dist { get; set; } //расстояния

        /// <summary>
        /// Следующая вершина
        /// </summary>
        /// <returns></returns>
        int getNextVertex()
        {
            var min = double.PositiveInfinity; // бесконечность. Прямого пути через эти вершинамы не существует
            int vertex = -1;
            foreach (int value in queue)
            {
                if (dist[value] <= min)
                {
                    min = dist[value];
                    vertex = value;
                }
            }
            queue.Remove(vertex);
            return vertex;
        }

        /// <summary>
        /// Начальная инициализация
        /// </summary>
        /// <param name="s"></param>
        /// <param name="len"></param>
        public void initial(int s, int len)
        {
            dist = new double[len];
            for (int i = 0; i < len; i++)
            {
                dist[i] = double.PositiveInfinity;
                queue.Add(i);
            }
            dist[0] = 0;
        }
    }
}
