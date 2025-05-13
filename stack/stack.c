//
// Created by Sofiane on 13/05/2025.
//

#include <stddef.h>

int main() {
  struct Stack {
    int value;
    struct Stack *below;
  };

  struct Stack element1;
  struct Stack element2;
  struct Stack element3;

  // bottom of the stack
  element1.value = 10;
  element1.below = NULL;

  element2.value = 20;
  element2.below = &element1;

  // top of the stack
  element3.value = 30;
  element3.below = &element2;

  struct Stack *top = &element3;

  return 0;
}
