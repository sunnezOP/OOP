#include <iostream>
#include "LinkedList.h"
using namespace std;


int main()
{
    LinkedList linkedlist;
    linkedlist.head = new Node(1.1);
    Node* node2 = new Node(2);
    linkedlist.head->Link = node2;
    Node* node3 = new Node(3.2);
    node2->Link = node3;
    Node* node4 = new Node(4.1);
    node3->Link = node4;
    cout << "List: \n";
    linkedlist.PrintList();
    cout << "Number of elements bigger than avg - " << linkedlist.FindNumberOfElementsGreaterThanMedian() << endl;
    linkedlist.DeleteEvenElements();
    cout << "List after deleting even items: \n";
    linkedlist.PrintList();
}