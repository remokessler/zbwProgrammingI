# Unix

Solaris, HP Unix



# Linux

Kopie von Linus Torvel des Unix Kernels + einige GNU Tools



GNU Tools = Gimp, C Compiler etc.



# TUX Pingu

Torvel UniX

Pinguine könne nicht fliegen --> somit nicht abstürtzen :)



# Shell

Superuser #

Nomraler User $



# SSH

tcp/22

TCP/IP Secure Shell Verbindung für Vernwartung.



# WinSCP

Data Transfair tool über SSH



# Open SSH

Alternative



# Commands

sudo apt-cache search <term> to look for packages



* whoami
* pwd - print working directory
* ls
  * -l - list
  * -a - all 
  * -F - dirs with / at the end
  * -d -dirs permissions
* find
  * -name
  * -size
  * -empty
  * -exec
    * kann weitere befehle ausführen
* alias ll="ls -la"
* cat <filename[s]>  - returns content of file
* mkdir <dirname> - make directory
* rmdir <dirname>
  * -r - recursive
  * -f - force
  * -p - recursive only directories
* cp <target> <destination> -r - copy -(r)ecursive
* mv <target> <destination> - datei verschieben
*  df - lists disk space usage
* fsdisk /dev/sdb2
* mkfs.ext4 /dev/sdb2
* 

# Prozesse

Task Scheduler --> Parallelität handler

Jeder Prozess erhält via Prioritäten CPU Time



Hardware komuniziert mit Kernel

Jedes Programm hat seinen eigenen Speicherbereich und laufen voneinander isoliert



# Swaping

Swap file, falls der RAM vollläuft.



# Dateiinformationen

Datei: -

Directory: d

Block Devices: b (Festplatten, USB etc.)

Links: l

Sockets: s (Interprozess Kommunikation über Network)

Named Pipes: p (Interprozess Kommunikation ohne Network)



sda: erste festplatte

sda1: erste partition

sdb: 2. festplatte



## Filesystem

/boot (Kernel und Programme für sys start)

/dev (Geräte Dateien)

/etc (Host spezifische System wide Configs. Dienste etc auf dem Sys)

/home (Userdata)

/lib (DLL's mit Libraries)

/mnt (CD-Rom und USB Sticks)

/opt (Add-on, Software von 3 Anbieter)

/sbin (Essentielle System Binaries, Programme die nur als Sudo ausgeführt werden können)

/tmp (temporäre Dateien)

/bin (User Binaries)

/var (Variable Daten)



# Help

## man ls

/xyz (suche)

Beenden q



## apropos copy

Befehlsatz nach copy durchsuchen



## whatis cp

kurzbeschreibung



# cp --help

beschreibung über den use



## top

Budget Taskmanager



## uname -r

Kernel version



## file <path>

typ von file



# Papierkorb

/dev/null



# Aneinanderreihen von Commands

### ls -la; uname; whoami

Führt alle aus



### ls -la && uname && whoami

führ nur weiter aus, wenn vorheriger kommand successfull war.



### ls -la || uname || whoami

Weiter nur bei fehlschlag.



### ls \

### -la

Mehrzeilige Befehle können mit \ eingegeben werden.



# Permission

## chmod u/g/o+-wrx <dataname>

## chmod 777 <dataname>



Read = 4 = 100

Write = 2 = 010

Execute = 1 = 001



U = user

G = group

O = other



## chown <user><:group> <dataname>

owner change



## setuid-Bit

Berechtigung um als normaler Benutzer anzuwenden auch wenn normalerweise root benötigt wird.

in chmod signalisiert mit s



## sticky-Bit

Nur owner kann datei löschen

in chmod signalisiert mit t 



## ACL - Access Control Lists

Setzt erweiterte Berechtigungen

+am ende zeigt ACL Berechtigungen an auf File



### setfacl -m u:remo:rw /etc/hosts

setzt auf user rw

-x anstelle von -m wird Berechtigung weggenommen.



### getfacl /etc/hosts

gibt alle rechte aus

# Prozesse

## Deamons

### SysV

Startup Vorgang: Bios/Uefi --> Bootloader --> Kernel --> init (SysV) --> read inittab --> rc.sysinit, Run level 1 == terminal Server, Run level 5 == mit Desktop)  

Run Level 1-5 Definition in /etc/rc<level>.d/S(start) ||K(kill)



#### Run Level

init <level>  um den Run level zu ändern.

init 0 == shutdown

init 6 == reboot

### Systemd

Startup Vorgang: BIOS/UEFI --> Bootloader --> Kernel --> systemd --> default.target

systemctl um mit deamon zu interagieren



* systemctl list-units <--all>

* Filtern nach typ (-files für configs von services)
  * systemctl list-unit-files --type=target
  * systemctl list-units --type=service
* Abhängigkeiten
  * systemctl list-dependencies multi-user.target
  * systemctl list-dependencies sshd.service
* default target finden
  * systemctl get-default
* systemctl start, stop, status, enable, disable



## Interaktive Prozess

ps to show processes. Basicly taskmanager



-PID = Process ID

-PPID= Parent PID

-Nice= +20 - -19 (Priority -19 highest priority)

-PRI= Priority

-TTY= Terminal Session of the process

-UID= User ID who started the process

-GID= Group ID of user who started the process



which <program> --> is it installed if yes show the path



## Zeitgesteuerte/Background Prozesse

mit & kann ein Programm im Hintergrund gestarted werden



fg <PID> / bg <PID> forground or background



jobs --> shows all jobs



kill (SIGSTOP, SIGCONT, SIGTERM, SIGINT, SIGKILL, SIGHUB) <PID> --> kills a process



top --> basicly taskmanager m to toggle view



