This is my submission for CS471 Spring 2021 Project 2. Code is found in cs471-project2 folder.

This project was developed in C# in Visual Studio 2019 using Windows Forms.

Form1.cs: Contains functions for actions taken on the GUI.

Form1.Designer.cs: Windows form Layout

Process.cs: Contains the Process class that mimics a computer process. Identical to project 1's, but only their sizes and IDs are utilized here.

MemoryList.cs: Contains two classes:
    -MemoryList: Class that contains a Linked List of Blocks and functions to act on that list and the Blocks inside. Outside of the Form1 class, this class is the main body of the program.
    -Block: Object to represent space in memory. Blocks have a certain size that can contain a process if it fits.

Program.cs: Contains the main function that drives the whole program. Its kind of small since this is OOP.
