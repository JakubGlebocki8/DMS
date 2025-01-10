# Device Management System (DMS)

DMS to aplikacja do zarządzania urządzeniami która pozwala na dodawnie, edycje oraz usuwanie urządzeń jak i użytkowników 
#
# Opis projektu
Projekt jest aplikacją opartą na technologii Blazor Server, która umożliwia zarządzanie urządzeniami oraz użytkownikami. Dzięki wykorzystaniu Blazor Server, cała logika aplikacji działa po stronie serwera, co pozwoliło na zrezygnowanie z tworzenia dodatkowych endpointów API do obsługi frontendu.
# Wykorzystane technologie i narzędzia
Frameworki i biblioteki:
- Blazor Server: Wykorzystany jako technologia frontendowa, umożliwiająca dynamiczne interakcje użytkownika bez konieczności odświeżania strony.
- Entity Framework Core: Użyty jako ORM (Object-Relational Mapping) do komunikacji z bazą danych oraz zarządzania encjami.
- MediatR: Wprowadzony w celu realizacji wzorca CQRS (Command Query Responsibility Segregation), co pozwoliło na oddzielenie logiki zapytań i komend.
- AutoMapper: Wykorzystany do mapowania obiektów domenowych na DTO (Data Transfer Objects) oraz na odwrót, co upraszcza i przyspiesza procesy konwersji danych.
- Bootstrap: Użyty do stylizacji interfejsu użytkownika, zapewniając responsywny design oraz gotowe komponenty CSS i JS.
# Architektura:
Projekt został zaimplementowany zgodnie z zasadami Clean Architecture, co zapewnia:
Modularność i łatwość wprowadzania zmian.
Ograniczenie zależności między warstwami aplikacji.
Ułatwione testowanie poszczególnych komponentów.
# Struktura projektu:
- Application: Zawiera logikę biznesową, takie jak komendy, zapytania oraz DTO (Data Transfer Objects).
- Domain: Odpowiada za definiowanie modeli domenowych oraz zasad biznesowych.
- Infrastructure: Implementacja szczegółowa, np. dostęp do bazy danych z użyciem Entity Framework Core.
- Web: Warstwa prezentacji, w której zaimplementowano interfejs użytkownika w technologii Blazor Server.
# Wykorzystanie narzędzi
- Entity Framework Core:
Entity Framework Core został użyty do:
Mapowania obiektów domenowych na tabele w bazie danych.
Realizacji operacji CRUD w aplikacji.
Zarządzania relacjami między encjami, np. relacja jeden-do-wielu między użytkownikami a urządzeniami.
- MediatR:
MediatR posłużył do:
Implementacji wzorca CQRS poprzez podział aplikacji na komendy i zapytania.
Obsługi operacji takich jak dodawanie, usuwanie czy edycja danych, dzięki wykorzystaniu handlerów.
- Bootstrap:
Bootstrap posłużył do:
Stylizacji i tworzenia responsywnych komponentów interfejsu użytkownika.
Wykorzystania gotowych elementów, takich jak tabele, formularze czy przyciski, co przyspieszyło proces tworzenia UI.
- AutoMapper:
AutoMapper został użyty do:
Automatycznego mapowania danych między warstwami aplikacji.
Ułatwienia zarządzania przepływem danych, redukując ilość ręcznie pisanej logiki konwersji.
# Do poprawy
- Rozbicie DeviceService na UserService oraz DeviceService
- Napisac validacje 
## Autor
- Jakub Głębocki
# Phtos
![image](https://github.com/user-attachments/assets/87a5522b-baed-4592-a17a-a1bfbb4f3235)
![image](https://github.com/user-attachments/assets/1f975e76-db85-475d-b4ab-a53176534533)
![image](https://github.com/user-attachments/assets/3f42a62a-9119-4182-8474-e9224a31f01d)


