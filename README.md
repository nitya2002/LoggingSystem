# Logging System - Chain of Responsibility
This project implements a logging system using the Chain of Responsibility design pattern in C#.

## Features
- Supports multiple log levels: **Info, Debug, Error**
- Implements **Chain of Responsibility** for flexible logging
- Easily extendable for additional log levels

## How to Use
```csharp
LoggingHandler logger = new InfoHandler(new DebugHandler(new ErrorHandler(null)));
logger.log("Info", "This is an info message."
