CleanEventsCRM/
├── Core/ # Domain layer
│ ├── Customer/
│ │ ├── Entities/
│ │ ├── Events/
│ │ ├── Commands/
│ │ ├── Handlers/
├── Infrastructure/ # Email/log/etc.
├── API/ # Controllers
├── Program.cs

Application Traffic Flow Overview

1. HTTP Request Enters the Application
   The client (browser, mobile app, Postman, etc.) sends an HTTP request (GET, POST, etc.) to your API endpoint URL.

2. ASP.NET Core Middleware Pipeline
   The request passes through middleware components configured in Program.cs (e.g., HTTPS redirection, authentication, logging).

Middleware can modify, block, or forward the request.

3. Routing to Controller
   The request reaches the routing middleware, which matches the request URL to a specific controller action based on route attributes.

Example: GET /api/orders/123 maps to OrdersController.GetOrder(int id).

4. Controller Action Executes
   The controller method acts as the entry point for handling the request.

It usually contains minimal logic and delegates work to other components for better separation of concerns.

5. Calling MediatR
   The controller creates and sends a command or query object to MediatR via dependency injection.

MediatR acts as an in-process mediator, decoupling the controller from business logic.

6. Handler Processes Request
   MediatR dispatches the command/query to a corresponding handler (class implementing IRequestHandler<T>).

The handler contains the core business logic or orchestrates calls to services, repositories, or external APIs.

7. Business Logic & Data Access
   The handler performs operations like:

Validating data.

Querying or updating the database via repositories or Entity Framework.

Calling external services if needed.

It then returns a response/result object to MediatR.

8. Response Returned to Controller
   MediatR returns the handler’s response back to the controller.

The controller may map or transform the response into an appropriate HTTP response (e.g., JSON).

9. HTTP Response Sent to Client
   The framework serializes the response to JSON (or another format).

The response is sent back through the middleware pipeline to the client.

10. Traffic
    Client --> Middleware --> Routing --> Controller --> MediatR --> Handler --> Services/DB
    <-- Response <-- <-- <-- <-- <--
