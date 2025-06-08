# ZooManagement

Реализованные пункты функционала:

   • Добавление и удаление животных

   • Добавление и удаление вольеров

   • Перемещение животных между вольерами - сервис AnimalTransferService 

   • Просмотр расписания кормления

   • Добавление нового кормления в расписание - сервис FeedingOrganizationService 

   • Просмотр статистики зоопарка - сервис ZooStatisticsService 
   

Примененные концепции Domain-Driven Design:

     • Главные классы (Animal, Enclosure, FeedingSchedule) представляют бизнес-объекты

     • Реализация доменных событий (AnimalMovedEvent, FeedingTimeEvent) для управления событиями 
     
   
Примененные концепции Clean Architecture:

     • Разделение на слои: Domain, Application, Infrastructure, Presentation

     • Зависимости между слоями организованы через интерфейсы

     • Бизнес-логика изолирована в слоях Domain и Application

```
ZooManagement
│
├── Domain
│   ├── Classes
│   │   ├── Animal.cs
│   │   ├── Enclosure.cs
│   │   └── FeedingSchedule.cs
│   ├── Events
│   │   ├── AnimalMovedEvent.cs
│   │   └── FeedingTimeEvent.cs
│
├── Application
│   ├── Interfaces
│   │   ├── IAnimalRepository.cs
│   │   ├── IEnclosureRepository.cs
│   │   └── IFeedingScheduleRepository.cs
│   ├── Services
│   │   ├── AnimalTransferService.cs
│   │   ├── FeedingOrganizationService.cs
│   │   └── ZooStatisticsService.cs
│
├── Infrastructure
│   ├── AnimalRepository.cs
│   ├── EnclosureRepository.cs
│   └── FeedingScheduleRepository.cs
│
└── Presentation
    ├── Controllers
        ├── AnimalController.cs
        ├── EnclosureController.cs
        └── FeedingScheduleController.cs
```

**Запуск:**

http://localhost:5000/swagger
