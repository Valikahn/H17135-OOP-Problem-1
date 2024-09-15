#Basic Concepts – Tutorial 

Before you can start creating projects you must be aware that:

•	You should create a new project for each weeks tutorials<br />
•	The name of the class (physical name) should match the logical name of the class<br />
•	Each class should be tested with a driver. Remember your main program is only testing the components of the final application.<br />

Problem 1
a)	Create an object called Person. A person will have fields: forename, surname, email address, age and mobile number. <br />
b)	Create a non-argument constructor which will create an object of type Person which will hold the values: <br />
Forename:	 Gill<br />
Surname:	 Blue<br />
Email:		g.b@gmail.com<br />
Age:		22<br />
Mobile:	0798783022<br />

NOTE: adding data within a non-argument constructor is usually very rare and stupid!

c)	Create a constructor which asks for forename and surname only<br />
d)	Create a constructor which asks for forename, surname and age only<br />
e)	Create a method called displayPerson which will display the contents of all fields<br />
f)	Test points a-c using a driver class (see pages 2-3 of handout).<br />
g)	Create a method which will ask for the person’s forename, and test<br />
h)	Repeat the process for surname, email, age and mobile number.<br />
i)	Replace the code in the non-argument constructor with the method calls you have just tested. A sample is shown below. What does this mean?:<br />

```
public Person()
	  {
		/*
		forename = "Gill";
		surname = "Blue";
		email = "g.b@gmail.com";
		mobile = "0798783022";
		age = 22; */
		this.getForename();
		this.getSurname();
		this.getEmail();
		this.getMobile();
		this.getAge();
	  }
```

j)	Change the method signature for getAge to a private method and test. What’s happened? Now change it back to a public method.<br />
k)	Create a private method which will check the age of the person and if the age of the person is less than 18 will generate an error and prompt for the age until a value of over 18 is entered. <br />

To help you I have included some pseudocode<br />

 ```
	private boolean checkAge(int age)
	{
		set Boolean variable OK to true;
		if age passed is less than 18
			set OK to false
		else
			set OK to true
		return the value of OK
}	
```

l)	Now embed this method in the function getAge and test.<br />
