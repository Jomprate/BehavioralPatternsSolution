#Design Patterns: Chain of Responsibility, Command, & Observer


📋 Overview
This repository contains practical implementations of three behavioral design patterns:

Chain of Responsibility Pattern
Command Pattern
Observer Pattern
These patterns are widely used to handle complex interactions and communications between objects in software, promoting modularity and maintainability. Each example in this repository is designed to illustrate the core concepts of each pattern clearly and effectively.


🧩 Chain of Responsibility Pattern
The Chain of Responsibility Pattern allows a request to pass along a chain of handlers. Each handler can either process the request or pass it to the next handler in the chain. This pattern is useful for situations where multiple handlers may handle a request, but only one or none may actually process it.

🔨 Implementation Details
In this example, we model a support system with different support levels (BasicSupportHandler, IntermediateSupportHandler, AdvancedSupportHandler). Each level attempts to handle the request; if it can’t, it passes the request to the next level in the chain.

📝 Code Example:

var handler = new BasicSupportHandler();
handler.SetNext(new IntermediateSupportHandler())
       .SetNext(new AdvancedSupportHandler());

handler.HandleRequest("Intermediate Support Required");

📝 Code Example:
csharp

var handler = new BasicSupportHandler();
handler.SetNext(new IntermediateSupportHandler())
       .SetNext(new AdvancedSupportHandler());

handler.HandleRequest("Intermediate Support Required");
