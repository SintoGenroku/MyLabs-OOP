#include "Queue.h"

Queue::Queue(int value) : head(nullptr), tail(nullptr)
{
	push(value);
}

void Queue::pop()
{
	
}

size_t Queue::size()
{
	return size_t();
}

void Queue::push(int value)
{
	Node* tmp = new Node;
	tmp->data = value;
	tmp->next = head;
	tmp->prev = tail;
	if (empty()) head = tmp;
	tail = tmp;
	head->prev = tail;
}
