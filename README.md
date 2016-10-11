# Dotnet_DesignPatterns_BehaviouralPatterns

Demonstration of various Behavioural Design Patterns

---

Developed with Visual Studio 2015 Community

---

###Techs
|Tech|
|----|
|C#|
|Visual Paradigm|

---
###Design Patterns

|Pattern|Description|UML Included|
|-------|-----------|------------|
|Strategy Pattern| Simulates various payment options for a shopping cart | Yes |
|Chain of Responsibility Pattern| Simulates project approval based on budget size | Yes |
|Observer Pattern| Simulates investor notification when stock prices change | Yes |
|Command Pattern| Simulates file access commands (open, close, etc...) | Yes |
|Iterator Pattern| Demonstrates iteration through a collection of objects & an IEnumerator implementation| Yes |
---

### Strategy Pattern
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it. 

---

### Chain of Responsibility Pattern
Chain of responsibility pattern is used to achieve loose coupling in software design where a request from client is passed to a chain of objects to process them. Then the object in the chain will decide themselves who will be processing the request and whether the request is required to be sent to the next object in the chain or not. 

---

### Observer Pattern
Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. 

Observer design pattern is useful when you are interested in the state of an object and want to get notified whenever there is any change. In observer pattern, the object that watch on the state of another object are called Observer and the object that is being watched is called Subject.

---

### Command Pattern
Encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations. 

---

### Iterator Pattern

Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation

---
###More Resources
|Title|Author|Website|
|-----|------|-------|
|[.NET Design Patterns](http://www.dofactory.com/net/design-patterns)| | dofactory |
|[Architecture and patterns](https://dotnetcodr.com/architecture-and-patterns/)|Andras Nemes|dotnetcodr|
|[Creational Design Patterns](http://www.csharpstar.com/creational-design-patterns/)| | CShapster |
|[patterns & practices](https://msdn.microsoft.com/en-us/library/ff921345.aspx)||MSDN|
|[Design Patterns in Java](https://www.tutorialspoint.com/design_pattern/index.htm)||TutorialsPoint|
|[Java Design Patterns](http://www.journaldev.com/1827/java-design-patterns-example-tutorial)|Pankaj|JournalDev|
