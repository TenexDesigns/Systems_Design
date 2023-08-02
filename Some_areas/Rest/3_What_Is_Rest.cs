What is REST API

A REST (REpresentational State Transfer) API (Application Programming Interface) is a set of rules and conventions for building and interacting with web services. It is an architectural style that uses HTTP methods to access and manipulate resources represented in any format such as XML, JSON etc cheatsheetseries.owasp.org.

Guidelines that make up REST

State Transfer: REST is about transferring the state of resources. A REST API resource, which is identified by a URI (usually a HTTP URL), uses a representation (like JSON or XML) to capture the current or intended state of the resource and transfer that representation.
Stateless: REST APIs are stateless, meaning the server does not store any information about the client between requests. Each request from the client to the server should contain all the information needed to understand and process the request. The "state" in REST refers to the state of the resource, not the state of a session within which the API is called cheatsheetseries.owasp.org.
Standard HTTP Methods: REST APIs use standard HTTP methods like GET, POST, PUT, DELETE, etc. to perform operations on resources. Each method has a specific purpose, for example, GET is used to retrieve a resource, POST is used to create a new resource, PUT is used to update a resource, and DELETE is used to delete a resource.
Error Handling: REST APIs should return appropriate HTTP status codes along with the response to indicate the status of the request. For example, "200 OK" for successful requests, "400 Bad Request" for a request that could not be understood by the server, "401 Unauthorized" for a request that requires user authentication, and so on baeldung.com.
Path, Params, and Query Params

In REST APIs, the path in the URL typically represents the resource that the client wants to interact with. Parameters (or params) are used to identify a specific resource or a set of resources. Query parameters (or query params) are used to filter, sort, or paginate resources.

For example, in the URL https://api.example.com/users/123?active=true, /users/123 is the path that represents the user resource with the ID 123, and active=true is the query parameter that might be used to filter only active users.

HTTP Status and Response Codes

HTTP status codes are standard response codes given by web site servers on the internet. The codes help identify the cause of the problem when a web page or other resource does not load properly. In REST APIs, these status codes play a crucial role in understanding the result of the request baeldung.com.

Security and Authorization

Security is a crucial aspect of any API. REST APIs can be secured using various methods like basic authentication, token-based authentication, OAuth, etc. Authorization is about determining what a authenticated user is allowed to do. It's common to use role-based access control (RBAC) or attribute-based access control (ABAC) to manage permissions in a REST API cheatsheetseries.owasp.org.

Error Handling

Error handling in REST APIs is about how to handle errors during the execution of a request. A well-designed REST API should provide meaningful error messages along with the appropriate HTTP status codes. For example, if a resource is not found, the API should return a 404 status code along with a message explaining that the resource was not found baeldung.com.

Implementation and Use Cases

REST APIs can be implemented in any programming language that supports HTTP. They are widely used to build web services, mobile applications, and are also used for integration between different systems. The simplicity, statelessness, and the ability to handle different types of data make REST APIs suitable for a wide range of applications.

Pros and Cons

Pros: REST APIs are simple to implement and use as they work over HTTP and use standard HTTP methods. They are stateless, which makes them scalable. They can handle different types of data (XML, JSON, etc.), and can be used by clients written in any programming language.
Cons: REST APIs might not be suitable for real-time applications as they work over HTTP. They are stateless, which can make handling some types of transactions more complex. They can be overkill for simple, internal integrations.




