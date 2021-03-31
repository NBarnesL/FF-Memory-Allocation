# First Fit Memory Allocation
---
## Introduction
This is my submission for CS471 Spring 2021 Project 2. Code is found in cs471-project2 folder.

This project was developed in C# in Visual Studio 2019 using Windows Forms.

## Directions For Use
1. Create a process with a specific size with the **Create** button. You can also use the **Autocreate** button to randomly generate processes.
2. Set Up your memory using the dropdown menu. The options for memory are as follows:
    - if the free space is used and the top is empty and the bottom is empty
    - if the top is full and the bottom is empty
    - if the top is empty and the bottom is full
    - if all spaces are full
   After you select an option, click the **Set Up** button.
3. **Allocate Top to Memory** will attempt to put the top process on the list in memory using the First Fit algorithm. If there is not enough space, a dialog box will pop up saying *"Insufficient Memory"*.
4. You can terminate a "running" process by entering its ID in the box next to the **Terminate** button and clicking the button.
5. As processes enter and leave memory, the memory will become more and more fragmented. **Collect Garbage** implements an algorithm to move all the empty holes to the bottom of memory and combines them.
6. At any point, you can select another option to **Set Up**. The memory will reset to the respective Setup and any running programs will terminate.

## Demo Image

![Demo Image](/demo.png)


## FileList
Form1.cs: Contains functions for actions taken on the GUI.

Form1.Designer.cs: Windows form Layout

Process.cs: Contains the *Process* class that mimics a computer process. Identical to project 1's, but only their sizes and IDs are utilized here.

MemoryList.cs: Contains two classes:
- MemoryList: Class that contains a Linked List of Blocks and functions to act on that list and the Blocks inside. Outside of the Form1 class, this class is the                main body of the program.
- Block: Object to represent space in memory. Blocks have a certain size that can contain a process if it fits.

Program.cs: Contains the main function that drives the whole program. Its kind of small since this is OOP.
