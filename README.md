# Device Management System (DMS)

DMS to aplikacja do zarządzania urządzeniami która pozwala na dodawnie, edycje oraz usuwanie urządzeń jak i użytkowników 
#
#Opis projektu
Projekt jest aplikacją opartą na technologii Blazor Server, która umożliwia zarządzanie urządzeniami oraz użytkownikami. Dzięki wykorzystaniu Blazor Server, cała logika aplikacji działa po stronie serwera, co pozwoliło na zrezygnowanie z tworzenia dodatkowych endpointów API do obsługi frontendu.
#Wykorzystane technologie i narzędzia
Frameworki i biblioteki:
Blazor Server: Wykorzystany jako technologia frontendowa, umożliwiająca dynamiczne interakcje użytkownika bez konieczności odświeżania strony.
Entity Framework Core: Użyty jako ORM (Object-Relational Mapping) do komunikacji z bazą danych oraz zarządzania encjami.
MediatR: Wprowadzony w celu realizacji wzorca CQRS (Command Query Responsibility Segregation), co pozwoliło na oddzielenie logiki zapytań i komend.

#Architektura:
Projekt został zaimplementowany zgodnie z zasadami Clean Architecture, co zapewnia:
Modularność i łatwość wprowadzania zmian.
Ograniczenie zależności między warstwami aplikacji.
Ułatwione testowanie poszczególnych komponentów.
#Struktura projektu:
Application: Zawiera logikę biznesową, takie jak komendy, zapytania oraz DTO (Data Transfer Objects).
Domain: Odpowiada za definiowanie modeli domenowych oraz zasad biznesowych.
Infrastructure: Implementacja szczegółowa, np. dostęp do bazy danych z użyciem Entity Framework Core.
Web: Warstwa prezentacji, w której zaimplementowano interfejs użytkownika w technologii Blazor Server.
#Wykorzystanie narzędzi
Entity Framework Core:
Entity Framework Core został użyty do:
Mapowania obiektów domenowych na tabele w bazie danych.
Realizacji operacji CRUD w aplikacji.
Zarządzania relacjami między encjami, np. relacja jeden-do-wielu między użytkownikami a urządzeniami.
MediatR:
MediatR posłużył do:
Implementacji wzorca CQRS poprzez podział aplikacji na komendy i zapytania.
Obsługi operacji takich jak dodawanie, usuwanie czy edycja danych, dzięki wykorzystaniu handlerów.
## Autor
- Jakub Głębocki
