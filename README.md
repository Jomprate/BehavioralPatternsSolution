# Design Patterns: Chain of Responsibility, Command, & Observer

## 📋 Overview

This repository contains practical implementations of three behavioral design patterns:

1. **Chain of Responsibility Pattern**
2. **Command Pattern**
3. **Observer Pattern**

These patterns are commonly used to manage the interaction and communication between objects in a software system, making it more modular, maintainable, and scalable. Each implementation provided here demonstrates the core concepts of each pattern in a clear and structured way.

---

## 🧩 Chain of Responsibility Pattern

The **Chain of Responsibility Pattern** allows a request to pass along a chain of handlers. Each handler can either process the request or pass it to the next handler in the chain. This pattern helps decouple the sender and receiver of a request and provides flexibility in request processing.

### 🔨 Implementation Details
In this implementation, each handler represents a level of support in a support system (e.g., basic, intermediate, advanced). If a handler cannot process the request, it passes it to the next handler in the chain until one is able to handle it.

### 📝 Code Example:
```csharp
var handler = new BasicSupportHandler();
handler.SetNext(new IntermediateSupportHandler())
       .SetNext(new AdvancedSupportHandler());

handler.HandleRequest("Intermediate Support Required");
💻 How to Run
Navigate to the ChainOfResponsibilityApp directory:
bash
Always show details

Copy code
cd ChainOfResponsibilityApp
Run the application to observe how requests are processed by different handlers.
🎨 Command Pattern
The Command Pattern encapsulates a request as an object, allowing for parameterization, queuing, and logging of requests, and enabling undoable operations. This pattern decouples the classes that invoke operations from those that perform them.

🔨 Implementation Details
This implementation uses commands to control actions on a resource. Commands like AccessResourceCommand and ModifyResourceCommand interact with a ResourceManager, executing specific actions and supporting undo operations.

📝 Code Example:
csharp
Always show details

Copy code
var resourceManager = new ResourceManager();
var invoker = new CommandInvoker();

var accessCommand = new AccessResourceCommand(resourceManager);
var modifyCommand = new ModifyResourceCommand(resourceManager);

invoker.ExecuteCommand(accessCommand);
invoker.ExecuteCommand(modifyCommand);
invoker.UndoLastCommand();
💻 How to Run
Navigate to the CommandPatternApp directory:
bash
Always show details

Copy code
cd CommandPatternApp
Run the application to see commands being executed and undone.
📣 Observer Pattern
The Observer Pattern defines a one-to-many dependency between objects. When one object (the subject) changes state, it automatically notifies and updates all its dependents (observers). This pattern is ideal for implementing event-driven architectures.

🔨 Implementation Details
In this implementation, AnnouncementChannel acts as the subject, which maintains a list of observers (e.g., StudentObserver). When an announcement is published, all registered observers are notified and can react to the update.

📝 Code Example:
csharp
Always show details

Copy code
var channel = new AnnouncementChannel();
var student1 = new StudentObserver("Alice");
var student2 = new StudentObserver("Bob");

channel.Attach(student1);
channel.Attach(student2);
channel.PublishAnnouncement("New Assignment Released");

channel.Detach(student1);
channel.PublishAnnouncement("Assignment Deadline Updated");
💻 How to Run
Navigate to the ObserverPatternApp directory:
bash
Always show details

Copy code
cd ObserverPatternApp
Run the application to observe how changes in the subject affect all observers.
📂 Project Structure
This repository is organized into three main directories, each demonstrating a different behavioral pattern.

🗂 Chain of Responsibility Pattern
markdown
Always show details

Copy code
/ChainOfResponsibilityApp
    /Handlers
        BasicSupportHandler.cs
        IntermediateSupportHandler.cs
        AdvancedSupportHandler.cs
    Program.cs
🗂 Command Pattern
markdown
Always show details

Copy code
/CommandPatternApp
    /Commands
        AccessResourceCommand.cs
        ModifyResourceCommand.cs
    /Receivers
        ResourceManager.cs
    Program.cs
🗂 Observer Pattern
markdown
Always show details

Copy code
/ObserverPatternApp
    /Observers
        IObserver.cs
        StudentObserver.cs
    /Subjects
        ISubject.cs
        AnnouncementChannel.cs
    Program.cs
🚀 How to Get Started
Prerequisites
.NET SDK installed
Visual Studio 2022 or any compatible IDE
Steps to Run:
Clone the repository:
bash
Always show details

Copy code
git clone https://github.com/yourusername/behavioral-patterns-repository.git
cd behavioral-patterns-repository
Open the solution in Visual Studio or your preferred IDE.
Navigate to the folder of the pattern you'd like to run:
For Chain of Responsibility, navigate to /ChainOfResponsibilityApp
For Command, navigate to /CommandPatternApp
For Observer, navigate to /ObserverPatternApp
Run the application to see the pattern in action.
🧠 Concepts Explained
Chain of Responsibility Pattern
Allows request processing to pass through multiple handlers.
Useful for support systems, event handling, or command processing.
Command Pattern
Encapsulates actions as objects, allowing them to be parameterized, queued, or undone.
Ideal for implementing reversible operations and request logging.
Observer Pattern
Notifies multiple objects of state changes in a subject.
Commonly used in event-driven programming, such as in UI frameworks.
📚 References
Chain of Responsibility Pattern - Wikipedia
Command Pattern - Wikipedia
Observer Pattern - Wikipedia
🤝 Contributions
Feel free to fork this repository, submit issues, and make pull requests to improve the code or provide alternative implementations!

📄 License
This repository is licensed under the MIT License. See the LICENSE file for more details.

👨‍💻 Author
Your Name - GitHub Profile """
