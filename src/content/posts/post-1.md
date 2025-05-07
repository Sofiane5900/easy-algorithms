---
title: 'Binary Search'
date: '04-27-2025'
image:
    url: '/images/blog-post.webp'
    alt: 'Quickly find what you need in a sorted list using binary search.'
    thumbnail: '/images/binary-search.webp'
---
You're trying to find a word in a dictionary.

You don't flip through every single page. You open the book somewhere near the middle, check the word you land on, and make a decision:

> "Okay, the word I'm looking for is before this page."
>
> "Or maybe it's after."

You repeat this process, cutting your search space in half every time.

**That's binary search.**

And it's not just smarter — it's **incredibly fast**.  
Even in a list of a million elements, you would need only about twenty guesses to find your number.

---

## 📚 Example

Suppose you have this sorted array:

```c
{ 2, 5, 8, 10, 11, 12 };
```

You want to find the number `10`.

Here's the visual intuition:

1. Start by checking the middle element: `8`.
2. `10` is bigger than `8`, so you discard everything to the left of `8`.
3. Now, you are left with the right sublist `{10, 11, 12}`.
4. Check the middle again: `11`.
5. `10` is smaller than `11`, so you focus on the left element, which is `10`.
6. Finally, you find `10`!

Each guess you make cut in half the search space, getting you closer to the answer much faster than checking one by one.

---

## How to implement it (pseudo-code)

1. **Initialize two pointers**: one at the start (`left`) and one at the end (`right`) of the list.
2. **Find the middle** element.
3. **Compare** the middle element with the target.
4. **Move left or right** depending on the comparison.
5. **Repeat** until you find the element or the search space is empty.

---

## Source-code

Here's a clean version of binary search in C :

```c
while (left <= right) {
    int middle = (left + right) / 2; // Find the middle index

    if (numbers[middle] == number) {
        printf("Found: %d\n", number); // Found the number
        break;
    } else if (numbers[middle] < number) {
        left = middle + 1; // Target is greater, search right half
    } else {
        right = middle - 1; // Target is smaller, search left half
    }
}
```

Short and efficient :D

---

## Conclusion

Binary search is one of the most practically useful algorithms you can learn.  
Whenever you're dealing with sorted data — searching a database, finding an item in a sorted list, even guessing a number — binary search gives you a way to find the answer **without wasting time**.

It doesn't matter if there are ten elements or ten million.  
Binary search is fast because it always asks the right question: "Which half should I keep?"

Understanding this simple idea is essential for writing efficient programs and handling large amounts of data with ease.

When speed matters (and it kinda always does...) binary search should be one of your first algorithms to reach for.

