SQL databases that are free and open-source include:

1. MySQL: One of the most popular and widely used open-source SQL databases. It is known for its speed, reliability, and ease of use. It is suitable for a wide range of applications, including web development, e-commerce, content management systems, and more.

2. PostgreSQL: A powerful and feature-rich open-source SQL database. It is known for its advanced features, extensibility, and support for complex queries. PostgreSQL is suitable for a wide range of applications, including large-scale web applications, geospatial applications, data warehousing, and more.

3. SQLite: A lightweight and embedded open-source SQL database. It is designed to be embedded into applications and is often used in mobile apps, IoT devices, and local storage for desktop applications.

4. MariaDB: A fork of MySQL that is fully compatible with it but offers some additional features and performance improvements. It is suitable for a variety of applications similar to MySQL.

NoSQL databases come in various types, each designed to handle specific data models and use cases:

1. Key-Value Stores:
   - Examples: Redis, Amazon DynamoDB, Riak
   - Use Cases: Caching, real-time analytics, session management, leaderboard systems.

2. Document Stores:
   - Examples: MongoDB, Couchbase, CouchDB
   - Use Cases: Content management systems, e-commerce, catalogs, user profiles, and flexible schema applications.

3. Column-Family Stores (Wide-Column Stores):
   - Examples: Apache Cassandra, HBase
   - Use Cases: Time-series data, analytics, recommendation systems, and big data applications.

4. Graph Databases:
   - Examples: Neo4j, Amazon Neptune, ArangoDB
   - Use Cases: Social networks, fraud detection, recommendation engines, and network analysis.

5. Object-Oriented Databases:
   - Examples: db4o, ObjectDB
   - Use Cases: Object persistence, OOP-based applications, and systems dealing with complex object structures.

The choice of a database type depends on the specific requirements of the application, including the nature of the data, scalability needs, read/write patterns, and the complexity of the queries. For example:

- If the data is structured and requires complex querying, an SQL database like MySQL or PostgreSQL may be suitable.
- If the data is semi-structured or schema-less, and flexibility is required in the data model, a document store like MongoDB can be a good fit.
- For high-throughput, low-latency scenarios where data is accessed primarily by keys, a key-value store like Redis might be a good choice.
- For applications dealing with interconnected data and complex relationships, a graph database like Neo4j can be beneficial.

Its essential to evaluate the specific requirements and characteristics of the application before choosing the appropriate database type. Often, hybrid approaches are used, where different databases are combined to handle various aspects of the application's data needs.

  
