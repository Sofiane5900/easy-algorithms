//
// Created by Sofiane on 07/05/2025.
//

#include <stddef.h>
#include <stdio.h>

int main() {
  int numbers[] = {20, 55, 3, 8, 9, 101};
  size_t count = sizeof(numbers) / sizeof(numbers[0]);

  for (int i = 0; i < count - 1; i++) {
    int minIndex = i;

    // Find the smallest index
    for (int j = i + 1; j < count; j++) {
      if (numbers[minIndex] > numbers[j]) {
        minIndex = j;
      }
    }

    // Use of swap algorithm to switch values
    if (minIndex != i) {
      int temp = numbers[i];
      numbers[i] = numbers[minIndex];
      numbers[minIndex] = temp;
    }
  }

  // display the values (sorted)
  for (int i = 0; i < count; i++) {
    printf("%d ", numbers[i]);
  }
  printf("\n");
}
