EditMDB
=======

This is a VB.Net Project to edit mdb files using Wine on Linux.
The primary goal was to create a wine-compatible executable
to run a SQL *update* string against a mdb database.

(I wrote this small project as I realized that mdb files can not be *edited* without breaking my head
on Linux/Mac.)


Install
-------

Install with winetricks at least:
>  jet40 mdac28

And, as I assume

> dotnet35sp1

, too.

  `winetricks dotnet35sp1 jet40 mdac28`

If you did so already and ended up with a bunch of errors,
try reinstalling the jet/mdac packages with

  `winetricks --force mdac28`
  `winetricks --force jet40`


Usage
-----

Create a textfile called *mdb_query.conf* next to your .exe file.

> 1. Filename.mdb
> 2. Your SQL Update String (with ";" at the end)

call

  `wine yourExeFile.exe`


Troubleshooting
---------------

How-To-Use errors can be fixed by looking at
  *MDB_Query/Module1.vb*

DLL-related errors are versatile and can be solved featuring your favorite search engine (sry :) ).
But before doing so, refer to the hints at the Install section.



Good luck! :)
