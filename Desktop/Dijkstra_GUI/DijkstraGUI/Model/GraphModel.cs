using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraGUI.Model
{
    class GraphModel
    {
        public Dictionary<char, Dictionary<char, int>> Vertices = new Dictionary<char, Dictionary<char, int>>();

        public Dictionary<char, int> shortestRoute(char start, char finish)
        {
            var previous = new Dictionary<char, char>();
            var distances = new Dictionary<char, int>();
            var nodes = new List<char>();
            var distanceList = new List<int>();
            var path_dictionary = new Dictionary<char, int>();

            List<char> path = null;

            foreach (var vertex in Vertices)
            {
                if (vertex.Key == start)
                {
                    distances[vertex.Key] = 0;
                }
                else
                {
                    distances[vertex.Key] = int.MaxValue;
                }

                nodes.Add(vertex.Key);
            }

            while (nodes.Count != 0)
            {
                nodes.Sort((x, y) => distances[x] - distances[y]);

                var smallest = nodes[0];
                nodes.Remove(smallest);

                if (smallest == finish)
                {
                    path = new List<char>();
                    while (previous.ContainsKey(smallest))
                    {
                        path.Add(smallest);
                        distanceList.Add(distances[smallest]);
                        path_dictionary[smallest] = distances[smallest];
                        smallest = previous[smallest];
                    }
                    break;
                }

                if (distances[smallest] == int.MaxValue)
                    break;

                foreach (var neighbor in Vertices[smallest])
                {
                    var alt = distances[smallest] + neighbor.Value;
                    if (alt < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = alt;
                        previous[neighbor.Key] = smallest;
                    }
                }
            }
            return path_dictionary;
        }
    }
}
