//
// Created by Sofiane on 07/05/2025.
//

#include <stddef.h>
#include <stdio.h>

int main() {
  int numbers[] = {20, 55, 3, 8, 9, 101};
  int lowestNumber = numbers[0];
  int minIndex = 0;
  size_t count = sizeof(numbers) / sizeof(numbers[0]);

  for (int i = 1; i < count; i++) {
    if (numbers[minIndex] > numbers[i]) {
      minIndex = i;
    }
  }
}
