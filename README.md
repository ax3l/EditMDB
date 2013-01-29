EditMDB
=======

VB.Net Project to edit mdb files with Wine on Linux
(As I realized, that mdb files can not be edited without breaking my head
on Linux and even Mac - I wrote this project for wine)


Install
-------
Install at least with winetricks:
  jet40 mdac28
and I assume dotnet35sp1, too.

If you did so already and result with a bunch of errors,
try reinstalling with
  `winetricks --force mdac28`
  `winetricks --force jet40`


Usage
-----

Create a textfile called "mdb_query.conf" next to your .exe file.
Line1 contains: Filename.mdb
Line2 contains: Your SQL Update String (with ";" at the end)

call
  `wine yourExeFile.exe`


Troubleshooting
---------------

How-To-Use Errors could be fixed by looking at
  MDB_Query/Module1.vb
DLL-Errors are quite good documented (google) or look at Install section.



Good luck! :)
