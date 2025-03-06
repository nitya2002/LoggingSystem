# Logging System - Chain of Responsibility
This project implements a logging system using the Chain of Responsibility design pattern in C#.
# Chain of Responsibility (CoR) Pattern
The Chain of Responsibility (CoR) is a behavioral design pattern that allows multiple objects (handlers) to process a request sequentially until one of them handles it.
Each handler:
Processes the request if applicable, OR
Passes it to the next handler in the chain.

## Features
- Supports multiple log levels: **Info, Debug, Error**
- Implements **Chain of Responsibility** for flexible logging
- Easily extendable for additional log levels

## How to Use
```csharp
LoggingHandler logger = new InfoHandler(new DebugHandler(new ErrorHandler(null)));
logger.log("Info", "This is an info message."
