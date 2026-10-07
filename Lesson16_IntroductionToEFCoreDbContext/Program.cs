using Lesson16_IntroductionToEFCoreDbContext;

using var context = new AppDbContext();
context.Database.EnsureCreated();

Console.WriteLine("Database ready.");
