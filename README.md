# F# Mutable Variable Swap Bug

This repository demonstrates a common error in F# involving the incorrect use of mutable variables and the order of operations when attempting to swap two values. The original code uses a bitwise XOR approach, which can be efficient but requires careful handling of mutable assignments. The provided solution clarifies the issue and presents a corrected way to swap mutable variables.

## Bug Description
The bug is in the `add` function, where the intention is to swap the values of `x` and `y` using a bitwise XOR technique. Due to the order in which the assignments are made, the final values are not the expected swapped values. The order of assignments alters the intermediate values, leading to an incorrect outcome. 

## Solution
The solution presents a corrected function that uses temporary storage for swapping. This is a safer and more readable method, especially for beginners.