#include "LinkedList.h"

double LinkedList::MedianValue() {
	double sum = 0.0;
	int count = 0;
	Node* temp = head;
	while (temp != NULL) {
		sum += temp->Data;
		count++;
		temp = temp->Link;
	}
	return sum / count;
}
void LinkedList::DeleteEvenElements() {
	Node* next = head->Link->Link;
	Node* after = head->Link->Link->Link;
	head->Link = head->Link->Link;
	while (next != NULL && after != NULL) {
		cout << next->Data;
		if (next->Data < 0) {
			cout << next->Data;
			next->Link = after->Link;
			after = NULL;
			next = next->Link;
			if (next != NULL) {
				after = next->Link;
			}
		}
	}
	//while (temp != NULL) {
	//	if (temp->Data < 0) {
	//		temp = NULL;
	//	}
	//	temp = temp->Link;
	//}
}
void LinkedList::PrintList() {
	Node* temp = head;
	while (temp != NULL) {
		cout << temp->Data << "\n";
		temp = temp->Link;
	}
}

int LinkedList::FindNumberOfElementsGreaterThanMedian() {
	int count = 0;
	double median = MedianValue();
	Node* temp = head;
	while (temp != NULL) {
		if (temp->Data > median) {
			count++;
		}
		temp = temp->Link;
	}
	return count;
}