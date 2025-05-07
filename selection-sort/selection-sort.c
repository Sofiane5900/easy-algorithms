//
// Created by Sofiane on 07/05/2025.
//

#include <stddef.h>
#include <stdio.h>

int main() {
  int numbers[] = {20, 55, 3, 8, 9, 101};
  int lowestNumber = numbers[0];
  size_t count = sizeof(numbers) / sizeof(numbers[0]);

  for (int i = 0; i < count; i++) {
    if (lowestNumber > numbers[i]) {
      lowestNumber = numbers[i];
      printf("%d\n", lowestNumber);
    }
  }
}
