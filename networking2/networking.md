## Subnetting

Calculation



Netzanteil, Hostanteil

Netzanteil == das Statische (255) == 1

Hostanteil== das was vergeben werden kann == 0



NetId= ip (bit and) /xyz

Broadcast= ip/26 (bit or) 26



Bei verschiedenen grössen der Subnetzbereiche immer das Grösste zuerst.



# Klassen von Netzen

## Typ A

/8

## Typ B

/16

## Typ C

/24





# Routing

Zwei Subnetzte miteinander via Default Gateway verbinden.



## Routing-Table

Static Routing

| Network     | Mask          | Exit Interfacce |
| ----------- | ------------- | --------------- |
| 172.16.0.0  | 255.255.0.0   | Ethernet 1      |
| 192.168.1.0 | 255.255.255.0 | Ethernet 2      |



## Remote Networks

Netz 1 -  Router 1 - Netz 2 - Router 2 - Netz 3



Netz 1 zu Netz 3: Router 1 & Router 2 brauchen die Routing Tabelle mit den Rechner aus Netz1 und up rout für Remote Netzwerke aus Netz 3



### IP Route

Liste im Transfairnetz (Netz 2)  



### Subnetz

Routing Tabelle wird via Subnetzt bestimmt, ob sich der Rechner im subnetzt befindet. Respektive auf welhem Port.



