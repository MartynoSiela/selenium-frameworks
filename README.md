# Selenium Frameworks
The main and only purpose of this repository is to show the difference between a classical page object model structure and a static one for structuring Selenium based projects. Both structures are implemented to support running multiple tests in parallel. The code can be found in different branches of this repository.
## Page Object Model (POM)
POM structure allows structuring an automated tests project in a way that each page of a website is seen as a separate part of the whole structure. Each page is modeled as a class which contains methods that represent actions that a user can do in a website. The methods are named in such a way that it is clear what they are supposed to do. Test methods only make calls to the various POM classes and the methods inside them. Some advantages of POM structure:
- A model that is closely linked to a specific website. If a user is familiar with a website, they will be able to understand the test methods easily.
- Tests methods are easy to read overall. They only contain calls to POM methods that are named in a user oriented format
- If a complete POM structure exists, it is easy to write tests even with little knowledge of coding.
## Classical POM
In classical POM model the POM class methods are not static which means that class objects have to be created in order for the methods to be reached. On the one hand this is what OOP is supposed and all is fine with that... On the other hand if a single test has to go through let's say 3 different pages of a website then that test will have to be able to access 3 different objects of each of those pages. In the end using classical POM results with more code as one has to create object for each POM class and in some cases this might lead to quite some duplication
## Static POM
As the name states this structure uses static methods for each of POM classes. This means that the methods can be called directly from each POM class without the need for a class object. This results with a clear structure, shorter lines and less lines in general. The only issue is that in this structure, the driver object which controls the browser is also static. With the driver object being static tests cannot be run in parallel. However there is a workaround to use `ThreadLocal<>` type which seems to be working fine.
## Common Class
The main purpose of Common class is to extract methods that would be used commonly and in this way reduce the amount of duplication. Using common class also results in a better division of code. Methods that rely on Selenium packages are isolated in the Common class. This allows for easy switch to a different tool instead of Selenium.
