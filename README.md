This project implements the task of creating a new string array from an array of strings entered by the user from the keyboard. 
The new array consists of the values of the original array, the number of characters of which does not exceed 3. For example:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [].

To fill the source array with elements, we will enter them from the console. All elements will be of string type, so there is no need to convert them to numbers. The number of elements of the source array (array length) will also be entered from the console.
Next, use the string Length property, which returns the number of characters of the string element. We will check each value of an array element using the Length property. If the length does not exceed three, then this value is written to a new array. This is how all the values of the elements of the original array are cyclically iterated over. At the end of the program, a new array is displayed, formed from the elements of the original, not exceeding 3 characters.

