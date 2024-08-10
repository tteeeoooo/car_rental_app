# car_rental_app
are 5 clase:
↳Car: date despre fiecare masina in partte (id, nr de inmatriculare, culoare etc)\n
↳Car_Fleet (Singleton - in progress): pentru #singura# flota de masini
↳Reservation: pentru fiecare rezervare facuta
↳Rental: fiecare inchiriere care are date precum rezervare (zilele in care masina e rezervata), masina rezervata, clientul care a rezervat-o, pretul de inchiriere
↳Client: date despre fiecare client (not a big deal)

bd prin: entity framework core 
pana acum s-au implementat date pt.:
↳Car: 15 masini pana acum (10 + 5)
↳Car_Fleet: singura flota
↳Reservation: rezervarile (70) (adica perioadele in care exista cel putin o masina rezervata)
