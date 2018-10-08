# Creating Good Methods

What is the primary purpose of a method?
- To implement the logic required for specific behavior or functionality in a class

What is the difference between a parameter and an argument?
- A parameteris part of the method signature
- An argumentis part of the method call

What is method overloading?
- Methods with the same name and purpose but different signatures

What is method chaining?
- One method overload calls another overload to prevent repeated code

When is it best to use method overloading vs. method overriding?
- Use overloadingwhen one method requires multiple signatures
	• Such as a GetCustomer(id) to get a customer by Id and GetCustomer(name) to get the customer by name
- Use overridingwhen replacing a method defined higher up the object hierarchy.
	• Such as replacing the ToString() method

What is an expression-bodiedmethod?
- A syntax shortcut for single statement methods that return a value
