# Static Demo in C\#

## Overview

This project demonstrates the use of **static members** in a C# class. Specifically, it focuses on how a static field can be shared across all instances of a class.

The example creates a simple `Car` class with instance-level properties 
like `Make`, `Model`, `Year`, and `Color`, and a static field `Number_of_cars` 
that tracks the number of car instances created.

## Project Structure

```
static_demo_cs/
├── Program.cs
└── Solution.cs
```

## Key Concepts

### Static Members

In C#, a `static` member belongs to the **class itself**, not to any specific object. This means:

* It is shared among all instances of the class.
* It is accessed using the class name, not an instance.

In this project, the static field:

```csharp
public static int Number_of_cars;
```

is incremented every time a new `Car` object is created.

### Constructor

The constructor of the `Car` class initializes its properties and increments the `Number_of_cars` counter.

### Instance Methods

The `Drive()` method simulates a car being driven by printing out the make and model of the car.

## Output Example

When the program runs, it creates two `Car` objects and outputs:

```
MAKE: Ford
MODEL: F-150 

MAKE: Chevy
MODEL: Corvette 

NUMBER OF CARS: 2
```

## How to Run

1. Open the project in a C#-compatible IDE like Visual Studio.
2. Build and run the project.
3. Check the console output to see the static counter in action.

## Purpose

This demo serves as an educational example to:

* Understand the difference between static and instance members.
* Learn how static variables can be used for shared data (e.g., instance counting).
* Practice basic object-oriented programming in C#.

## DISCLAIMER

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY 
IN THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES 
OF THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE 
PROJECT DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED 
ACCORDINGLY TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO 
THE APPLICATION (FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES 
THAT MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. 
IF YOU ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM 
SILENTLY OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST 
OR OPEN AN ISSUE ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN 
BE ADDRESSED APPROPRIATELY BY THE MAINTAINERS OR CONTRIBUTORS.

---
