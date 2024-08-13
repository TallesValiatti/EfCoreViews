# Integrating Database Views with Entity Framework Core in .NET

This repo demonstrates how to use Entity Framework Core to integrate database views directly into your .NET application's source code.

The implementation leverages EF Core migrations to manage database views alongside tables, ensuring that views are versioned and maintained within the same codebase. By embedding the views into the migration process, this approach eliminates the need for separate scripts or manual updates, keeping your database and application code in sync.

This method provides a streamlined and maintainable strategy for managing database views, making it easier to develop and evolve your application over time.
