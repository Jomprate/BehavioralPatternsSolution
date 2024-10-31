
# Design Patterns: Chain of Responsibility, Command, & Observer

## 📋 Overview

This repository provides practical implementations of three essential behavioral design patterns in software engineering:

1. **Chain of Responsibility Pattern**
2. **Command Pattern**
3. **Observer Pattern**

These patterns are instrumental in organizing complex interactions and communications between objects, enhancing modularity and maintainability. Each example in this repository is designed to demonstrate the core principles of the pattern in a clear and practical way.

---

## 🧩 Chain of Responsibility Pattern

The Chain of Responsibility Pattern enables requests to pass through a chain of handlers. Each handler can either process the request or pass it to the next handler in the chain, making this pattern ideal for scenarios where various handlers might handle a request, but only one (or none) will process it.

### 🔨 Implementation Details
In this example, a support system is modeled with multiple support levels: `BasicSupportHandler`, `IntermediateSupportHandler`, and `AdvancedSupportHandler`. Each level attempts to handle a request; if it cannot, it forwards the request to the next level.

#### 📝 Code Example
```csharp
var handler = new BasicSupportHandler();
handler.SetNext(new IntermediateSupportHandler())
       .SetNext(new AdvancedSupportHandler());

handler.HandleRequest("Intermediate Support Required");
```

### 💻 How to Run
Navigate to the `ChainOfResponsibilityApp` directory:
```bash
cd ChainOfResponsibilityApp
```
Run the application to observe how requests are passed through the handler chain.

---

## 🎨 Command Pattern

The Command Pattern encapsulates a request as an object, allowing for parameterization, queuing, and reversible actions. This pattern decouples the class that invokes an operation from the class that knows how to execute it, offering a flexible approach to action management.

### 🔨 Implementation Details
Commands like `AccessResourceCommand` and `ModifyResourceCommand` interact with a `ResourceManager`, enabling actions to be executed and undone via an invoker.

#### 📝 Code Example
```csharp
var resourceManager = new ResourceManager();
var invoker = new CommandInvoker();

var accessCommand = new AccessResourceCommand(resourceManager);
var modifyCommand = new ModifyResourceCommand(resourceManager);

invoker.ExecuteCommand(accessCommand);
invoker.ExecuteCommand(modifyCommand);
invoker.UndoLastCommand();
```

### 💻 How to Run
Navigate to the `CommandPatternApp` directory:
```bash
cd CommandPatternApp
```
Run the application to see commands being executed and undone.

---

## 📣 Observer Pattern

The Observer Pattern establishes a one-to-many dependency between objects, so when one object (the subject) changes state, all its dependents (observers) are automatically notified and updated. This is well-suited for event-driven systems.

### 🔨 Implementation Details
In this example, `AnnouncementChannel` acts as the subject, maintaining a list of observers (e.g., `StudentObserver`). When an announcement is published, all registered observers are notified.

#### 📝 Code Example
```csharp
var channel = new AnnouncementChannel();
var student1 = new StudentObserver("Alice");
var student2 = new StudentObserver("Bob");

channel.Attach(student1);
channel.Attach(student2);
channel.PublishAnnouncement("New Assignment Released");

channel.Detach(student1);
channel.PublishAnnouncement("Assignment Deadline Updated");
```

### 💻 How to Run
Navigate to the `ObserverPatternApp` directory:
```bash
cd ObserverPatternApp
```
Run the application to see the observer pattern in action.

---

## 📂 Project Structure

This repository is organized into directories for each design pattern, with relevant handlers, commands, observers, and subjects:

### 🗂 Chain of Responsibility Pattern
```
/ChainOfResponsibilityApp
    /Handlers
        BasicSupportHandler.cs
        IntermediateSupportHandler.cs
        AdvancedSupportHandler.cs
    Program.cs
```

### 🗂 Command Pattern
```
/CommandPatternApp
    /Commands
        AccessResourceCommand.cs
        ModifyResourceCommand.cs
    /Receivers
        ResourceManager.cs
    Program.cs
```

### 🗂 Observer Pattern
```
/ObserverPatternApp
    /Observers
        IObserver.cs
        StudentObserver.cs
    /Subjects
        ISubject.cs
        AnnouncementChannel.cs
    Program.cs
```

---

## 🚀 Getting Started

### Prerequisites
- .NET SDK installed
- Visual Studio 2022 or another compatible IDE

### Steps to Run:
1. Clone the repository:
   ```bash
   git clone https://github.com/jomprate/behavioral-patterns-repository.git
   cd behavioral-patterns-repository
   ```
2. Open the solution in Visual Studio or your preferred IDE.
3. Navigate to the folder for the pattern you want to explore:
   - **Chain of Responsibility:** `/ChainOfResponsibilityApp`
   - **Command:** `/CommandPatternApp`
   - **Observer:** `/ObserverPatternApp`
4. Run the application to see each pattern in action.

---

## 🧠 Concepts Explained

- **Chain of Responsibility Pattern**: Enables a request to be processed by passing it through multiple handlers, useful for processing pipelines or event handling systems.
- **Command Pattern**: Encapsulates actions as objects, making them parameterizable and reversible, ideal for implementing undo operations.
- **Observer Pattern**: Notifies multiple observers when the subject changes, suited for event-driven systems and publisher-subscriber models.

---

## 📚 References
- [Chain of Responsibility Pattern - Wikipedia](https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern)
- [Command Pattern - Wikipedia](https://en.wikipedia.org/wiki/Command_pattern)
- [Observer Pattern - Wikipedia](https://en.wikipedia.org/wiki/Observer_pattern)

---

## 🤝 Contributions

Contributions are welcome! Feel free to fork this repository, submit issues, or make pull requests to enhance the examples or add alternative implementations.

---

## 📄 License

This repository is licensed under the MIT License. See the `LICENSE` file for details.

---

## 👨‍💻 Author

**Your Name**  
[GitHub Profile](https://github.com/jomprate)
