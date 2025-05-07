---
title: 'Array'
date: '05-01-2025'
image:
    url: '/images/array.webp'
    alt: 'A fixed-size collection of elements stored in contiguous memory and accessed by index.'
    thumbnail: '/images/array.webp'
---


You're trying to remember five phone numbers.

You could write them all on sticky notes and scatter them around.
But what if you just lined them up — in order — in a single row?

> "I’ll put the first one here, second next to it... fifth at the end."

Now, if you want the third one, you know exactly where to look.
That’s the idea behind an **array**.

An array is a **collection of items** stored in **contiguous memory**, where each item has a number — an index — so you can access it instantly.

It’s like a row of labeled boxes, each one holding a value.
Want to know what's inside box 3? Just look — no need to search.

Arrays are one of the **most fundamental building blocks** in programming.
Once you get them, a whole world of data structures starts to make sense.

---

## 📚 Example

Imagine this line of boxes:

```
Index →   0   1   2   3   4
Value → [ 5 | 9 | 3 | 7 | 2 ]
```

If someone asks: “what’s at index 2?”, you instantly say `3`.

This instant access — knowing where something is without searching — is called **random access**.
It makes arrays super fast: reading any item takes the same time, no matter where it is.

---

## How arrays work (step-by-step)

1. **Fixed size** — when you create an array, you decide how many slots it has.
2. **Each slot has an index** — starting from 0, going up to size - 1.
3. **All slots are next to each other** in memory.
4. **Accessing a slot is instant** — just ask for the index.

You can store numbers, words, or even objects — as long as they’re the same type.

---

## Source-code

Here’s how to build a ***VERY*** basic array structure from scratch in C:

```c
#include <stddef.h>
#include <stdio.h>
#define MAX_SIZE 5

struct Array {
    int data[MAX_SIZE];  // Our storage shelf
    int size;            // How many items we have
};

int main() {
    struct Array array;

    array.data[0] = 5;
    array.data[1] = 9;
    array.data[2] = 3;
    array.data[3] = 7;
    array.data[4] = 2;

    array.size = MAX_SIZE;
    for (int i = 0; i < array.size; i++) {
        printf("Element at index [%d]: %d\n", i, array.data[i]);
    }
}
```

Again, this is just a very basic implementation. It allows you to store fixed values and print them, and that's about it.

---

## Conclusion

Arrays are like shelves where every item has a label.
You can grab anything instantly if you know its label (index).

They’re simple, powerful, and everywhere in programming — from sorting algorithms to building complex structures like matrices, stacks, and queues.

If you're just starting out with algorithms, understanding arrays is **step one**.
Because before you search, sort, or manipulate data — you have to **store it well**.

That’s what arrays are for.
