
//
// Created by Sofiane on 01/04/2025.
//

#include <stddef.h>
#include <stdio.h>
#define MAX_SIZE 5

struct Array {
  int data[MAX_SIZE];
  int size;
};

int main() {

  struct Array array;

  array.data[0] = 1;
  array.data[1] = 2;
  array.data[2] = 3;
  array.data[3] = 4;
  array.data[4] = 5;

  array.size = MAX_SIZE;
  for (int i = 0; i < array.size; i++) {
    printf("Element of the index [%d]: %d\n", i, array.data[i]);
  }
}
