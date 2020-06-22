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







# Union / Intersect / Except

Kann teilmengen (selects) miteinander verbinden

! NUR UNION WIRD UNTERSTÜTZT VON MYSQL !



# Union

Benötigt keyword All um  alles anzuzeigen sonst nur distinct



# Intersect

Was bei A und B vorkommt.

Kann emuliert werden mit subselekt und AND verknüfung



# Except

Nur die die nicht in Treffermenge A und B vorkommen.



# Index

CREATE  INDEX autid ON newauthor(aut_id, b, c);

create unique index == felder müssen einzigartig sein.

DROP INDEX autid;



SHOW INDEX FROM newauthor;



## Selektivität

Sollte 1 sein.



s = UnterscheidbareEinträge / GesammtzahlEinträge



# View

CREATE VIEW <View Name> ALGORITHM = (undefined | TEMPTABLE | MERGE) AS <SELECT XY>;

DROP VIEW <View Name>;



## Algorithm

undefined = dbms entscheidet

temptable = temptable die automatisch aktualisiert wird.

merge = view ist nicht vorabberechnet sondern als select statement eingefügt.



## Security

Rechte auf View und Darunterliegende Tabelle müssen nicht gleich sein.





# Fallunterscheidung

### Simple Case

select Case <Variable>

​	when <a>

​	when <b>

End Case

from Kunde

### Searched Case

Case 

​	when <Variable> = <val1>

​	when <Variable> = <val2>

End Case



Die beiden können nicht kombiniert werden.



#  Transactions

## ACID

- **Atomicity** − This ensures that all operations within the work unit are completed successfully; otherwise, the transaction is aborted at the point of failure and previous operations are rolled back to their former state.
- **Consistency** − This ensures that the database properly changes states upon a successfully committed transaction.
- **Isolation** − This enables transactions to operate independently on and transparent to each other.
- **Durability** − This ensures that the result or effect of a committed transaction persists in case of a system failure.



* You can control the behavior of a transaction by setting session variable called **AUTOCOMMIT**. If AUTOCOMMIT is set to 1 (the default), then each SQL statement (within a transaction or not) is considered a complete transaction and committed by default when it finishes.

* When AUTOCOMMIT is set to 0, by issuing the **SET AUTOCOMMIT = 0** command, the subsequent series of statements acts like a transaction and no activities are committed until an explicit COMMIT statement is issued.



## Multi Version Concurency Controll (MVCC)

Snapshot of db



# Stored Procedure

DELIMITER $$; -- Setzt das endzeichen auf $$ anstelle von ;

Create Procedure <name>

(<in 'var1' varchar(20 )>)

Begin <sql statement>; <sql statement2>;

End$$

DELIMITER ;



Call <name>(<arguments>);



Drop Procedure <name>;





# Variables

declare <name> <datatype> default <default wert>



# IF statements

if <condition> then <statements> else <statements2> end if;

