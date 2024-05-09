using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreViews.Migrations
{
    /// <inheritdoc />
    public partial class AddView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE VIEW 
                AuthorBookCounting
            AS
            SELECT 
                a.Id as Id,
                a.Name AS Author,
                COUNT(b.Id) AS BookCount
            FROM 
                Authors a
            LEFT JOIN
                Books b ON b.AuthorId = a.Id
            GROUP BY 
                a.Id, a.Name;
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            DROP VIEW 
                AuthorBookCounting
                ");
        }
    }
}
