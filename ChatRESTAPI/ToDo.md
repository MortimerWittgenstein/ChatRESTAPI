* User mit Authetifizierung -> JSON Webtoken
	* JSON Webtoken

* Nachrichten 
	* Nachrichtentypen (System, Privat, Broadcast et...)
	
---

* Datenbank -> SQL -> MSSQL => Linq to SQL
* Datenmodel  -> .dll => ChatRESTAPI.Model  Alle Klassen die Daten halten
* Core -> .dll => ChatRestapi.Core Alle Schnittstellen und Klassen die alle Projekte benötigen

		Client
			|
			|
       ChatRESTAPI

	/				\
Core				Model
	\				/
		Database

