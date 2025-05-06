//
// Created by Sofiane on 26/04/2025.
//

#include <stddef.h>
#include <stdio.h>

int main() {
  struct Node {
    int element;
    struct Node *next;
  };

  struct Node node1;
  struct Node node2;
  struct Node node3;

  node1.element = 10;
  node1.next = &node2;

  node2.element = 20;
  node2.next = &node3;

  node3.element = 30;
  node3.next = NULL;

  struct Node *current = &node1;
  while (current != NULL) {
    printf("%d\n", current->element);
    current = current->next;
  };
  return 0;
}
