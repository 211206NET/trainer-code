# Procedures, Triggers, Indices, Cascading

## Procedures
Store procedure is a group of SQL statements saved in DB that can be reused over and over again. 
- [Short and Sweet Intro to SP](https://www.sqlshack.com/sql-server-stored-procedures-for-beginners/)
- [Another Article on User Defined SP](https://www.sqlshack.com/learn-sql-user-defined-stored-procedures/)
- [Lengthier tutorial on SP](https://www.sqlservertutorial.net/sql-server-stored-procedures/)
- [Why use SP?](https://www.tutorialspoint.com/what-are-the-advantages-of-stored-procedures)
- [Difference between Functions and SP](https://www.tutorialspoint.com/what-are-the-differences-between-stored-procedures-and-functions)

## Triggers
Triggers are a type of Stored Procedures that reacts to a certain type of events.
- [Nice intro on Triggers](https://www.sqlshack.com/learn-sql-sql-triggers/)
- [Another short article on triggers](https://www.c-sharpcorner.com/UploadFile/63f5c2/triggers-in-sql-server/)
- [Yet another...](https://www.geeksforgeeks.org/sql-trigger-student-database/)
- [Lengthier tutorial on triggers](https://www.sqlservertutorial.net/sql-server-triggers/)

## Indexes
Indexes are lookup tables that makes data retrieval faster. It is similar to how we use table of contents or the index in books to quickly locate the material (without the ctrl + f)! Smart use of index can dramatically improve retrieval performance.
- [Intro to Indexes](https://dataschool.com/sql-optimization/how-indexing-works/)
- [Another article on Indexes](https://www.sqlshack.com/sql-index-overview-and-strategy/)
- [Clustered vs Nonclustered Index](https://docs.microsoft.com/en-us/sql/relational-databases/indexes/clustered-and-nonclustered-indexes-described?view=sql-server-ver15)

## Cascading
DELETE and UPDATE Cascade ensures that when a record is deleted or updated, other records that reference that particular record's PK as their FK will also be deleted or updated.
- [Cascading Tutorial](https://www.sqlshack.com/delete-cascade-and-update-cascade-in-sql-server-foreign-key/)
- [MySQL tutorial on Cascade, but good nonetheless](https://www.mysqltutorial.org/mysql-on-delete-cascade/)
- [Interesting design discussion on when to use Cascades](https://stackoverflow.com/questions/59297/when-why-to-use-cascading-in-sql-server)