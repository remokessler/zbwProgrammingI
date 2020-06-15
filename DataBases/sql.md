## Abbriviations

DB = Data Base 

DBS = Data Base System == Data Access (MySQL, MSSQL, SQLite)

DBMS = Data Base Management System == MySQL Server



## Database Models



* Relationalem Modell (SQL Db)
* Hirarchisches DB Modell (XML)
* Objecktorientiertes DB Modell (?)
* Dokumentbasiertes DB Modell (Elastic Search / Mongo DB)

## Semesterarbeit

Auf Moodle. Semesterarbeit.erp



## Relationale Datenbank

Daten in Tabellen abgelegt, hat nichts mit Relationships zu tun.



## DB

Datenbank ist eine Ansamlung von Daten.



## Diagramme

* Chen Notation
* Martinnotation
  * 1 : c (can)
  * 1 : 1
  * 1 : m
  * m : n (zwei verschiedene buchstaben)
  * 1 : cm
  * m == n
* Idef1x-notation
* UML-Notation

# Starke Tabellen

Kann Schlüssel aus eigenen Felder bilden.



## Schwache Tabellen

Kann nur einen Schlüssel mit Foreignkeys bilden.



# Redundant Definition

Syntaktisch und Semantisch gleiche Informationen sind mehrfach vorhanden



# Löschweitergabe

* Restircted
* Löschweitergabe --> alle refferenzen werden mitgelöscht
* Aktualisierungs weitergabe

InnoDB bieted diese 3 Sachen an.

Nicht alle Database Engine könnnen das machen.



# Normalformen

## 1.

Alle Spalten Atomar

## 2.

Primärschlüssel bleibt gleich, auch wenn die Daten ändern.

## 3.

Keine Transitiven abhängigkeiten



# Mantissenlänge

Bei Fliesskommazahlen beeinträchtigen diese die Genauigkeit der Fliesskommazahl.



# Blob Datatyp

Binärvalue in der DB.

Nicht auswertbar.

Der Schlüssel ist nicht abhängig



# Parts of SQL

DDL - Data Definition Language

- Create, Drop, Alter

DQL - Data Query Language

* Select

DML - Data Manipulation Language

* Insert into, Update, Delete

DCL - Data Control Language

* Authorisation



# Relationenalgebra

Datenverbindungen, Mengenlehre

joins

## Selektion

Schränkt Daten Vertikal ein --> Zeilen auswählen --> Where || Having

## Projektion

Spaltenanzahl einschränken --> Selektion

## Kreuzprodukt

Jeder Datensatz der Tabelle 1 mit jedem Datensatz der Tabelle 2 kombinieren --> Join

## Export
@@secure-file-priv;
