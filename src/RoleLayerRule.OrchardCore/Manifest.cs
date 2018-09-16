using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Role Layer Rule",
    Author = "David Hayden",
    Website = "https://www.davidhayden.me",
    Version = "2.0.0",
    Description = "Adds a role layer rule to display a layer based on user role.",
    Category = "Content",
    Dependencies = new[] {
        "OrchardCore.Scripting"
    }
)]