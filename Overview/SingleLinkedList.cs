using System;

public class SingleLinkedList<T> {

    private class Node {

        public T Data;
        public Node Next;


        public Node(T data){

            Data = data;
            Next = null;
        }



    }

    private Node head;


    public void AddFirst(T data){

        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;

    }

    public void PrintList() {


        Node current = head;
        while (current != null) {


            Console.WriteLine(current.Data);
            current = current.next;

        }

    }


}
