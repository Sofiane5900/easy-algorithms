---
title: 'Selection Sort'
date: '05-07-2025'
image:
    url: '/images/selection-sort.webp'
    alt: 'Sort a list by repeatedly selecting the smallest element.'
    thumbnail: '/images/selection-sort.webp'
---
Imagine you're organizing a stack of unsorted cards on the table.
You don’t try to sort them all at once — you pick the smallest card first, place it to the left.
Then you pick the next smallest, and so on, until everything is in order.

> "Find the smallest, put it in front. Repeat."

That’s the idea behind **Selection Sort**.
It’s simple, methodical, and easy to understand — though not the fastest for big data sets.

---

## 📚 Example

Say you have this array:

```c
{ 20, 55, 3, 8, 9, 101 }
```

Here's what happens:

1. Find the **smallest** → `3`, swap with `20` → `{ 3, 55, 20, 8, 9, 101 }`
2. Find the next smallest in the remaining → `8`, swap with `55` → `{ 3, 8, 20, 55, 9, 101 }`
3. Continue until sorted → `{ 3, 8, 9, 20, 55, 101 }`

You're building the sorted list **from left to right**, one minimum at a time.

---

## How selection sort works (step-by-step)

1. Start from the first element.
2. Search the rest of the array to find the smallest value.
3. Swap it with the current position.
4. Move to the next index and repeat.
5. Continue until everything is sorted.

This is called **in-place sorting**: you don’t need extra memory.

---

## Source-code

Here’s a clean example of **selection sort in C**:

```c
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

  // Display the sorted values
  for (int i = 0; i < count; i++) {
    printf("%d ", numbers[i]);
  }
  printf("\n");
}
```

Simple and efficient for small arrays.

---

## Conclusion

Selection sort is a great way to learn how sorting works under the hood.
You always know what’s happening at each step: find the smallest, swap, repeat.

It’s not the fastest algorithm, especially with large datasets — but it’s intuitive, deterministic, and doesn't need extra memory.

If you're just starting with algorithms, **understanding selection sort** helps you think clearly about data organization, comparisons, and iteration.

And once you’ve got it, you're one step closer to grasping more advanced sorts like quicksort or mergesort.

Because before you can optimize, you need to understand the basics — and selection sort is a solid start.
