CREATE TABLE Administrator(
	[Login] [nvarchar](30)  NULL,
	[Haslo] [nvarchar](30)  NULL
);
CREATE TABLE Klienci(
	[IDKlienta] [int]  NOT NULL,
	[Imie] [nvarchar](30)  NULL,
	[Nazwisko] [nvarchar](30)  NULL,
	[Email] [nvarchar](40)  NULL,
	[Haslo] [nvarchar](40) NULL,
	[IDZajecia] [int]  NULL,
	[DataDoladowania] [datetime]  NULL,
	[Karnet] [int] NULL,
	[DataWygasniecia] [datetime]  NULL,
	PRIMARY KEY(IDKlienta)
	);
CREATE TABLE Pracownicy(
	[IDPracownik] [int] NOT NULL,
	[Imie] [nvarchar](30)  NULL,
	[Nazwisko] [nvarchar](30)  NULL,
	[Email] [nvarchar](40)  NULL,
	[Haslo] [nvarchar](40) NULL,
	PRIMARY KEY(IDPracownik)
	);
CREATE TABLE Trenerzy(
	[IDTrener] [int] NOT NULL,
	[Imie] [nvarchar](30)  NULL,
	[Nazwisko] [nvarchar](30)  NULL,
	[Email] [nvarchar](40) NULL,
	[IDZajecia] [int] NOT NULL,
	PRIMARY KEY(IDTrener)
	);
CREATE TABLE Zajecia(
	[IDZajecia] [int] NOT NULL,
	[Nazwa] [nvarchar](30) NOT NULL,
	[Godzina] [time](7) NOT NULL,
	PRIMARY KEY(IDZajecia)
	); 
