### What to test?
Test the outcome of the method

They are two types of function in programming
- Query 
- Command

**Query**: 
- Query functions returns some value. they don't necessarily have to query a database.
- This just means their role is to return some value.
So, for testing a query function, you should write a test and verify that your function is 
returning the right value.
- Now, you might have multiple execution paths in that function. In that case,
you should test all the execution paths and make sure that each execution path results in the right value.

**Command**: 
- A command method performs an action.
- This often involves changing the state of an object in memory, and/or writing to a database, or calling a	
web service or sending a message to a message queue and so on.
- When saving to the database you might return a value here, we need to test that value similar to query function

### Dont' Test
- Language Feature
- Third party code

### Naming and Organizing Tests
- Project Name: **TestNinja**
- UnitTest Project Name: **TestNinja.UnitTests**

### Test Classes
- Class: **Reservation**
- UnitTestClass: **ReservationTests**

### Test Method Name
[MethodName]_[Scenario]_[ExpectedBehaviour]

> write tests for a method, I would rather create all the test methods first before implementing them. I just want to brainstorm
all the different scenarios that need to be tested. This way I make sure that I won't miss a scenario when I get busy writing the

### [Setup] and [TearDown]
two special attributes. SetUp and TearDown.

You can create a method here, and decorate it with a SetUp attribute 
and then NUnit test runner will call that method before  running each test. And this is a great opportunity for us to
initialize our math object. 

Similarly,if we create a method and decorate it with the **TearDown attribute**,

NUnit test runner will call that method after

each test. Now in this course we're not going to use a TearDown

attribute, because this is often used with integration tests,

because in your integration tests, you may create some data in your database,

and then you want to do cleanup after each test. That's where

we use the TearDown attribute.
