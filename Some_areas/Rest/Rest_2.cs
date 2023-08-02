REST in System Design

REST, or REpresentational State Transfer, is an architectural style for developing web services. It provides standards for communication between computer systems on the web, making it easier for these systems to interact with each other. REST is popular due to its simplicity and the fact that it builds upon existing systems and features of the internet's Hypertext Transfer Protocol (HTTP) rather than creating new standards, frameworks, and technologies codecademy.com, techtarget.com.

Terminologies Used in REST

Resource: In REST, a resource is an abstraction of an entity that can be accessed by a client. A resource can be a document, an image, a temporal service, a collection of other resources, a non-virtual object, and more.
Endpoint: An endpoint refers to a specific URL where an API can be accessed. In REST, each URL is called a request while the data sent back to you is called a response.
Stateless: A key constraint of REST is that it’s stateless, meaning the server does not store any information about the client between requests. Each request from a client to a server must contain all the information needed to understand and process the request.
Cacheable: In REST, clients can cache responses. Responses must, implicitly or explicitly, define themselves as cacheable or non-cacheable to prevent clients from reusing stale or inappropriate data in response to further requests techtarget.com.
Patterns and Terms Used in REST

CRUD Operations: RESTful APIs commonly use CRUD (Create, Read, Update, Delete) operations which correspond to HTTP methods (POST, GET, PUT/PATCH, DELETE).
HATEOAS (Hypermedia As The Engine Of Application State): This is a principle that suggests that a client interacts with a network application entirely through hypermedia provided dynamically by the application servers. A REST client needs no prior knowledge about how to interact with an application or server beyond a generic understanding of hypermedia.
Idempotency: A request is idempotent if it can be made many times and yield the same result. In RESTful APIs, HTTP methods like GET, PUT, DELETE, HEAD, OPTIONS, and TRACE are idempotent, while POST and PATCH are not baeldung.com.
Implementation and Use Cases

RESTful services can be implemented in various programming languages and can support a wide range of data types. It's commonly used to build APIs for web services due to its simplicity, scalability, and stateless nature. It's also used to create services that are easily consumed by clients, including browsers and mobile applications freecodecamp.org.

Pros and Cons of REST

Pros: REST is simple to use and understand. It uses standard HTTP methods, status codes, and URLs, so it's easy to work with. It's stateless, so each request can be processed independently, improving scalability. RESTful APIs can return data in different formats, including XML and JSON, which are widely used in various kinds of applications.
Cons: RESTful APIs can be overkill for simple, internal integrations. Being stateless means that some types of transactions can be more complex to handle. As it heavily relies on HTTP, REST might not be as useful for real-time applications where data needs to be pushed from the server to the client in real-time baeldung.com.
