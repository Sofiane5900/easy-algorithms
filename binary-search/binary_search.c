//
// Created by Sofiane on 27/04/2025.
//

#include <stddef.h>
#include <stdio.h>
int main() {
  int number = 5;
  int numbers[] = {2, 5, 8, 10, 11, 12};
  size_t count = sizeof(numbers) / sizeof(numbers[0]);
  int left = 0;
  int right = count - 1;

  while (left <= right) {
    int middle = (left + right) / 2;

    if (numbers[middle] == number) {
      printf("Found : %d\n", number);
      break;
    } else if (numbers[middle] < number) {
      left = middle + 1;
    } else {
      right = middle - 1;
    }
  }
  return 0;
}
