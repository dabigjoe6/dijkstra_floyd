/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package djikstra_floyd;

import java.util.LinkedList;
import java.util.Scanner;

/**
 *
 * @author BLAKJ
 */
public class Djikstra_floyd {
    public static void main(String[] args) {
        
        System.out.println("OR PROJECT ==> GROUP 4");
        System.out.println("Using Dijkstra or Floyd to calculate distance between nodes in a graph");
        System.out.println("Select an algorithm:");
        System.out.println("1. Dijkstra Algorithm");
        System.out.println("2. Floyd Algorithm");
        System.out.print("response: ");
        Scanner scan = new Scanner(System.in);
        int response;
        response = scan.nextInt();
        switch(response) {
            case 1: 
                doDijkstra();
                break;
            case 2: 
                doFloyd();
                break;
            default: 
                System.out.println("Please choose either options 1 or 2");
                break;
                       
        }
       
        response = scan.nextInt();
        
    }
    
    
    public static void doDijkstra() {
        Graph graph = new Graph();
        Scanner scan = new Scanner(System.in);
        System.out.print("Enter the number of Vertices(Nodes): ");
        int noOfVertices = scan.nextInt();
        System.out.print("Enter the number of edges: ");
        int noOfEdges = scan.nextInt();
        
        for(int i = 0; i < noOfVertices; ++i) {
            graph.addVertex(i);
        }
        
        System.out.println("Enter the each of the node pairs in the form: ");
        System.out.println("Node1 Node2 Weight");
        for(int i = 0; i < noOfEdges; ++i) {
            int node1;
            int node2;
            int weight;
            
            System.out.println("Edge " + (i + 1));
            System.out.print("Node 1: ");
            node1 = scan.nextInt();
            System.out.print("Node 2: ");
            node2 = scan.nextInt();
            System.out.print("Weight: ");
            weight = scan.nextInt();
            
            graph.addEdge(node1, node2, weight);
           
        }  
        
        Edge[] array = graph.getEdges().toArray(new Edge[0]);
        for(int i = 0; i < noOfEdges; ++i) {
            System.out.println(array[i].getV1().getLabel() + ", " + array[i].getV2().getLabel() + ", " + array[i].getWeight());
        }
        
        Dijkstra dijsktra = new Dijkstra(graph);
        Vertex [] vertices = new Vertex [graph.getNoOfVertex()];
        graph.getVertices().toArray(vertices);
        dijsktra.execute(vertices[1]);
        LinkedList<Vertex> path = new LinkedList<Vertex>();
        dijsktra.print(vertices[vertices.length - 1]);
        
    }
    
    public static void doFloyd() {
            Graph graph = new Graph();
            Scanner scan = new Scanner(System.in);
            System.out.print("Enter the number of Vertices(Nodes): ");
            int noOfVertices = scan.nextInt();
            System.out.print("Enter the number of edges: ");
            int noOfEdges = scan.nextInt();
        
            for(int i = 0; i <= noOfVertices; ++i) {
                graph.addVertex(i);
            }
        
            System.out.println("Enter the each of the node pairs in the form: ");
            System.out.println("Node1 Node2 Weight");
            for(int i = 0; i < noOfEdges; ++i) {
                int node1;
                int node2;
                int weight;
            
                
                System.out.println("Edge " + (i + 1));
                System.out.print("Node 1: ");
                node1 = scan.nextInt();
                System.out.print("Node 2: ");
                node2 = scan.nextInt();
                System.out.print("Weight: ");
                weight = scan.nextInt();
            
                graph.addEdge(node1, node2, weight);
            
                
            }
            
            FloydWarshall floyd = new FloydWarshall();
            floyd.floydWarshall(graph);
    
    }
}
