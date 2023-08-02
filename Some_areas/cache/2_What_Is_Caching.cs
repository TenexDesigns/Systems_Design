Cache in System Design

In system design, caching is a technique used to store frequently accessed data in a location that can be quickly accessed. The primary purpose of caching is to improve the performance and efficiency of a system by reducing the time it takes to access data. The cache can be a piece of hardware or software that stores data so that future requests for that data can be served faster towardsdatascience.com, geeksforgeeks.org.

Terminologies Used in Caching

Cache Hit: When the requested data is found in the cache.
Cache Miss: When the requested data is not found in the cache.
Cache Eviction: The process of removing an item from the cache.
Eviction Policy: The strategy or algorithm used to determine which items to remove from the cache when it is full. Popular policies include Least Recently Used (LRU), Most Recently Used (MRU), Least Frequently Used (LFU), and First In, First Out (FIFO) towardsdatascience.com.
Read and Write Strategies

Caching strategies often revolve around how to handle reads and writes to the cache:

Write-through Cache: Data is written into the cache and the corresponding database at the same time. This strategy ensures that the cache always contains the most recent data, but it could slow down write operations as they have to be done in two places evelyne24.github.io.
Write-back (or Write-behind) Cache: Data is first written into the cache, and then written into the database later. This strategy speeds up write operations but could lead to data loss if the cache data is not yet written back to the database when a system failure occurs evelyne24.github.io.
Patterns and Terms Used in Caching

Cache-aside (or Lazy Loading) Pattern: Data is loaded into the cache on demand. When a request is made, the system first checks the cache. If the data is not there (cache miss), it retrieves the data from the source, stores it in the cache, and then returns it.
Read-through Cache Pattern: The cache is responsible for reading from the source if the data is not in the cache. This pattern simplifies the application code but may introduce latency as every cache miss results in three sequential operations (read from source, write to cache, return data).
Write-through Cache Pattern: Every write operation is done on the cache and the source. This keeps the cache and source synchronized but may increase latency for write operations.
Write-around Cache Pattern: Data is written directly to the source, bypassing the cache. This prevents the cache from being flooded with write operations that may not subsequently be re-read javascript.plainenglish.io.
Implementation and Use Cases

Caching can be implemented in various parts of a system, such as:

In-memory Caching: This is the most common type of caching. Data is stored in the main memory (RAM) for fast access. Examples include Memcached and Redis.
Database Caching: Some databases have built-in caching to speed up common queries.
Web Server Caching: Web servers can cache static content (like HTML pages, images, and CSS files) to reduce the load on the server.
Content Delivery Network (CDN) Caching: CDNs cache content closer to the users to reduce latency and bandwidth usage.
Browser Caching: Browsers cache downloaded resources to speed up the load time of web pages.
Caching is used in various scenarios, for example, to speed up web applications, reduce database load, store session state in a distributed environment, and more geeksforgeeks.org, towardsdatascience.com.

Pros and Cons of Different Strategies

Write-through Cache:
Pros: Data in the cache is always up-to-date. Good for applications that cannot tolerate stale data.
Cons: Write operations are slower as they need to be done in two places.
Write-back Cache:
Pros: Write operations are faster as they only need to be done in the cache initially.
Cons: There is a risk





...
