---
title: 'Linked-List'
date: '04-26-2025'
image:
    url: '/images/linked-list.webp'
    alt: 'A collection of nodes, where each one points to the next.'
    thumbnail: '/images/linked-list.webp'
---

Imagine you're creating a chain of paper notes.  
Each note has two things: some information and an arrow pointing to the next note.

**That's a linked list.**

Unlike arrays where elements sit side by side in memory, linked lists are more like a treasure hunt — each element tells you where to find the next one.


## 📚 Example

Let's say we want to store three numbers: 10, 20, and 30.
In a linked list, it would look like this:

```
[10] -> [20] -> [30] -> NULL
```

Each box (we call it a node) contains:
- A value (like 10)
- A pointer to the next node

When we reach NULL, that's the end of our list!

---

## How to implement it (pseudo-code)

1. **Create** a node structure with two parts: value and next pointer
2. **Link** nodes together by setting their next pointers
3. **Traverse** the list by following these pointers
4. **Stop** when we hit NULL

---

## Source-code

Here's a ***VERY*** basic example in C:

```c
#include <stddef.h>
#include <stdio.h>

int main() {
    struct Node {
        int element;
        struct Node *next;
    };

    // Create three nodes
    struct Node node1;
    struct Node node2;
    struct Node node3;

    // Connect them together
    node1.element = 10;
    node1.next = &node2;

    node2.element = 20;
    node2.next = &node3;

    node3.element = 30;
    node3.next = NULL;

    // Print all elements
    struct Node *current = &node1;
    while (current != NULL) {
        printf("%d\n", current->element);
        current = current->next;
    }
    return 0;
}
```

When we run this code, it prints:
```
10
20
30
```

---

## Why use linked lists?

Linked lists are great when you need to:
- Add or remove elements frequently
- Grow or shrink your data structure
- Don't know the size in advance

They're like a flexible chain: easy to add links or remove them!

---

## Conclusion

Linked lists might seem tricky at first, but they're just nodes pointing to other nodes.  
Think of them as a chain where each link knows where the next one is.

When you understand linked lists, you're one step closer to mastering more complex data structures!


---