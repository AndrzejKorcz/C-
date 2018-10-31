# Collections and Generics

Collection
A class that provides in-memory management of a group of items
• Simple types
• Complex types

Arrays
A fixed-size list of elements that can be accessed using a positional index number

Array Best Practices
Do:
Consider using an array
when the required size of a list can be determined at design time
Use a plural variable name for the array

Avoid:
Using an array when the size of the list is not known


Array Initialization Best Practices
Do:
Use collection initializers

Avoid:
Manually populating an array


Retrieving Array Element Best Practices
Do:
Take care when referencing
elements by index
Will generate a runtime exception

Avoid:
Retrieving elements by
index when you need all elements
Iterate through instead

Iterating an Array
foreach
Quick and easy
Iterate all elements
Array element is read-only

for
Complex but flexible
Iterate all or a subset of elements
Array element is editable

Frequently Asked Questions

When is it appropriate to use an array?
-When working with a list whose length is defined at design time.
-When multiple dimensions are needed.
-
To squeeze out a bit more performance with large sets.

What is the difference between foreachand forwhen iterating through an array?
-foreachprovides simple syntax for iterating all elements in an array.
-forprovides more complex but flexible syntax for iterating all or any subset of elements in an array.
•Plus the iterated items are updateable.