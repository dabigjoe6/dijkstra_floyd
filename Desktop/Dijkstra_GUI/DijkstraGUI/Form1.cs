using DijkstraGUI.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijkstraGUI
{
    public partial class Form1 : Form
    {
        List<char> nodeLabels = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        GraphModel graphModel = new GraphModel();

        Dictionary<char, int> nodes;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();

            startingLabel.Text = nodeLabels[counter].ToString();
            CalculateBtn.Enabled = false;
        }

        private void noOfNodes_ValueChanged(object sender, EventArgs e)
        {
            sourceNodeComboBox.Items.Clear();
            destinationNodeComboBox.Items.Clear();
            nodeLabels.Take((int)noOfNodes.Value).ToList().ForEach(x => sourceNodeComboBox.Items.Add(x));
            nodeLabels.Take((int)noOfNodes.Value).ToList().ForEach(x => destinationNodeComboBox.Items.Add(x));

        }


        private void connectionBtn_Click(object sender, EventArgs e)
        {
            nodes = new Dictionary<char, int>();
            try
            {
                var nodeConnections = connectionText.Text.Split(';');
                foreach (var item in nodeConnections)
                {
                    var keyValue = item.Split(',');
                    nodes[Convert.ToChar(keyValue[0].ToUpper())] = int.Parse(keyValue[1]);
                }

                graphModel.Vertices[Convert.ToChar(startingLabel.Text)] = nodes;

                var addVertex = "";
                foreach (var item in nodes)
                {
                    addVertex += $"{startingLabel.Text}->[{item.Value}]->{item.Key}; ";
                }
                connectionDisplayList.Items.Add(addVertex);

                counter++;
                if (counter <= noOfNodes.Value)
                    startingLabel.Text = nodeLabels[counter].ToString();
                connectionText.Text = "";

                //enabling calculate
                if (counter < 2)
                    CalculateBtn.Enabled = false;
                else
                    CalculateBtn.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Should be in the format \n From Node A to B,3;C,4;D,2 \n Thanks", "Error");
            }
        }
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Dijkstra'S path
                pathText.Text = "";
                costLabel.Text = graphModel.shortestRoute(Convert.ToChar(sourceNodeComboBox.SelectedItem), Convert.ToChar(destinationNodeComboBox.SelectedItem)).FirstOrDefault().Value.ToString();
                pathText.Text = sourceNodeComboBox.SelectedItem + " -> ";
                for (int i = graphModel.shortestRoute(Convert.ToChar(sourceNodeComboBox.SelectedItem), Convert.ToChar(destinationNodeComboBox.SelectedItem)).Count - 1; i > 0; i--)
                {
                    pathText.Text += graphModel.shortestRoute(Convert.ToChar(sourceNodeComboBox.SelectedItem), Convert.ToChar(destinationNodeComboBox.SelectedItem)).ElementAt(i).Key + " -> ";
                }
                pathText.Text += graphModel.shortestRoute(Convert.ToChar(sourceNodeComboBox.SelectedItem), Convert.ToChar(destinationNodeComboBox.SelectedItem)).ElementAt(0).Key;

                //Floyd's Path
                floydListbox.Items.Clear();
                foreach (var StartNode in graphModel.Vertices)
                {
                    foreach (var endNode in graphModel.Vertices)
                    {
                        var pathCost = $"{StartNode.Key} --> ";
                        for (int i = graphModel.shortestRoute(StartNode.Key, endNode.Key).Count - 1; i >= 0; i--)
                        {
                            if (i == 0)
                                pathCost += $"[{graphModel.shortestRoute(StartNode.Key, endNode.Key).ElementAt(i).Value}]--> {graphModel.shortestRoute(StartNode.Key, endNode.Key).ElementAt(i).Key}";
                            else
                                pathCost += $"[{graphModel.shortestRoute(StartNode.Key, endNode.Key).ElementAt(i).Value}]--> {graphModel.shortestRoute(StartNode.Key, endNode.Key).ElementAt(i).Key} -->";
                        }

                        floydListbox.Items.Add(pathCost);
                        floydListbox.Items.Add("--------------------------------------");
                    }
                }
                pathFloydText.Text = pathText.Text;
            }
            catch
            {
                MessageBox.Show("Please check all parameters. Click reset to clear errors", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noOfNodes.Value = 0;
            startingLabel.Text = "A";
            counter = 0;
            connectionDisplayList.Items.Clear();
            graphModel = new GraphModel();
            floydListbox.Items.Clear();
            pathText.Text = "";
            pathFloydText.Text = "";
            costLabel.Text = "0";
            noOfNodes.Value = 0;
            sourceNodeComboBox.Text = "";
            destinationNodeComboBox.Text = "";
            connectionText.Text = "";
        }

        private void connectionDisplayList_DoubleClick(object sender, EventArgs e)
        {
            int indes = connectionDisplayList.SelectedIndex;
            startingLabel.Text = convertToSmall(connectionDisplayList.SelectedItem.ToString())[0];
            connectionText.Text = convertToSmall(connectionDisplayList.SelectedItem.ToString())[1];
            connectionDisplayList.Items.RemoveAt(indes);
            counter--;
        }
        string[] convertToSmall(string text)
        {
            var ansArray = new string[2];
            var ans = "";
            var strArrays = text.Replace(" ", "").Replace(">", "").Replace("[", "").Replace("]", "").Split(';');
            for (int i = 0; i < strArrays.Length - 1; i++)
            {
                var single = strArrays[i].Split('-');
                ansArray[0] = single[0];
                ans += single[2] + "," + single[1];
                if (i < strArrays.Length - 2) ans += ";";
            }
            ansArray[1] = ans;
            return ansArray;
        }
        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = namesLabel.Location.X - 5;
            if (x <= -namesLabel.Width)
                x = this.Width;
            namesLabel.Location = new Point(x, namesLabel.Location.Y);
        }
    }
}