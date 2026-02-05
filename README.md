# Console File Reader (C#)

## Overview

This repository contains a C# console application built as a learning project to practice core language and runtime fundamentals.  
The application focuses on locating, validating, and reading files from the filesystem using standard .NET libraries.

The goal of this project is learning by building, not copying solutions.

---

## Learning Objectives

By completing this project, I will practice and understand:

- Console input and output
- Working with strings and user input
- File system interaction using `System.IO`
- Conditional logic and loops
- Basic error handling with exceptions
- Structuring small programs using methods
- Writing readable and maintainable C# code

---

## Project Scope

The application will:

- Ask the user for a file path
- Validate the input
- Check whether the file exists
- Read the contents of the file
- Display output in the console
- Handle errors gracefully without crashing

The project intentionally stays small and focused to reinforce fundamentals.

---

## Project Structure

The project is kept simple and readable.

General responsibilities:

- `Main` handles program flow
- User input is handled separately
- File validation and reading are split into clear steps
- Logic is decomposed into methods instead of one large function

---

## Learning Approach

This project follows a step-by-step learning approach:

1. Break each problem into small steps
2. Research only what is needed for the current step
3. Implement the solution from memory
4. Refactor when something works

Copy-pasting full solutions is intentionally avoided.

---

## Implementation Steps

### Step 1 — User Input
- Prompt the user for a file path
- Validate that the input is not empty
- Allow retrying on invalid input

### Step 2 — File Validation
- Check whether the file exists
- Provide clear feedback to the user
- Loop back if the file cannot be found

### Step 3 — File Reading
- Read the file as text
- Display the contents in the console

### Step 4 — Line-by-Line Processing
- Read the file line by line
- Practice loops and collections
- Prepare for working with larger files

### Step 5 — Error Handling
- Use `try` / `catch`
- Handle common I/O errors
- Prevent the application from crashing

---

## Optional Extensions

After the core functionality is complete, optional improvements may include:

- Counting lines or words
- Searching for a keyword
- Displaying file metadata (size, last modified date)
- Adding a simple menu system

Only a small number of extensions will be added to keep the focus on learning.

---

## Completion Criteria

This project is considered complete when:

- The user can input a file path
- Invalid input is handled correctly
- Existing files are read successfully
- Errors are handled cleanly
- The code is split into logical, readable methods

---

## Notes

This repository is intended as a learning exercise.  
The focus is on understanding concepts, not on building a production-ready tool.
