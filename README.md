# Mediator Pattern with MediatR in C#

## Overview

**Mediator** is a design pattern that acts as a middleman between different parts of an application.  
Instead of objects communicating directly with each other, they send messages to the **Mediator**, which forwards them to the appropriate handler.

### Flow


1. UI sends a **command** or **query** to the mediator.  
2. The mediator finds the correct **handler**.  
3. The handler executes the logic and returns a result (for queries).  

We can use the **MediatR** library to implement this pattern.

---

## MediatR

[MediatR](https://github.com/jbogard/MediatR) simplifies the implementation of the Mediator Pattern.  
It allows you to define requests (commands and queries) and their corresponding handlers separately.

### CQRS and MediatR: Step-by-Step

Reference: [Implementing CQRS with MediatR](http://medium.com/@araxis/implementing-cqrs-with-mediatr-library-step-by-step-sample-code-2fde29a0afaf)

