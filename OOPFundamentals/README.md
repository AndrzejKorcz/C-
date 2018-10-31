# Object-Oriented Programming Fundamentals in C#

Object != Class

Object
var c1 = new Customer();
c1.FirstName = "Andrzej";

Class
public class Customer
    {
        public static int InstanceCount { get; set; }
   
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }


    }
}

Customer Management System
Entity		customer

Class		Customer
		•Last Name
		•First Name
		•Go On An Adventure

Objects
		Bilbo Baggins
		Frodo Baggins


Abstraction
•Simplifying reality
•Ignoring extraneous details
•Focusing on what is important for a purpose

Encapsulation
Data hiding:
•Protects the data
•Allows for authorization before getting the data
•Allows for validation before setting the data

Implementation hiding:
•Helps manage complexity
•Only the class needs to understand the implementation
•Implementation can be changed without impacting the application

Layering the Application
User Interface
•Forms or pages displayed to the user
•Logic to control the user interface elements
Business Logic
•Logic to perform the business operations
Data Access
•Logic to retrieve data from the database
•Logic to save data to the database
Common
•Common code

Visual Studio Solution
User Interface Project -> EXE
Business Logic Project -> DLL
Data Access Project -> DLL
Core.CommonProject -> DLL


Creating a New Object:
Customer customer= new Customer();
var customer = new Customer();

Accessing Properties:
var actual = customer.FullName;

Objects are Reference Types!

Static Modifier
- Declares a member that belongs to the class itself
public static int InstanceCount{ get; set; }

- Accessed using the class name
	Not an object variable

Customer.InstanceCount+= 1;

Signature:
public Customer Retrieve(int customerId) - name with parameters (not return type)

Overloading: name and parameters
public Customer Retrieve(int customerId)
public List<Customer>Retrieve()


Constract: promise that properties and methods not changed

Constructor:
public Customer()
public Customer(int customerId)

------------
Object-Oriented Programming (OOP)

Identifying
Classes:
• Represents business entities
• Defines properties (data)
• Defines methods
(actions/behavior)

Separating
Responsibilities
•Minimizes coupling
•Maximizes cohesion
• Simplifies Maintenance
• Improves Testability

Establishing
Relationships
• Defines how objects work
together to perform the
operations of the application

Leveraging
Reuse
• Involves extracting
commonality
• And building reusable
classes/components

------------
Coupling
Degree to which classes are dependent on each other

Cohesion
Degree to which members of the class relate to the purpose of the class

Separation of Concerns
Decompose an application into parts with minimal overlap
Each part is responsible for a separate concern

YAGNI
You Ain’t Gonna Need It

Design Patterns
Common practices for defining appropriate classes and their associated
relationships





