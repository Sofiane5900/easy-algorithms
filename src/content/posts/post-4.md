---
title: 'Swap'
date: '05-05-2025'
image:
    url: '/images/swap.webp'
    alt: 'Learn how to switch the place of two values without losing either.'
    thumbnail: '/images/swap.webp'
---

You're packing your bag for a trip.

You realize your charger is in the wrong pocket, and your headphones are in the place where the charger should go.

> "I'll just move the charger to a temporary spot, then shift the headphones, then bring the charger back."

That’s **swapping** — moving two things by using a temporary space so you don’t lose anything.

Swapping values is a tiny operation — but it's **used everywhere**.
From sorting arrays to shuffling cards in a game, swap is the silent hero.

---

## 📚 Example

Let’s say you have two values:

```c
a = 20
b = 40
```

You want to make `a` become `40`, and `b` become `20`.

But if you just do:

```c
a = b;
```

You lose the original value of `a`, right?

So we need a temporary spot to hold one value **while** we perform the switch.

---

## How swap works (step-by-step)

1. Create a third variable `c` to **hold the value of `a`**
2. Assign `b` to `a`
3. Assign `c` (which holds original `a`) to `b`

Now both values are safely swapped.

---

## Source-code

Here’s how to implement the swap algorithm in C:

```c
int main() {
  int a = 20;
  int b = 40;
  int c;

  c = a;  // Step 1: store a in c
  a = b;  // Step 2: assign b to a
  b = c;  // Step 3: assign original a to b
}
```

It’s simple — and safe.
This method makes sure no data is lost in the process.

There are other ways to swap without a third variable (like using math), but this one is the **clearest and most beginner-friendly**.

---

## Conclusion

Swapping is one of those tiny algorithm that power bigger ones.

Whether you're sorting numbers, managing memory, or making animations — the swap operation shows up everywhere.

If you're just starting to explore algorithms, mastering the logic of a basic value swap is **a solid first step**.
