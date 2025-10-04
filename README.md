# isys-325-hw2
WinForms application that uses textboxes and checkboxes to form a string when you press a purchase button

# How it's made
**Tech Used**: C# and WinForms

Started by putting all the controls onto the form and naming them correctly, as well as adding keyboard shortcuts. All of the functionality lies in the purchase button, which populates the summary box with a string. The real work is validating the information given in order to make sure that the summary text makes sense. An error message is displayed if the make and model isn't selected. Then, an error message is displayed if the text in the year textbox isn't a valid year (an integer). This uses TryParse and just checks if it is an integer. An enum was created for the color radio buttons. If statements are used to add the selected features to the end of the string.

# Lessons learned
I really just learned about TryParse and also a few quirks about C# mostly.
