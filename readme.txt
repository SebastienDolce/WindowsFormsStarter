Compile and run the file from the Visual Studio command prompt.

Add a class to the c# file that extends the Form class.

Create a constructor that accepts two string arguments.
Set the text in the title bar of the form to the first string.
The second string is your name. Initialize a member variable with this string. String is in the System namespace.
Set the Size (System.Drawing.Size) of the form so your panels look good.
Do not prevent the form from being resized.
Add a Panel to your form.
Set the background color (BackColor) of the panel to a System.Drawing.Color value (like Red, Green, Blue, etc.).
Dock the panel to the bottom of your form. Use the DockStyle enumeration to set the value. Use the Height and Width properties to control the original size of the form before it is docked.
Add a Label to the panel. Set the value of the label to the name, that was passed in the constructor.
Add an appropriate control to the panel and list all the controls in the entire application. Create the list dynamically by using form properties and loops.
Add another Panel to your form.
Set the background color of the panel to a System.Drawing.Color value (like Red, Green, Blue, etc.). Use a different color for this panel.
Dock the panel so it fills the remaining area of the form. Use the DockStyle enumeration to set the value.
Add a Label to the panel. Set the value of the label to Comment: . Do not display the label at point (0,0) in the panel. Use the Top and Left properties to position the label.
Add a TextBox to the panel.
Align the text box next to the label.
Anchor the text box to the top, left and right. Use the AnchorStyles enumeration to set the values, use the | operator to or more than one value together.
Set the width of the text box to a reasonable size.
Add a Button to the panel.
Align the button so it stays aligned with the right edge of the textbox.
Place the button near the lower, right corner of the panel.
Add a handler for the click event of the button. When the button is clicked, display a message box with a greeting that contains the current value of the text box.
Place an appropriate name on the button. Be sure all the text can be seen in the button.
Add a class to the c# file that has a main method. The Main method in a c# program can be overloaded with a String[] args parameter. This argument contains the command line arguments.
