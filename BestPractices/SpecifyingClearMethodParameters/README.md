# Specifying Clear Method Parameters

What is the difference between a parameter and an argument?
- A parameteris part of the method signature
- An argumentis part of the method call

What is a namedargumentand when should it be used?
- A named argument uses the parameter name when calling the method
- Used to clarify the purpose of an argument and define arguments without concern for their position in the parameter list

How is an optional parameterdefined?
- By specifying a default value

What is the difference between passing an argument by value vs. by reference?
- When passed by value(which is the default), the value of the argument is passed to the method
- When passed by reference(using ref or out), the variable is effectively passed to the method
- Because of this, passing by reference enables the method to change the value of the parameter and have that change reflected in the calling code

What is the difference between refand out?
- A refparameter requires that the argument be initialized before it is passed.
	• The method can modify the value for the refparameter.
- An outparameter must be declared, but not initialized before it is passed.
	• The method mustprovide a value for the outparameter.

