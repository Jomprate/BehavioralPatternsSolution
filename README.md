# Design Patterns: Chain of Responsibility, Command, & Observer

## 📋 Overview

This repository contains practical implementations of three behavioral design patterns:

1. **Chain of Responsibility Pattern**
2. **Command Pattern**
3. **Observer Pattern**

These patterns are widely used to handle complex interactions and communications between objects in software, promoting modularity and maintainability. Each example in this repository is designed to illustrate the core concepts of each pattern clearly and effectively.

---

## 🧩 Chain of Responsibility Pattern

The **Chain of Responsibility Pattern** allows a request to pass along a chain of handlers. Each handler can either process the request or pass it to the next handler in the chain. This pattern is useful for situations where multiple handlers may handle a request, but only one or none may actually process it.

### 🔨 Implementation Details
In this example, we model a support system with different support levels (`BasicSupportHandler`, `IntermediateSupportHandler`, `AdvancedSupportHandler`). Each level attempts to handle the request; if it can’t, it passes the request to the next level in the chain.

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
Run the application to see how requests move through the chain of handlers.
🎨 Command Pattern
The Command Pattern encapsulates a request as an object, allowing for parameterization, queuing, and undoable operations. It decouples the class that invokes operations from the class that knows how to perform them, providing a flexible solution for action management.

🔨 Implementation Details
This implementation uses commands such as AccessResourceCommand and ModifyResourceCommand to interact with a ResourceManager, allowing actions to be executed and undone through an invoker.

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
Run the application to observe commands being executed and undone.
📣 Observer Pattern
The Observer Pattern defines a one-to-many dependency between objects so that when one object (the subject) changes state, all its dependents (observers) are notified and updated automatically. This pattern is ideal for implementing event-driven architectures.

🔨 Implementation Details
In this example, AnnouncementChannel acts as the subject, maintaining a list of observers (e.g., StudentObserver). When an announcement is published, all registered observers are notified.

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
Run the application to see how changes in the subject notify all observers.
📂 Project Structure
This repository is organized into three main directories, each containing one pattern example.

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
Allows requests to pass through multiple handlers.
Useful in scenarios like request processing pipelines or event handling systems.
Command Pattern
Encapsulates actions as objects, making them parameterizable and undoable.
Effective for implementing reversible operations and logging.
Observer Pattern
Notifies multiple observers when the subject changes.
Ideal for implementing event-driven systems and subscriber models.
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
