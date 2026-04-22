using HeroesApi.Models;

namespace HeroesApi.Data;

public static class HeroesStore
{

public static List<Hero> Heroes { get; } = new()
{
    new Hero
    {
        Id = 1,
        Name = "Pudge",
        RealName = "Rudj",
        Universe = Universe.Marvel,
        PowerLevel = 100,
        Powers = new() { "ХУК", "ВОНЯТЬ", "КУШАТЬ" },
        Weapon = new() { Name = "Хук", IsRanged = true },
        InternalNotes = "Любимый герой редактора"
    },
    new Hero
    {
        Id = 2,
        Name = "Трейсер",
        RealName = "Трейса",
        Universe = Universe.DC,
        PowerLevel = 75,
        Powers = new() { "интеллект", "боевые искусства", "технологии" },
        Weapon = new() { Name = "Пистолетики", IsRanged = true },
        InternalNotes = "Самая ловкая и быстрая в игре"
    },
    new Hero
    {
        Id = 3,
        Name = "Наруто",
        RealName = "Наруто Идзумаки",
        Universe = Universe.Marvel,
        PowerLevel = 100,
        Powers = new() { "интеллект", "боевые искусства", "техники" },
        Weapon = new() { Name = "Рассенган", IsRanged = true },
        InternalNotes = "Самая Крутой в ИГРЕ!!!!!"
    },
    new Hero
    {
        Id = 4,
        Name = "Cr7",
        RealName = "Криштяно Рональду",
        Universe = Universe.DC,
        PowerLevel = 1000,
        Powers = new() { "интеллект", "боевые искусства", "Быстрые ноги", "Деньги", "AURA" },
        Weapon = new() { Name = "Ноги", IsRanged = false },
        InternalNotes = "ЭТО КРИШТЯНО РОНАЛЬДУ ТУТ НЕЧЕГО СКАЗАТЬ"
    },
    new Hero
    {
        Id = 5,
        Name = "Меганайт",
        RealName = "Error",
        Universe = Universe.DC,
        PowerLevel = 50,
        Powers = new() { "боевые искусства", "технологии", "толстый" },
        Weapon = new() { Name = "два яйца в руках", IsRanged = false },
        InternalNotes = "Самый жирный из всех кроме пуджа естественно"
        }
};
}