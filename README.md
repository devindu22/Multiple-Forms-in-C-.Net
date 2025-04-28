# Multiple-Forms-in-C-.Net

### Overview of the Application

This is a Windows Forms application built using the .NET framework and the System.Windows.Forms namespace. It provides a user-friendly interface to calculate a person's Body Mass Index (BMI) based on their input and display the results across two forms.
Form1: User Input
Form1 serves as the primary interface where users enter their personal data. The design and functionality are as follows:
Design
The layout is created using the Visual Studio form designer.

It features a vertical arrangement of controls for clarity and ease of use:
Four labels: 

"Name"

"Age"

"Height (in meters)"

"Weight (in kilograms)"

Four textboxes: One next to each label for user input.

Submit button: Positioned below the textboxes to process the input.

### Functionality

When the user clicks the Submit button, the following steps occur:
Input Validation:
Checks if all textboxes (Name, Age, Height, Weight) are filled. If any field is empty, a message box prompts the user to fill in all fields.

Verifies that Age, Height, and Weight are positive numbers. If not, an error message is displayed.

### BMI Calculation:

If the input is valid, the BMI is calculated using the formula:

BMI = weight / (height * height)

The result is formatted to two decimal places.

### Data Preparation:

A list is created containing the user's Name, Age, and calculated BMI.

### Navigation:

The list is passed to Form2, which is opened as a modal dialog.

### Form2: Results Display

Form2 is designed to present the calculated results in a clean and simple manner.
Design
Created using the Visual Studio form designer.

### Layout:

A label at the top titled "Results".

A listbox that occupies most of the form’s space, displaying the data passed from Form1.

### Functionality

The listbox populates with the items from the list provided by Form1 (e.g., "Name: [user input]", "Age: [user input]", "BMI: [calculated value]").

As a modal dialog, Form2 allows the user to view the results and close the form to return to Form1.

### Technical Details

Language and Framework: Written in C# using the .NET framework.

Namespace: Utilizes System.Windows.Forms for creating and managing the forms, labels, textboxes, buttons, and listbox.

Error Handling: Implemented via message boxes to ensure user-friendly feedback for invalid inputs.

Data Transfer: The results are passed from Form1 to Form2 as a list, ensuring seamless communication between the forms.

### Summary

This C# Windows Forms application provides a straightforward BMI calculator with a two-form interface. Form1 collects user input (name, age, height, and weight), validates it, and calculates the BMI, while Form2 displays the results in a listbox. The design prioritizes simplicity and usability, leveraging the Visual Studio designer for layout and the .NET framework for functionality.

