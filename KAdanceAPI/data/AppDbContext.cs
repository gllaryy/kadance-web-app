using Microsoft.EntityFrameworkCore;
using KAdanceAPI.models;
using System.Collections.Generic;
using System.Reflection.Emit;
namespace KAdanceAPI.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<DanceClass> DanceClasses { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanceClass>().HasData(
                new DanceClass { Id = 1, Name = "Пілатес", DayOfWeek = "Понеділок", TimeStart = "09:00", TimeEnd = "10:00", Trainer = "Ксенія" },
                new DanceClass { Id = 2, Name = "Стретчинг", DayOfWeek = "Понеділок", TimeStart = "10:00", TimeEnd = "11:00", Trainer = "Ксенія" },
                new DanceClass { Id = 3, Name = "Айро фітнес", DayOfWeek = "Понеділок", TimeStart = "11:00", TimeEnd = "12:00", Trainer = "Ксенія" },
                new DanceClass { Id = 4, Name = "Контемпорарі 8-11 років", DayOfWeek = "Понеділок", TimeStart = "15:30", TimeEnd = "17:00", Trainer = "Ксенія" },
                new DanceClass { Id = 5, Name = "Контемпорарі 12-16 років", DayOfWeek = "Понеділок", TimeStart = "17:00", TimeEnd = "18:30", Trainer = "Ксенія" },
                new DanceClass { Id = 6, Name = "Пілатес", DayOfWeek = "Понеділок", TimeStart = "19:00", TimeEnd = "20:00", Trainer = "Ксенія" },
                new DanceClass { Id = 7, Name = "Стретчинг", DayOfWeek = "Понеділок", TimeStart = "20:00", TimeEnd = "21:00", Trainer = "Ксенія" },

                new DanceClass { Id = 8, Name = "Пілатес+стретчинг", DayOfWeek = "Вівторок", TimeStart = "10:00", TimeEnd = "11:00", Trainer = "Ксенія" },
                new DanceClass { Id = 9, Name = "Контемпорарі", DayOfWeek = "Вівторок", TimeStart = "11:00", TimeEnd = "12:00", Trainer = "Ксенія" },
                new DanceClass { Id = 10, Name = "Флай стретчинг", DayOfWeek = "Вівторок", TimeStart = "12:00", TimeEnd = "13:00", Trainer = "Ксенія" },
                new DanceClass { Id = 11, Name = "ЛФК+акробатика 8-13 років", DayOfWeek = "Вівторок", TimeStart = "17:00", TimeEnd = "18:00", Trainer = "Ксенія" },
                new DanceClass { Id = 12, Name = "Гімнастика+ритміка 3-5 років", DayOfWeek = "Вівторок", TimeStart = "18:00", TimeEnd = "19:00", Trainer = "Ольга" },
                new DanceClass { Id = 13, Name = "Релакс стретчинг", DayOfWeek = "Вівторок", TimeStart = "19:00", TimeEnd = "20:00", Trainer = "Ольга" },
                new DanceClass { Id = 14, Name = "Барре", DayOfWeek = "Вівторок", TimeStart = "20:00", TimeEnd = "21:00", Trainer = "Ольга" },

                new DanceClass { Id = 15, Name = "Пілатес", DayOfWeek = "Середа", TimeStart = "09:00", TimeEnd = "10:00", Trainer = "Ксенія" },
                new DanceClass { Id = 16, Name = "Стретчинг", DayOfWeek = "Середа", TimeStart = "10:00", TimeEnd = "11:00", Trainer = "Ксенія" },
                new DanceClass { Id = 17, Name = "Айро фітнес", DayOfWeek = "Середа", TimeStart = "11:00", TimeEnd = "12:00", Trainer = "Ксенія" },
                new DanceClass { Id = 18, Name = "Контемпорарі 8-11 років", DayOfWeek = "Середа", TimeStart = "15:30", TimeEnd = "17:00", Trainer = "Ксенія" },
                new DanceClass { Id = 19, Name = "Контемпорарі 12-16 років", DayOfWeek = "Середа", TimeStart = "17:00", TimeEnd = "18:30", Trainer = "Ксенія" },
                new DanceClass { Id = 20, Name = "Пілатес", DayOfWeek = "Середа", TimeStart = "19:00", TimeEnd = "20:00", Trainer = "Ксенія" },
                new DanceClass { Id = 21, Name = "Стретчинг", DayOfWeek = "Середа", TimeStart = "20:00", TimeEnd = "21:00", Trainer = "Ксенія" },

                new DanceClass { Id = 22, Name = "Пілатес+стретчинг", DayOfWeek = "Четвер", TimeStart = "10:00", TimeEnd = "11:00", Trainer = "Ксенія" },
                new DanceClass { Id = 23, Name = "Контемпорарі", DayOfWeek = "Четвер", TimeStart = "11:00", TimeEnd = "12:00", Trainer = "Ксенія" },
                new DanceClass { Id = 24, Name = "Флай стретчинг", DayOfWeek = "Четвер", TimeStart = "12:00", TimeEnd = "13:00", Trainer = "Ксенія" },
                new DanceClass { Id = 25, Name = "ЛФК+акробатика 8-13 років", DayOfWeek = "Четвер", TimeStart = "16:30", TimeEnd = "17:30", Trainer = "Ксенія" },
                new DanceClass { Id = 26, Name = "Флай акробатика 9-14 років", DayOfWeek = "Четвер", TimeStart = "17:30", TimeEnd = "18:30", Trainer = "Марія" },
                new DanceClass { Id = 27, Name = "Флай стретчинг", DayOfWeek = "Четвер", TimeStart = "18:30", TimeEnd = "19:30", Trainer = "Ксенія" },
                new DanceClass { Id = 28, Name = "Зумба", DayOfWeek = "Четвер", TimeStart = "19:30", TimeEnd = "20:30", Trainer = "Марія" },
                new DanceClass { Id = 29, Name = "Айро фітнес", DayOfWeek = "Четвер", TimeStart = "20:30", TimeEnd = "21:30", Trainer = "Марія" },

                new DanceClass { Id = 30, Name = "Пілатес", DayOfWeek = "П'ятниця", TimeStart = "09:00", TimeEnd = "10:00", Trainer = "Ксенія" },
                new DanceClass { Id = 31, Name = "МФР стретчинг", DayOfWeek = "П'ятниця", TimeStart = "10:00", TimeEnd = "11:00", Trainer = "Ксенія" },
                new DanceClass { Id = 32, Name = "Контемпорарі 8-16 років", DayOfWeek = "П'ятниця", TimeStart = "17:00", TimeEnd = "18:00", Trainer = "Ксенія" },
                new DanceClass { Id = 33, Name = "Гімнастика+ритміка 3-5 років", DayOfWeek = "П'ятниця", TimeStart = "18:00", TimeEnd = "19:00", Trainer = "Ольга" },
                new DanceClass { Id = 34, Name = "Пілатес+стретчинг", DayOfWeek = "П'ятниця", TimeStart = "19:00", TimeEnd = "20:00", Trainer = "Ксенія" },

                new DanceClass { Id = 35, Name = "Релакс стретчинг", DayOfWeek = "Субота", TimeStart = "19:00", TimeEnd = "20:00", Trainer = "Ольга" },
                new DanceClass { Id = 36, Name = "Барре", DayOfWeek = "Субота", TimeStart = "20:00", TimeEnd = "21:00", Trainer = "Ольга" },

                new DanceClass { Id = 37, Name = "Флай акробатика 9-14 років", DayOfWeek = "Неділя", TimeStart = "17:30", TimeEnd = "18:30", Trainer = "Марія" },
                new DanceClass { Id = 38, Name = "Зумба", DayOfWeek = "Неділя", TimeStart = "18:30", TimeEnd = "19:30", Trainer = "Марія" },
                new DanceClass { Id = 39, Name = "Айро фітнес", DayOfWeek = "Неділя", TimeStart = "19:30", TimeEnd = "20:30", Trainer = "Марія" }
            );
        }
    }
}